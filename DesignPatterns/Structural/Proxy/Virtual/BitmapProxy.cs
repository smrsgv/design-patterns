namespace DesignPatterns.Structural.Proxy.Virtual;

public class BitmapProxy : IImage
{
    private readonly string _pathToFile;
    
    private Bitmap _bitmap;
    
    public BitmapProxy(string pathToFile)
    {
        _pathToFile = pathToFile;
    }

    public bool IsFileRedFromFileSystem { get; private set; }

    public string Draw()
    {
        if (_bitmap == null)
        {
            _bitmap = new Bitmap(_pathToFile);
        }

        IsFileRedFromFileSystem = true;

        return _bitmap.Draw();
    }
}