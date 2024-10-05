using System;

namespace StateMachines {
    public interface IStateMachine<TC> {
        Type CurrentStateType { get; }
        void SwitchTo<TS>() where TS : IState<TC>;
        void SwitchTo(Type type);
        bool Has<TS>() where TS : IState<TC>;
        void Resume();
    }
}