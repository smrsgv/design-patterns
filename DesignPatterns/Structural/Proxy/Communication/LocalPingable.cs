namespace DesignPatterns.Structural.Proxy.Communication;

public class LocalPingable : IPingable
{
    public string Ping(string message)
    {
        return $"Locally pong to {message}!";
    }
}