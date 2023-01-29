using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Services;

public class ShippingService
{
    private IShippingProvider _shippingProvider;

    public ShippingService(IShippingProvider shippingProvider)
    {
        _shippingProvider = shippingProvider;
    }

    public int CalculateCostOfShipping(int distance)
    {
        return _shippingProvider.CalculateCost(distance);
    }

    public void SetShippingProvider(IShippingProvider shippingProvider)
    {
        _shippingProvider = shippingProvider;
    }
}