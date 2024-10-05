namespace StateMachines
{
    public interface IState<T> {
        void OnEnterBy(T t);
        void OnResumeBy(T t);
        void OnExitBy(T t);
    }
}