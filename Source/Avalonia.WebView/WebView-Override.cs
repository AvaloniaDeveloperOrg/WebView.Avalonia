namespace Avalonia.WebView;

partial class WebView
{
    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        var platformView = _platformWebViewProvider.CreatePlatformView(parent, () => base.CreateNativeControlCore(parent));
        _platformWebView = platformView;
        return platformView ?? base.CreateNativeControlCore(parent);
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        base.DestroyNativeControlCore(control);
        _platformWebView?.Dispose();
    }
}
