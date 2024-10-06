using UnityEngine;

namespace Players.Physics {
    public interface IPhysics {
        Vector3 Velocity { get; set; }
        Vector3 Position { get; set; }
        void Accelerate(Vector3 direction);
    }
}