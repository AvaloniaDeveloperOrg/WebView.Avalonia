using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler : ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public CoreWebView2CompositionController webView { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, ICoreWebView2CompositionController webView)
    {
        this.webView = new CoreWebView2CompositionController(webView);
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler GetAwaiter()
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

    public CoreWebView2CompositionController GetResult()
    {
        return webView;
    }
}
