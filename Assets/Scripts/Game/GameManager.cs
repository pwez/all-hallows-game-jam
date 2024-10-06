using System;
using Players;
using Players.States;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

namespace Game {
    public class GameManager : MonoBehaviour {

        public string sceneToReload;
        public Player player;
        public GameUI gameUI;
        public Transform[] teleportPositions;
        public GoalTrigger[] goalTriggers;
        
        private int _triggeredGoals;

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
            _triggeredGoals++;
            var allGoalsReached = _triggeredGoals == goalTriggers.Length;
            if (!allGoalsReached) return;

            gameUI.gameObject.SetActive(true);
        }

        public void Restart() {
            _triggeredGoals = 0;
            Cursor.lockState = CursorLockMode.Locked;
            SceneManager.LoadScene(sceneToReload);
        }
        
    }
}