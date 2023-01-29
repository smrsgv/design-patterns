using DesignPatterns.Core;
using DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring;
using DesignPatterns.Core.Behavioral.Strategy.DucksGame;
using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders;
using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame;

IPatternDemoExecutor patternDemoExecutor;

#region Behavioral

#region Strategy

//patternDemoExecutor = new DucksGameExecutor();
//patternDemoExecutor = new SuperHeroesGameExecutor();
//patternDemoExecutor = new ShippingProvidersExecutor();
patternDemoExecutor = new WeatherMonitoringExecutor();

#endregion

#endregion

patternDemoExecutor.Execute();