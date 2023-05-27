using DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays.Common;

namespace DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays;

public class HallDisplay : BaseDisplay, IDisplayable
{
    private readonly WeatherData _weatherData;
    private int _humidity;
    private int _pressure;
    private int _temperature;

    public HallDisplay(WeatherData weatherData)
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
        Console.WriteLine($"{_temperature} ### {_humidity} ### {_pressure}");
    }
}