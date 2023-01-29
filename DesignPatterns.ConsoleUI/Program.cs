using DesignPatterns.Core;
using DesignPatterns.Core.Behavioral.Strategy.DucksGame;
using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders;
using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame;

IPatternDemoExecutor patternDemoExecutor;

#region Behavioral

#region Strategy

//patternDemoExecutor = new DucksGameExecutor();
//patternDemoExecutor = new SuperHeroesGameExecutor();
patternDemoExecutor = new ShippingProvidersExecutor();

#endregion

#endregion

patternDemoExecutor.Execute();