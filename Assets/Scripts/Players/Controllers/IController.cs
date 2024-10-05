namespace Players.Controllers {
    public interface IController {
        void ReceiveInput();
        IDirectionalInput DirectionalInput { get; }
        IActionInput ActionInput { get; }
    }
}