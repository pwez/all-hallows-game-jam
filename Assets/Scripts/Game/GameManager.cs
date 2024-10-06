using System;
using Players;
using Players.States;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game {
    public class GameManager : MonoBehaviour {

        public Player player;
        public GameUI gameUI;
        public Transform[] teleportPositions;
        public GoalTrigger[] goalTriggers;
        public int triggeredGoals;

        public static GameManager Instance { get; private set; }

        private void Awake() {
            if (Instance != null && Instance != this) {
                Destroy(gameObject);
                return;
            }
            Instance = this; 
            DontDestroyOnLoad(gameObject);
        }
        
        
        private void Start() {
            player.StateMachine.SwitchStateEvent.AddListener(OnSwitchState);
        }

        private void OnSwitchState(Type stateType) {
            if (stateType != typeof(ScaredState)) return;
            
            var index = Random.Range(0, teleportPositions.Length);
            player.Physics.Position = teleportPositions[index].position;
            
            player.SwitchTo<IdlingState>();
        }

        public void OnGoalReached() {
            Debug.Log("A goal has been triggered");
            triggeredGoals++;
            var allGoalsTriggered = triggeredGoals == goalTriggers.Length;
            if (!allGoalsTriggered) return;

            Debug.Log("All Goals Triggered");
            gameUI.gameObject.SetActive(true);
        }

        public void Restart() {
            Debug.Log("Restarting game");
            
            triggeredGoals = 0;
            foreach (var goalTrigger in goalTriggers) goalTrigger.wasTriggered = false;
            
            // TODO reset player position
        }

    }
}