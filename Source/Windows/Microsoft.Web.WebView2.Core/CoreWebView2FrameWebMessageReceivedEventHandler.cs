using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FrameWebMessageReceivedEventHandler : ICoreWebView2FrameWebMessageReceivedEventHandler
{
	public delegate void CallbackType(CoreWebView2WebMessageReceivedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2FrameWebMessageReceivedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Frame source, ICoreWebView2WebMessageReceivedEventArgs args)
	{
		_callback(new CoreWebView2WebMessageReceivedEventArgs(args));
	}
}
