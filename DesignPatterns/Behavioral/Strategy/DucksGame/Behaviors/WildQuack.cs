using DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors;

public class WildQuack : IQuackBehavior
{
    public string Perform()
    {
        return "wild quack";
    }
}