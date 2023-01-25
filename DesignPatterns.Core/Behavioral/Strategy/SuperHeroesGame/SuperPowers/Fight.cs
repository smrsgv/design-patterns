using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

public class Fight : ISuperPower
{
  public string ExercisePower()
  {
    return "fight!";
  }
}
