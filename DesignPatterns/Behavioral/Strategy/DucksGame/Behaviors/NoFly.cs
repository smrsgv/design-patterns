using DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors;

public class NoFly : IFlyBehavior
{
    public string Perform()
    {
        return "no fly";
    }
}