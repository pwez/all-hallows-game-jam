using System;
using System.Collections.Generic;
using StateMachines;

namespace Players.States
{
    public class PlayerStateMachine : StateMachine<IPlayer> {
        public PlayerStateMachine(IPlayer player) : base(player) {
            States = new Dictionary<Type, IState<IPlayer>> {
                { typeof(IdlingState), new IdlingState() },
                { typeof(MovingState), new MovingState() }
            };
        }
    }
}