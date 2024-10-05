namespace Players.States
{
    public class MovingState : PlayerState {
        public override void OnResumeBy(IPlayer player) {
            base.OnResumeBy(player);

            if (HasDirectionalInput(player)) {
                player.Physics.Accelerate(player.Controller.DirectionalInput.Direction);
            }
            else {
                player.SwitchTo<IdlingState>();
            }
        }
    }
}