using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2DownloadStartingEventHandler : ICoreWebView2DownloadStartingEventHandler
{
    public delegate void CallbackType(CoreWebView2DownloadStartingEventArgs args);

    private CallbackType _callback;

    public CoreWebView2DownloadStartingEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2DownloadStartingEventArgs args)
    {
        _callback(new CoreWebView2DownloadStartingEventArgs(args));
    }
}
