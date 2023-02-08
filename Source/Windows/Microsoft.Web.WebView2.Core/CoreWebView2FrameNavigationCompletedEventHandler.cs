using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameNavigationCompletedEventHandler : ICoreWebView2FrameNavigationCompletedEventHandler
{
	public delegate void CallbackType(CoreWebView2NavigationCompletedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameNavigationCompletedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2NavigationCompletedEventArgs args)
	{
		_callback(new CoreWebView2NavigationCompletedEventArgs(args));
	}
}
