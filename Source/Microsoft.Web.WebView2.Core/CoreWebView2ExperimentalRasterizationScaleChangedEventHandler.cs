using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ExperimentalRasterizationScaleChangedEventHandler : ICoreWebView2ExperimentalRasterizationScaleChangedEventHandler
{
	public delegate void CallbackType(EventArgs args);

	private CallbackType _callback;

	public CoreWebView2ExperimentalRasterizationScaleChangedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2ExperimentalController source, object args)
	{
		_callback(EventArgs.Empty);
	}
}
