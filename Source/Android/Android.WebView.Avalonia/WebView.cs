
namespace Android.WebView.Avalonia;

public partial class WebView : NativeControlHost, INativeControlHostDestroyableControlHandle, IDisposable
{

    AndroidWebView? _webView;
    WebViewClient? _webViewClient;
    WebChromeClient? _webChromeClient;

    public IntPtr Handle => _webView?.Handle ?? IntPtr.Zero;

    public string? HandleDescriptor { get; private set; }

    public void Destroy()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
