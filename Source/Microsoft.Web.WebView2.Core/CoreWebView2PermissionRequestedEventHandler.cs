using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PermissionRequestedEventHandler : ICoreWebView2PermissionRequestedEventHandler
{
	public delegate void CallbackType(CoreWebView2PermissionRequestedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2PermissionRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2PermissionRequestedEventArgs args)
	{
		_callback(new CoreWebView2PermissionRequestedEventArgs(args));
	}
}
