using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;

public class NoQuack : IQuackBehavior
{
    public string Perform()
    {
        return "default quack";
    }
}