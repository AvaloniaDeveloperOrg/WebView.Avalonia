using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NavigationStartingEventHandler : ICoreWebView2NavigationStartingEventHandler
{
    public delegate void CallbackType(CoreWebView2NavigationStartingEventArgs args);

    private CallbackType _callback;

    public CoreWebView2NavigationStartingEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2NavigationStartingEventArgs args)
    {
        _callback(new CoreWebView2NavigationStartingEventArgs(args));
    }
}
