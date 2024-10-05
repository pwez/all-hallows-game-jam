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

        private IStateMachine<IPlayer> _stateMachine;

        private void Awake() {
            Controller = GetComponent<IController>();
            Physics = GetComponent<IPhysics>();
            _stateMachine = new PlayerStateMachine(this);
        }

        private void Update() {
            Controller.ReceiveInput();
            _stateMachine.Resume();
        }

        public void SwitchTo<T>() where T : IState<IPlayer> => _stateMachine.SwitchTo<T>();
    }
}
