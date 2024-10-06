using Players.Controllers;
using Players.Controllers.Keyboard;
using Players.Physics;
using Players.States;
using StateMachines;
using UnityEngine;

namespace Players {
    [RequireComponent(typeof(KeyboardController))]
    [RequireComponent(typeof(PlayerPhysics))]
    public class Player : MonoBehaviour, IPlayer {
        
        public IController Controller { get; private set; }
        public IPhysics Physics { get; private set; }
        public IStateMachine<IPlayer> StateMachine { get; private set; }
        public PlayerSoundManager PlayerSoundManager { get; private set; }

        private void Awake() {
            Controller = GetComponent<IController>();
            Physics = GetComponent<IPhysics>();
            StateMachine = new PlayerStateMachine(this);
            PlayerSoundManager = GetComponent<PlayerSoundManager>();
        }

        private void Update() {
            Controller.ReceiveInput();
            StateMachine.Resume();
        }

        public void SwitchTo<T>() where T : IState<IPlayer> => StateMachine.SwitchTo<T>();
        
    }
}
