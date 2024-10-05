using UnityEngine;

namespace Players.Physics {
    [RequireComponent(typeof(BoxCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerPhysics : MonoBehaviour, IPhysics {

        [Header("Parameters")]
        [SerializeField] private float speed;
        
        private Collider _collider;
        private Rigidbody _rigidbody;

        private void Awake() {
            _collider = GetComponent<Collider>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        public Vector3 Velocity {
            get => _rigidbody.velocity;
            set => _rigidbody.velocity = value;
        }

        public void Accelerate(Vector3 direction) {
            _rigidbody.velocity = speed * direction;
        }
    }
}