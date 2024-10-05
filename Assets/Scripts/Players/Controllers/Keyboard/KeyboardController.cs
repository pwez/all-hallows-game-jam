using UnityEngine;

namespace Players.Controllers.Keyboard {
    public class KeyboardController : MonoBehaviour, IController {

        [Header("Action Input")] 
        public KeyCode action;

        private void Awake() {
            ActionInput = new KeyboardActionInput(action);
            DirectionalInput = new KeyboardDirectionalInput();
        }
        
        
        public void ReceiveInput() {
            ActionInput.Receive();
            DirectionalInput.Receive();
        }

        public IDirectionalInput DirectionalInput { get; private set; }
        public IActionInput ActionInput { get; private set; }
    }
}