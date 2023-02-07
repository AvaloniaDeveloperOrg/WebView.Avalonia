using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ProcessFailedEventHandler : ICoreWebView2ProcessFailedEventHandler
{
	public delegate void CallbackType(CoreWebView2ProcessFailedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2ProcessFailedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2ProcessFailedEventArgs args)
	{
		_callback(new CoreWebView2ProcessFailedEventArgs(args));
	}
}
