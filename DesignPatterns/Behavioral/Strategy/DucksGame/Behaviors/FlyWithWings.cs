using DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public string Perform()
    {
        return "fly with wings";
    }
}