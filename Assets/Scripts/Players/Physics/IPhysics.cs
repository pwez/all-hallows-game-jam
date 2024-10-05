using UnityEngine;

namespace Players.Physics {
    public interface IPhysics {
        Vector3 Velocity { get; set; }
        void Accelerate(Vector3 direction);
    }
}