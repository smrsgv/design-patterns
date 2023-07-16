namespace DesignPatterns.Structural.Proxy.Communication;

public class RemotePingable : IPingable
{
    public string Ping(string message)
    {
        // some call to external resource
        
        return $"Remote pong to {message}!";
    }
}