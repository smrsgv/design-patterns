namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Common;

public class BaseHero : IHero
{
  private ISuperPower _superPower;

  public BaseHero(ISuperPower superPower)
  {
    _superPower = superPower;
  }

  public void ChangeSuperPower(ISuperPower sp)
  {
    _superPower = sp;
  }

  public string DoHeroStuff()
  {
    return _superPower.ExercisePower();
  }
}
