using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameContentLoadingEventHandler : ICoreWebView2FrameContentLoadingEventHandler
{
	public delegate void CallbackType(CoreWebView2ContentLoadingEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameContentLoadingEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2ContentLoadingEventArgs args)
	{
		_callback(new CoreWebView2ContentLoadingEventArgs(args));
	}
}
