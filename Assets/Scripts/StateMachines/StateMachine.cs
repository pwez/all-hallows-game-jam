using System;
using System.Collections.Generic;

namespace StateMachines
{
    public abstract class StateMachine<TS> : IStateMachine<TS> {
        private readonly TS _ts;
        protected IDictionary<Type, IState<TS>> States;
        public Type CurrentStateType { get; protected set; }

        public SwitchStateEvent SwitchStateEvent { get; }

        protected StateMachine(TS ts) {
            _ts = ts;
            SwitchStateEvent = new SwitchStateEvent();
        }

        public void SwitchTo<TS1>() where TS1 : IState<TS> {
            var type = typeof(TS1);
            if (!States.ContainsKey(type)) return;
            if (CurrentStateType == type) return;
            if (CurrentStateType != null) States[CurrentStateType].OnExitBy(_ts);
            CurrentStateType = type;
            States[CurrentStateType].OnEnterBy(_ts);
            SwitchStateEvent.Invoke(CurrentStateType);
        }
        public void Resume() {
            if (CurrentStateType == null) return;
            if (!States.ContainsKey(CurrentStateType)) return;
            States[CurrentStateType].OnResumeBy(_ts);
        }
    }
}