using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Common;
using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Heroes;

public class Batman : BaseHero
{
    public Batman() : base(new Fight())
    {
    }
}