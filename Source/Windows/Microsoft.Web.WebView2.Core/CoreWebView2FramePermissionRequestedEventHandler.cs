using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FramePermissionRequestedEventHandler : ICoreWebView2FramePermissionRequestedEventHandler
{
    public delegate void CallbackType(CoreWebView2PermissionRequestedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2FramePermissionRequestedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2Frame source, ICoreWebView2PermissionRequestedEventArgs2 args)
    {
        _callback(new CoreWebView2PermissionRequestedEventArgs(args));
    }
}
