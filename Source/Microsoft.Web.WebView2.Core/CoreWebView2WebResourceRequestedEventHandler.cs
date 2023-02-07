using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2WebResourceRequestedEventHandler : ICoreWebView2WebResourceRequestedEventHandler
{
	public delegate void CallbackType(CoreWebView2WebResourceRequestedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2WebResourceRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2WebResourceRequestedEventArgs args)
	{
		_callback(new CoreWebView2WebResourceRequestedEventArgs(args));
	}
}
