using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Common;
using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Heroes;

public class SpiderMan : BaseHero
{
    public SpiderMan() : base(new WeaveWeb())
    {
    }
}