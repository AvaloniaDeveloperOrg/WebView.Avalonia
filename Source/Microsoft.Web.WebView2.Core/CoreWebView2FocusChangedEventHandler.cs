using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FocusChangedEventHandler : ICoreWebView2FocusChangedEventHandler
{
    public delegate void CallbackType(EventArgs args);

    private CallbackType _callback;

    public CoreWebView2FocusChangedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2Controller source, object args)
    {
        _callback(EventArgs.Empty);
    }
}
