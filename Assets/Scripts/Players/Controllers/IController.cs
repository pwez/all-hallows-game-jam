using UnityEngine;

namespace Players.Controllers
{
    public interface IController {
        void ReceiveInput();
    }

    public interface IInput {
        bool IsPressed { get; }
        bool IsHeld { get; }
        bool IsReleased { get; }
    }

    public interface IDirectionalInput {
    }

    public interface IActionInput : IInput {
    }
    
    
}