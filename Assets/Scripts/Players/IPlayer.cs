using Players.Controllers;
using Players.Physics;
using StateMachines;

namespace Players
{
    public interface IPlayer {
        IController Controller { get; }
        IPhysics Physics { get; }
        IStateMachine<IPlayer> StateMachine { get; }
        PlayerSoundManager PlayerSoundManager {get;}
        void SwitchTo<T>() where T : IState<IPlayer>;
    }
}