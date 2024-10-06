using Players;
using UnityEngine;

namespace Game {
    public class GoalTrigger : MonoBehaviour {

        public GameManager gameManager;
        public bool wasTriggered;
        
        private void OnTriggerStay(Collider other) {
            if (wasTriggered) return;
            
            var playerEntered = other.TryGetComponent<IPlayer>(out var player);
            if (!playerEntered) return;

            var actionInputIsPressed = player.Controller.ActionInput.IsHeld;
            if (!actionInputIsPressed) return;
            
            gameManager.OnGoalReached();
            wasTriggered = true;
        }
    }
}