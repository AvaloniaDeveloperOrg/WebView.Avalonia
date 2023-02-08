using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NewWindowRequestedEventHandler : ICoreWebView2NewWindowRequestedEventHandler
{
    public delegate void CallbackType(CoreWebView2NewWindowRequestedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2NewWindowRequestedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2NewWindowRequestedEventArgs args)
    {
        _callback(new CoreWebView2NewWindowRequestedEventArgs(args));
    }
}
