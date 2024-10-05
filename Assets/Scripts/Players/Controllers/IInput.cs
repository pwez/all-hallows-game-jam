namespace Players.Controllers
{
    public interface IInput {
        bool IsPressed { get; }
        bool IsHeld { get; }
        bool IsReleased { get; }
    }
}