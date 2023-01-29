using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Providers;
using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Services;

namespace DesignPatterns.Core.Behavioral.Strategy.ShippingProviders;

public class ShippingProvidersExecutor : IPatternDemoExecutor
{
    public void Execute()
    {
        var shippingService = new ShippingService(new UPS());
        var distance = 13;

        Console.WriteLine(shippingService.CalculateCostOfShipping(distance));

        shippingService.SetShippingProvider(new InPostPachkomat());
        Console.WriteLine(shippingService.CalculateCostOfShipping(distance));

        shippingService.SetShippingProvider(new DpdCourier());
        Console.WriteLine(shippingService.CalculateCostOfShipping(distance));
    }
}