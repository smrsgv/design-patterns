using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Heroes;
using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Tests.Behavioral.Strategy;

public class SuperHeroesTests
{
    [Fact]
    public void SuperHeroChangesSuperPower_WhenNewSuperPowerIsSet()
    {
        var superHero = new Batman();
        var initialSuperPower = superHero.DoHeroStuff();

        superHero.ChangeSuperPower(new WeaveWeb());
        var newSuperPower = superHero.DoHeroStuff();

        Assert.Equal("fight!", initialSuperPower);
        Assert.Equal("weave web", newSuperPower);
    }
}