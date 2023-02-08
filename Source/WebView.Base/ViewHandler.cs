namespace WebView.Base;
public abstract class ViewHandler<TInterface, TPlatformView> : IPlatformViewDestroyableHandle, IDisposable
{
    protected abstract TPlatformView CreatePlatformView();

    public abstract void Destroy();

    public abstract void Dispose();
}
