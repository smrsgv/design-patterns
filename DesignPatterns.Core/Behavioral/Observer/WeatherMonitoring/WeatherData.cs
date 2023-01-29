using DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring.Displays.Common;

namespace DesignPatterns.Core.Behavioral.Observer.WeatherMonitoring;

public class WeatherData
{
    public int Temperature { get; private set; }
    public int Humidity { get; private set; }
    public int Pressure { get; private set; }

    // observers
    public List<IDisplayable> _displays { get; set; }

    public WeatherData()
    {
        _displays = new List<IDisplayable>();
    }

    public void AddDisplay(IDisplayable display)
    {
        _displays.Add(display);
    }

    public void RemoveDisplay(IDisplayable display)
    {
        _displays.Remove(display);
    }

    public void SetMeasurements(int temperature, int humidity, int pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        RefreshDisplays();
    }

    private void RefreshDisplays()
    {
        // notify observers
        _displays.ForEach(x => x.Update());
    }
}