using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CursorChangedEventHandler : ICoreWebView2CursorChangedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2CursorChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2CompositionController source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
