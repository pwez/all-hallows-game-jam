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

        public Vector3 Position { get => transform.position; set => transform.position = value; }

        public void Accelerate(Vector3 direction) {
            var forward = transform.TransformDirection(Vector3.forward); // Direction the player is facing
            var right = transform.TransformDirection(Vector3.right);
            var velocity = forward * direction.z + right * direction.x;
            transform.position += velocity * (speed * Time.deltaTime);
        }
    }
}