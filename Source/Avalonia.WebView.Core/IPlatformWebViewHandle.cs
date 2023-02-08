namespace WebView.Base;
public interface IPlatformWebViewProvider : INativeControlHostDestroyableControlHandle, IDisposable
{
    IPlatformHandle CreatePlatformView(IPlatformHandle parentHandle);
    IPlatformHandle CreatePlatformView(IPlatformHandle parentHandle, Func<IPlatformHandle> defaultHanle);

    




}
