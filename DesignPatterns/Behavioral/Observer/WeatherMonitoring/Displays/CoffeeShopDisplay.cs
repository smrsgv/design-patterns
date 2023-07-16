using DesignPatterns.Behavioral.Observer.WeatherMonitoring.Displays.Common;

namespace DesignPatterns.Behavioral.Observer.WeatherMonitoring.Displays;

public class CoffeeShopDisplay : BaseDisplay, IDisplayable
{
    private readonly WeatherData _weatherData;
    private int _humidity;
    private int _pressure;
    private int _temperature;

    public CoffeeShopDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.AddDisplay(this);
    }

    public void Update()
    {
        _temperature = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        _pressure = _weatherData.Pressure;

        Display();
    }

    private void Display()
    {
        ShowData();
        Console.WriteLine($"{_temperature} --- {_humidity} --- {_pressure}");
    }
}