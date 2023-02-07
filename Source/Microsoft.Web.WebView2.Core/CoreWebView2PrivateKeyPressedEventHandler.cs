using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateKeyPressedEventHandler : ICoreWebView2PrivateKeyPressedEventHandler
{
	public delegate void CallbackType(CoreWebView2PrivateKeyPressedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2PrivateKeyPressedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Controller source, ICoreWebView2PrivateKeyPressedEventArgs args)
	{
		_callback(new CoreWebView2PrivateKeyPressedEventArgs(args));
	}
}
