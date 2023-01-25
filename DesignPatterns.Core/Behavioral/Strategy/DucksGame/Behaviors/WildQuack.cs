using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;

public class WildQuack : IQuackBehavior
{
  public void Perform()
  {
    Console.WriteLine("wild quack");
  }
}
