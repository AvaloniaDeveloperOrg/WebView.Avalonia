using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2AcceleratorKeyPressedEventHandler : ICoreWebView2AcceleratorKeyPressedEventHandler
{
	public delegate void CallbackType(CoreWebView2AcceleratorKeyPressedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2AcceleratorKeyPressedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Controller source, ICoreWebView2AcceleratorKeyPressedEventArgs args)
	{
		_callback(new CoreWebView2AcceleratorKeyPressedEventArgs(args));
	}
}
