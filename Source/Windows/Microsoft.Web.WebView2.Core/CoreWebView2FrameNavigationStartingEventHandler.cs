using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameNavigationStartingEventHandler : ICoreWebView2FrameNavigationStartingEventHandler
{
	public delegate void CallbackType(CoreWebView2NavigationStartingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameNavigationStartingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2NavigationStartingEventArgs args)
	{
		_callback(new CoreWebView2NavigationStartingEventArgs(args));
	}
}
