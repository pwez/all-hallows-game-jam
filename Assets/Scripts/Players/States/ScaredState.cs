using UnityEngine;

namespace Players.States {
    public class ScaredState : PlayerState
    {
        public override void OnEnterBy(IPlayer player)
        {
            base.OnEnterBy(player);
            //player.Physics.Velocity = Vector3.zero;
            Debug.Log("Scared State");
        }

        public override void OnResumeBy(IPlayer player)
        {
            base.OnResumeBy(player);

            if (!HasDirectionalInput(player)) return;

            player.SwitchTo<MovingState>();
        }

    }
}