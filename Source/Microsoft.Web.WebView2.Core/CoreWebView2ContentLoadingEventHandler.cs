using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ContentLoadingEventHandler : ICoreWebView2ContentLoadingEventHandler
{
	public delegate void CallbackType(CoreWebView2ContentLoadingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2ContentLoadingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2ContentLoadingEventArgs args)
	{
		_callback(new CoreWebView2ContentLoadingEventArgs(args));
	}
}
