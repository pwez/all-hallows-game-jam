using UnityEngine;

namespace Players.Controllers.Keyboard
{
    public class KeyboardDirectionalInput : IDirectionalInput {
        private readonly KeyCode _upKeyCode;
        private readonly KeyCode _downKeyCode;
        private readonly KeyCode _leftKeyCode;
        private readonly KeyCode _rightKeyCode;

        public KeyboardDirectionalInput(KeyCode upKeyCode, KeyCode downKeyCode, KeyCode leftKeyCode, KeyCode rightKeyCode) {
            _upKeyCode = upKeyCode;
            _downKeyCode = downKeyCode;
            _leftKeyCode = leftKeyCode;
            _rightKeyCode = rightKeyCode;
        }

        public void Receive() {
            X = Input.GetKey(_upKeyCode) ? 1f : 
                Input.GetKey(_downKeyCode) ? -1f 
                : 0;
            Z = Input.GetKey(_rightKeyCode) ? -1f : 
                Input.GetKey(_leftKeyCode) ? 1f 
                : 0;
        }

        public float X { get; set; }
        public float Z { get; set; }
        public Vector3 Direction => new(X, 0f, Z);
    }
}