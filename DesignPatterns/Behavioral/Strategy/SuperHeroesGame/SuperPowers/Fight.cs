using DesignPatterns.Behavioral.Strategy.SuperHeroesGame.Common;

namespace DesignPatterns.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

public class Fight : ISuperPower
{
    public string ExercisePower()
    {
        return "fight!";
    }
}