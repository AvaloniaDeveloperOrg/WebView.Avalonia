using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler : ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
{
    public delegate void CallbackType(EventArgs args);

    private CallbackType _callback;

    public CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, object args)
    {
        _callback(EventArgs.Empty);
    }
}
