using DesignPatterns.Structural.Proxy.Protection;

namespace DesignPatterns.Tests.Structural.Proxy;

public class ProtectionTests
{
    [Fact]
    public void CarProxy_Drive_ReturnsTooYoung()
    {
        // Arrange
        var driver = new Driver(17);
        var carProxy = new CarProxy(driver);

        // Act
        var result = carProxy.Drive();

        // Assert
        Assert.Equal("Too young", result);
    }
    
    [Fact]
    public void CarProxy_Drive_ReturnsCarHasBeenDriven()
    {
        // Arrange
        var driver = new Driver(18);
        var carProxy = new CarProxy(driver);

        // Act
        var result = carProxy.Drive();

        // Assert
        Assert.Equal("Car has been driven!", result);
    }
}