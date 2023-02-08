using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameDOMContentLoadedEventHandler : ICoreWebView2FrameDOMContentLoadedEventHandler
{
    public delegate void CallbackType(CoreWebView2DOMContentLoadedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2FrameDOMContentLoadedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2Frame source, ICoreWebView2DOMContentLoadedEventArgs args)
    {
        _callback(new CoreWebView2DOMContentLoadedEventArgs(args));
    }
}
