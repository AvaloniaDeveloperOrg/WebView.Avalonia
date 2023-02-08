using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler : ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public string id { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, string id)
    {
        this.id = id;
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler GetAwaiter()
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

    public string GetResult()
    {
        return id;
    }
}
