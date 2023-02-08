using Appkit.WebView.Anvalonia.Imps;

namespace Appkit.WebView.Anvalonia;

partial class WebView  
{
    [SupportedOSPlatform("macos")]
    [UnsupportedOSPlatform("macos10.14")]
    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        if (!_isInitialized)
        {
            NSApplication.Init();
            _isInitialized  = true;
        }

        var webView = new MacosWebView(CGRect.Empty);
        if (Source is not null)
            webView.MainFrame.LoadRequest(new NSUrlRequest(new NSUrl(Source.ToString())));

        _webView = webView;
        var handler = new PlatformHandleImp<MacosWebView>(webView.Handle.Handle);

        return handler;
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        base.DestroyNativeControlCore(control);
        _webView?.Dispose();    
    }
}
