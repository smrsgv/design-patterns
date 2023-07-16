using DesignPatterns.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Behavioral.Strategy.ShippingProviders.Providers;

public class InPostPachkomat : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 4;
    }
}