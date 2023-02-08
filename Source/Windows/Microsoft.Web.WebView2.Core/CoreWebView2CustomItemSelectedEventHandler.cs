using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CustomItemSelectedEventHandler : ICoreWebView2CustomItemSelectedEventHandler
{
    public delegate void CallbackType(EventArgs args);

    private CallbackType _callback;

    public CoreWebView2CustomItemSelectedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2ContextMenuItem source, object args)
    {
        _callback(EventArgs.Empty);
    }
}
