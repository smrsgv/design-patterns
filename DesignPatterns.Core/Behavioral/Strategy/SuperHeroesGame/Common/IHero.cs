namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Common;

public interface IHero
{
  string DoHeroStuff();

  void ChangeSuperPower(ISuperPower sp);
}
