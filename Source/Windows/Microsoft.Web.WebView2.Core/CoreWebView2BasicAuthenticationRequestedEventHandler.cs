using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2BasicAuthenticationRequestedEventHandler : ICoreWebView2BasicAuthenticationRequestedEventHandler
{
	public delegate void CallbackType(CoreWebView2BasicAuthenticationRequestedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2BasicAuthenticationRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2BasicAuthenticationRequestedEventArgs args)
	{
		_callback(new CoreWebView2BasicAuthenticationRequestedEventArgs(args));
	}
}
