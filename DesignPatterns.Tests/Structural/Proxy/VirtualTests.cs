using DesignPatterns.Structural.Proxy.Virtual;

namespace DesignPatterns.Tests.Structural.Proxy;

public class VirtualTests
{
    [Fact]
    public void BitmapProxy_DidNot_Read_File_When_Initialized()
    {
        var bitmapProxy = new BitmapProxy(string.Empty);
        
        Assert.False(bitmapProxy.IsFileRedFromFileSystem);
    }
    
    [Fact]
    public void Bitmap_Read_File_When_Initialized()
    {
        // we should use mock here but in case of demo we will use real object
        var bitmap = new Bitmap(string.Empty);
        
        Assert.True(bitmap.IsFileRedFromFileSystem);
    }
}