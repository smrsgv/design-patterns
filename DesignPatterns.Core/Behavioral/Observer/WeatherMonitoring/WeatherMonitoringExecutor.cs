using DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays;

namespace DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring;

public class WeatherMonitoringExecutor : IPatternDemoExecutor
{
    public void Execute()
    {
        var weatherData = new WeatherData();
        var gateDisplay = new GateDisplay(weatherData);
        var hallDisplay = new HallDisplay(weatherData);
        var coffeeShopDisplay = new CoffeeShopDisplay(weatherData);

        weatherData.SetMeasurements(2, 4, 6);
    }
}