using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ScriptDialogOpeningEventHandler : ICoreWebView2ScriptDialogOpeningEventHandler
{
    public delegate void CallbackType(CoreWebView2ScriptDialogOpeningEventArgs args);

    private CallbackType _callback;

    public CoreWebView2ScriptDialogOpeningEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2ScriptDialogOpeningEventArgs args)
    {
        _callback(new CoreWebView2ScriptDialogOpeningEventArgs(args));
    }
}
