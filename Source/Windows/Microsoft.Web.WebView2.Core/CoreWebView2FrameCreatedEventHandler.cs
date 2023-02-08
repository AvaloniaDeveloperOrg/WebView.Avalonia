using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameCreatedEventHandler : ICoreWebView2FrameCreatedEventHandler
{
	public delegate void CallbackType(CoreWebView2FrameCreatedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameCreatedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2FrameCreatedEventArgs args)
	{
		_callback(new CoreWebView2FrameCreatedEventArgs(args));
	}
}
