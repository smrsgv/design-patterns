using DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays.Common;

namespace DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays;

public class GateDisplay : BaseDisplay, IDisplayable
{
    private int _humidity;
    private int _pressure;
    private int _temperature;

    private readonly WeatherData _weatherData;

    public GateDisplay(WeatherData weatherData)
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
        Console.WriteLine($"{_temperature} *** {_humidity} *** {_pressure}");
    }
}