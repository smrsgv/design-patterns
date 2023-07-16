namespace DesignPatterns.Behavioral.Strategy.ShippingProviders.Common;

public interface IShippingProvider
{
    int CalculateCost(int distance);
}