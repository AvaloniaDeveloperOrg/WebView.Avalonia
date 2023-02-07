using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2WebMessageReceivedEventHandler : ICoreWebView2WebMessageReceivedEventHandler
{
	public delegate void CallbackType(CoreWebView2WebMessageReceivedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2WebMessageReceivedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2WebMessageReceivedEventArgs args)
	{
		_callback(new CoreWebView2WebMessageReceivedEventArgs(args));
	}
}
