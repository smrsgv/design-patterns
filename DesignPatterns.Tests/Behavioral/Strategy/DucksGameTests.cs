using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Behaviors;
using DesignPatterns.Core.Behavioral.Strategy.DucksGame.Ducks;

namespace DesignPatterns.Tests.Behavioral.Strategy;

public class DucksGameTests
{
    [Fact]
    public void DuckChangesBehavior_WhenSetNewBehavior()
    {
        var mallardDuck = new MallardDuck();
        var initialFlyBehavior = mallardDuck.Fly();

        mallardDuck.SetFlyBehavior(new FlyWithWings());
        var newFlyBehavior = mallardDuck.Fly();

        Assert.Equal("no fly", initialFlyBehavior);
        Assert.Equal("fly with wings", newFlyBehavior);
    }
}