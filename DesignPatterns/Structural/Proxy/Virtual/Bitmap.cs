namespace DesignPatterns.Structural.Proxy.Virtual;

public class Bitmap : IImage
{
    public Bitmap(string fileName)
    {
        // load image from disk
        IsFileRedFromFileSystem = true;
    }

    public bool IsFileRedFromFileSystem { get; }

    public string Draw()
    {
        return "Image loaded from the disk";
    }
}