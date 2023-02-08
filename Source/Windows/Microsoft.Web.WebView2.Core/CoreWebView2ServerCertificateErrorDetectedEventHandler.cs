using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ServerCertificateErrorDetectedEventHandler : ICoreWebView2ServerCertificateErrorDetectedEventHandler
{
    public delegate void CallbackType(CoreWebView2ServerCertificateErrorDetectedEventArgs args);

    private CallbackType _callback;

    public CoreWebView2ServerCertificateErrorDetectedEventHandler(CallbackType callback)
    {
        _callback = callback;
    }

    public void Invoke(ICoreWebView2 source, ICoreWebView2ServerCertificateErrorDetectedEventArgs args)
    {
        _callback(new CoreWebView2ServerCertificateErrorDetectedEventArgs(args));
    }
}
