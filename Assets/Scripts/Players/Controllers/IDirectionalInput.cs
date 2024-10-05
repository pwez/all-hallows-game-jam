using UnityEngine;

namespace Players.Controllers {
    public interface IDirectionalInput : IInput {
        float X { get; }
        float Z { get; }
        Vector3 Direction { get; }
    }
}