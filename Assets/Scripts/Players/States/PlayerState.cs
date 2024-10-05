using StateMachines;

namespace Players.States
{
    public abstract class PlayerState : IState<IPlayer> {
        public virtual void OnEnterBy(IPlayer t) {
        }

        public virtual void OnResumeBy(IPlayer t) {
        }

        public virtual void OnExitBy(IPlayer t) {
        }
    }
}