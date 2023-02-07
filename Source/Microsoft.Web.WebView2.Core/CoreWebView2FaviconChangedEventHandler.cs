using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2FaviconChangedEventHandler : ICoreWebView2FaviconChangedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2FaviconChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
