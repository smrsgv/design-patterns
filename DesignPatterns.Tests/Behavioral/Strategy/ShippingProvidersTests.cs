using DesignPatterns.Behavioral.Strategy.ShippingProviders.Providers;
using DesignPatterns.Behavioral.Strategy.ShippingProviders.Services;

namespace DesignPatterns.Tests.Behavioral.Strategy;

public class ShippingProvidersTests
{
    [Fact]
    public void CalculateCostOfShipping_WhenDpdCourierIsUsed_ReturnsCorrectCost()
    {
        // Arrange
        var shippingService = new ShippingService(new DpdCourier());
        var distance = 100;

        // Act
        var cost = shippingService.CalculateCostOfShipping(distance);

        // Assert
        Assert.Equal(200, cost);
    }

    [Fact]
    public void ChangeCostOfShipping_WhenProviderIsChanged_ReturnsCorrectCost()
    {
        // Arrange
        var shippingService = new ShippingService(new DpdCourier());
        var distance = 100;

        // Act
        var cost = shippingService.CalculateCostOfShipping(distance);
        shippingService.SetShippingProvider(new Ups());
        var newCost = shippingService.CalculateCostOfShipping(distance);

        // Assert
        Assert.Equal(200, cost);
        Assert.Equal(700, newCost);
    }
}