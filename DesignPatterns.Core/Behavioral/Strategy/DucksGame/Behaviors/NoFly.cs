using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;

public class NoFly : IFlyBehavior
{
  public string Perform()
  {
    return "no fly";
  }
}
