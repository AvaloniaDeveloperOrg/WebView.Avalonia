using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2BytesReceivedChangedEventHandler : ICoreWebView2BytesReceivedChangedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2BytesReceivedChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2DownloadOperation source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
