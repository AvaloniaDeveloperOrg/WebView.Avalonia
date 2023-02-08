using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ClientCertificateRequestedEventHandler : ICoreWebView2ClientCertificateRequestedEventHandler
{
	public delegate void CallbackType(CoreWebView2ClientCertificateRequestedEventArgs args);

	private CallbackType _callback;

	public CoreWebView2ClientCertificateRequestedEventHandler(CallbackType callback)
	{
		_callback = callback;
	}

	public void Invoke(ICoreWebView2 source, ICoreWebView2ClientCertificateRequestedEventArgs args)
	{
		_callback(new CoreWebView2ClientCertificateRequestedEventArgs(args));
	}
}
