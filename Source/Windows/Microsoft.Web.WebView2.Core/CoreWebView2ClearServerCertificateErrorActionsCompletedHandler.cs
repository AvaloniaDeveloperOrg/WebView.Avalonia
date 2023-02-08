using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ClearServerCertificateErrorActionsCompletedHandler : ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2ClearServerCertificateErrorActionsCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode)
    {
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2ClearServerCertificateErrorActionsCompletedHandler GetAwaiter()
    {
        return this;
    }

    public void OnCompleted(Action continuation)
    {
        this.continuation = continuation;
        if (IsCompleted)
        {
            continuation();
        }
    }

    public void GetResult()
    {
    }
}
