using Android.WebView.Avalonia.Handlers;
using Android.WebView.Avalonia.Imps;

namespace Android.WebView.Avalonia;
partial class WebView
{
    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        var webView = new AndroidWebView(App.Application.Context);
        webView.Settings.SetSupportMultipleWindows(true);
        webView.Settings.JavaScriptEnabled = true;
        webView.Settings.DomStorageEnabled = true;

        _webViewClient = new WebViewClientHandler();
        webView.SetWebViewClient(_webViewClient);

        _webChromeClient = new WebChromeClientHandler();
        webView.SetWebChromeClient(_webChromeClient);

        if (Source is not null)
            webView.LoadUrl(Source.ToString());

        _webView = webView;

        var handler = new PlatformHandleImp<AndroidWebView>(webView.Handle);
        HandleDescriptor = handler.HandleDescriptor;
        return handler;
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        base.DestroyNativeControlCore(control);
        _webViewClient?.Dispose();
        _webChromeClient?.Dispose();
        _webView?.Dispose();
    }
}
