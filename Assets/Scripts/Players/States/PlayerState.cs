using StateMachines;

namespace Players.States
{
    public abstract class PlayerState : IState<IPlayer> {
        public virtual void OnEnterBy(IPlayer t) {
        }

        public virtual void OnResumeBy(IPlayer player) {
        }

        public virtual void OnExitBy(IPlayer t) {
        }
        
        protected bool HasDirectionalInput(IPlayer player) {
            return player.Controller.DirectionalInput.X != 0f || player.Controller.DirectionalInput.Z != 0f;
        }
        
    }
}