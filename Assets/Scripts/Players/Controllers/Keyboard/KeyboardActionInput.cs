using UnityEngine;

namespace Players.Controllers.Keyboard {
    public class KeyboardActionInput : IActionInput {
        private readonly KeyCode _actionKeyCode;

        public KeyboardActionInput(KeyCode actionKeyCode) {
            _actionKeyCode = actionKeyCode;
        }

        public void Receive() {
            IsPressed = Input.GetKeyDown(_actionKeyCode);
            IsHeld = Input.GetKey(_actionKeyCode);
            IsReleased = Input.GetKeyUp(_actionKeyCode);
        }
        
        public bool IsPressed { get; private set; }
        public bool IsHeld { get; private set; }
        public bool IsReleased { get; private set; }
    }
}