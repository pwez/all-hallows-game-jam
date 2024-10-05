namespace Players.Controllers
{
    public interface IActionInput : IInput {
        bool IsPressed { get; }
        bool IsHeld { get; }
        bool IsReleased { get; }
    }
}