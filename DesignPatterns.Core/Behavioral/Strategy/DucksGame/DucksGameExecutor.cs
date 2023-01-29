using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;
using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Ducks;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame;

public class DucksGameExecutor : IPatternDemoExecutor
{
  public void Execute()
  {
    var mallardDuck = new MallardDuck();
    mallardDuck.Fly();
    mallardDuck.Quack();

    mallardDuck.SetFlyBehavior(new FlyWithWings());
    mallardDuck.Fly();

    mallardDuck.SetQuackBehavior(new WildQuack());
    mallardDuck.Quack();
  }
}