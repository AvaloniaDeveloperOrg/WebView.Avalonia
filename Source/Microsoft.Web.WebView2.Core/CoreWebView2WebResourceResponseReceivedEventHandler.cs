using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2WebResourceResponseReceivedEventHandler : ICoreWebView2WebResourceResponseReceivedEventHandler
{
    public delegate void CallbackType(CoreWebView2WebResourceResponseReceivedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2WebResourceResponseReceivedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2WebResourceResponseReceivedEventArgs args)
    {
        _callback(new CoreWebView2WebResourceResponseReceivedEventArgs(args));
    }
}
