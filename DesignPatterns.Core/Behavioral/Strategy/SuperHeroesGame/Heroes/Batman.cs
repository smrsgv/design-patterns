using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Common;
using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Heroes;

public class Batman : BaseHero
{
  public Batman() : base(new Fight())
  {

  }
}
