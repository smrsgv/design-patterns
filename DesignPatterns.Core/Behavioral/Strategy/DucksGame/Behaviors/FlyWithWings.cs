using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public string Perform()
    {
        return "fly with wings";
    }
}