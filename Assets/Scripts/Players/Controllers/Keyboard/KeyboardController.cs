using UnityEngine;

namespace Players.Controllers.Keyboard
{
    public class KeyboardController : MonoBehaviour, IController {

        [Header("Action Input")] 
        public KeyCode action;

        [Header("Directional Input")] 
        public KeyCode up;
        public KeyCode down;
        public KeyCode left;
        public KeyCode right;
        
        private void Awake() {
            ActionInput = new KeyboardActionInput(action);
            DirectionalInput = new KeyboardDirectionalInput(up, down, left, right);
        }
        
        
        public void ReceiveInput() {
            ActionInput.Receive();
            DirectionalInput.Receive();
        }

        public IDirectionalInput DirectionalInput { get; private set; }
        public IActionInput ActionInput { get; private set; }
    }
}