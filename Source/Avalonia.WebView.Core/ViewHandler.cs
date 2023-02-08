
namespace WebView.Base;

public abstract class ViewHandler<TInterface, TPlatformView> : IPlatformWebViewProvider 
{
    public IntPtr Handle { get; protected set; }

    public string? HandleDescriptor { get; protected set; }

    public abstract IPlatformHandle CreatePlatformView(IPlatformHandle parentHandle);

    public abstract IPlatformHandle CreatePlatformView(IPlatformHandle parentHandle, Func<IPlatformHandle> defaultHanle);

    public abstract void Destroy();

    public abstract void Dispose();
}
