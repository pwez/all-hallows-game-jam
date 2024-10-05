namespace StateMachines
{
    public interface IState<T> {
        void OnEnterBy(T t);
        void OnResumeBy(T player);
        void OnExitBy(T t);
    }
}