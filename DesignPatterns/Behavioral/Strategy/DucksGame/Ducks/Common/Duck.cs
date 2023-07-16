using DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors;
using DesignPatterns.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Behavioral.Strategy.DucksGame.Ducks.Common;

public abstract class Duck
{
    private IFlyBehavior _flyBehavior;
    private IQuackBehavior _quackBehavior;

    public Duck()
    {
        _quackBehavior = new NoQuack();
        _flyBehavior = new NoFly();
    }

    public string Quack()
    {
        return _quackBehavior.Perform();
    }

    public string Fly()
    {
        return _flyBehavior.Perform();
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        _quackBehavior = qb;
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        _flyBehavior = fb;
    }
}