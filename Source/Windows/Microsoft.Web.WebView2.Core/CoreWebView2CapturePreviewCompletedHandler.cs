using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CapturePreviewCompletedHandler : ICoreWebView2CapturePreviewCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2CapturePreviewCompletedHandler()
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

    public CoreWebView2CapturePreviewCompletedHandler GetAwaiter()
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
