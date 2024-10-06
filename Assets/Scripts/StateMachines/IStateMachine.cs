using System;
using UnityEngine.Events;

namespace StateMachines {
    public interface IStateMachine<TC> {
        Type CurrentStateType { get; }
        SwitchStateEvent SwitchStateEvent { get; }
        void SwitchTo<TS>() where TS : IState<TC>;
        void Resume();
    }

    public class SwitchStateEvent : UnityEvent<Type> { }

}