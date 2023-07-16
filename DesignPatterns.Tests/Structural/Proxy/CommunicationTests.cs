using DesignPatterns.Structural.Proxy.Communication;
using Moq;

namespace DesignPatterns.Tests.Structural.Proxy;

public class CommunicationTests
{
    [Fact]
    public void LocalPingable_Returns_Local_Pong()
    {
        var ping = "ping";
        var mock = new Mock<IPingable>();
        mock.Setup(p => p.Ping(ping)).Returns($"Locally pong to {ping}!");

        var result = mock.Object.Ping(ping);
        Assert.Equal("Locally pong to ping!", result);
    }

    [Fact]
    public void RemotePingable_Returns_Remote_Pong()
    {
        var ping = "ping";
        var mock = new Mock<IPingable>();
        mock.Setup(p => p.Ping(ping)).Returns($"Remote pong to {ping}!");

        var result = mock.Object.Ping(ping);
        Assert.Equal("Locally pong to ping!", result);
    }
}