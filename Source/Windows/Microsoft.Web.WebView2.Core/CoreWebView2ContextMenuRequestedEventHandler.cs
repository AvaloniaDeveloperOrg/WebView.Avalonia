using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ContextMenuRequestedEventHandler : ICoreWebView2ContextMenuRequestedEventHandler
{
    public delegate void CallbackType(CoreWebView2ContextMenuRequestedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2ContextMenuRequestedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2ContextMenuRequestedEventArgs args)
    {
        _callback(new CoreWebView2ContextMenuRequestedEventArgs(args));
    }
}
