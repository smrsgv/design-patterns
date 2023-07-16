using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Common;
using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Heroes;

public class SpiderMan : BaseHero
{
    public SpiderMan() : base(new WeaveWeb())
    {
    }
}