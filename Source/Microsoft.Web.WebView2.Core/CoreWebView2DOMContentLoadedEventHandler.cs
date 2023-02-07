using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2DOMContentLoadedEventHandler : ICoreWebView2DOMContentLoadedEventHandler
{
    public delegate void CallbackType(CoreWebView2DOMContentLoadedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2DOMContentLoadedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2DOMContentLoadedEventArgs args)
    {
        _callback(new CoreWebView2DOMContentLoadedEventArgs(args));
    }
}
