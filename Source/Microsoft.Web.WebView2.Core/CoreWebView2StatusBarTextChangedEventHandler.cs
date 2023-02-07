using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2StatusBarTextChangedEventHandler : ICoreWebView2StatusBarTextChangedEventHandler
{
    public delegate void CallbackType(EventArgs args);

    private CallbackType _callback;

    public CoreWebView2StatusBarTextChangedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, object args)
    {
        _callback(EventArgs.Empty);
    }
}
