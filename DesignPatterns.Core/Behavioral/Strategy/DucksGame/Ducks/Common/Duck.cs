using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;
using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Common;

public abstract class Duck
{
  IQuackBehavior _quackBehavior;
  IFlyBehavior _flyBehavior;

  public Duck()
  {
    _quackBehavior = new NoQuack();
    _flyBehavior = new NoFly();
  }

  public void Quack()
  {
    _quackBehavior.Perform();
  }

  public void Fly()
  {
    _flyBehavior.Perform();
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