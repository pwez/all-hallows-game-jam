using System;
using Players;
using Players.States;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game {
    public class GameManager : MonoBehaviour {

        public Player player;

        public Transform[] teleportPositions; 
        
        private void Start() {
            player.StateMachine.SwitchStateEvent.AddListener(OnSwitchState);
        }

        private void OnSwitchState(Type stateType) {
            if (stateType != typeof(ScaredState)) return;
            
            var index = Random.Range(0, teleportPositions.Length);
            player.Physics.Position = teleportPositions[index].position;
            
            player.SwitchTo<IdlingState>();
        }
    }
}