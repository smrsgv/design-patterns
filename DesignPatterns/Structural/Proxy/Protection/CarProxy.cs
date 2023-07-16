namespace DesignPatterns.Structural.Proxy.Protection;

public class CarProxy : ICar
{
    private readonly Car _car = new ();
    private readonly Driver _driver;

    public CarProxy(Driver driver)
    {
        _driver = driver;
    }

    public string Drive()
    {
        if (_driver.Age>=18)
        {
            return _car.Drive();
        }

        return "Too young";
    }
}