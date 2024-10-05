using UnityEngine;

namespace Players.Controllers.Keyboard
{
    public class KeyboardDirectionalInput : IDirectionalInput {
        
        public void Receive() {
            X = Input.GetAxis("Horizontal");
            Z = Input.GetAxis("Vertical");
        }

        public float X { get; set; }
        public float Z { get; set; }
        public Vector3 Direction => new(X, 0f, Z);
    }
}