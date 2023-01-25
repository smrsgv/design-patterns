using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;

public class NoFly : IFlyBehavior
{
  public void Perform()
  {
    Console.WriteLine("no fly");
  }
}
