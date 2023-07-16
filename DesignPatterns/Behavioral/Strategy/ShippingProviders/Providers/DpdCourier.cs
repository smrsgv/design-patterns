using DesignPatterns.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Behavioral.Strategy.ShippingProviders.Providers;

public class DpdCourier : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 2;
    }
}