using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2MoveFocusRequestedEventHandler : ICoreWebView2MoveFocusRequestedEventHandler
{
	public delegate void CallbackType(CoreWebView2MoveFocusRequestedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2MoveFocusRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Controller source, ICoreWebView2MoveFocusRequestedEventArgs args)
	{
		_callback(new CoreWebView2MoveFocusRequestedEventArgs(args));
	}
}
