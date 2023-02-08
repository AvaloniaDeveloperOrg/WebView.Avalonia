using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2SourceChangedEventHandler : ICoreWebView2SourceChangedEventHandler
{
	public delegate void CallbackType(CoreWebView2SourceChangedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2SourceChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2SourceChangedEventArgs args)
	{
		_callback(new CoreWebView2SourceChangedEventArgs(args));
	}
}
