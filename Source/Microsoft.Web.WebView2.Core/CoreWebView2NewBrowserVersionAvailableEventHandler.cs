using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NewBrowserVersionAvailableEventHandler : ICoreWebView2NewBrowserVersionAvailableEventHandler
{
    public delegate void CallbackType(EventArgs args);

    private CallbackType _callback;

    public CoreWebView2NewBrowserVersionAvailableEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2Environment source, object args)
    {
        _callback(EventArgs.Empty);
    }
}
