using DesignPatterns.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Behavioral.Strategy.ShippingProviders.Providers;

public class Ups : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 7;
    }
}