using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2DevToolsProtocolEventReceivedEventHandler : ICoreWebView2DevToolsProtocolEventReceivedEventHandler
{
	public delegate void CallbackType(CoreWebView2DevToolsProtocolEventReceivedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2DevToolsProtocolEventReceivedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2DevToolsProtocolEventReceivedEventArgs args)
	{
		_callback(new CoreWebView2DevToolsProtocolEventReceivedEventArgs(args));
	}
}
