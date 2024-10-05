namespace Players.Controllers {
    public interface IController {
        void ReceiveInput();
        IInput Get<Input>() where Input : IInput;
    }
}