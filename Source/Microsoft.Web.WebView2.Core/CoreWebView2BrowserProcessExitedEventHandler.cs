using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2BrowserProcessExitedEventHandler : ICoreWebView2BrowserProcessExitedEventHandler
{
	public delegate void CallbackType(CoreWebView2BrowserProcessExitedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2BrowserProcessExitedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2Environment source, ICoreWebView2BrowserProcessExitedEventArgs args)
	{
		_callback(new CoreWebView2BrowserProcessExitedEventArgs(args));
	}
}
