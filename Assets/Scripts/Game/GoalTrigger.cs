using Players;
using UnityEngine;

namespace Game {
    public class GoalTrigger : MonoBehaviour {

        public GameManager gameManager;
        public bool wasTriggered;

        [Header("Parameters")] 
        public AudioClip audioClip;
        public AudioSource audioSource;
        public float audioPlayLength;
        public GameObject componentToDestroy;
        

        private void Awake() {
            audioSource.clip = audioClip;
        }
        
        private void OnTriggerStay(Collider other) {
            if (wasTriggered) return;
            
            var playerEntered = other.TryGetComponent<IPlayer>(out var player);
            if (!playerEntered) return;

            var actionInputIsPressed = player.Controller.ActionInput.IsHeld;
            if (!actionInputIsPressed) return;
            
            audioSource.Play();
            Destroy(componentToDestroy);
            Destroy(audioSource, audioPlayLength);
            
            gameManager.OnGoalReached();
            wasTriggered = true;
        }
    }
}