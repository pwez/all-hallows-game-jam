using Players.Controllers;
using Players.Physics;

namespace Players
{
    public interface IPlayer {
        IController Controller { get; }
        IPhysics Physics { get; }
    }
}