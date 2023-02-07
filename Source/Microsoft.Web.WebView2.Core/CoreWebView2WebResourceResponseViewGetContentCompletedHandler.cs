using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2WebResourceResponseViewGetContentCompletedHandler : ICoreWebView2WebResourceResponseViewGetContentCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public Stream Content { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2WebResourceResponseViewGetContentCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, IStream Content)
    {
        this.Content = ((Content == null) ? null : new COMStreamWrapper(Content));
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2WebResourceResponseViewGetContentCompletedHandler GetAwaiter()
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

    public Stream GetResult()
    {
        return Content;
    }
}
