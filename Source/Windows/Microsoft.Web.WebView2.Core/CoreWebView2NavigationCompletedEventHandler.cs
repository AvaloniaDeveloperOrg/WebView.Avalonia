using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2NavigationCompletedEventHandler : ICoreWebView2NavigationCompletedEventHandler
{
	public delegate void CallbackType(CoreWebView2NavigationCompletedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2NavigationCompletedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2NavigationCompletedEventArgs args)
	{
		_callback(new CoreWebView2NavigationCompletedEventArgs(args));
	}
}
