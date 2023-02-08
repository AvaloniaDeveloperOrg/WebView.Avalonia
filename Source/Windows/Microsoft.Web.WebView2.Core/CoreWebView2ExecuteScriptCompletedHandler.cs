using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2ExecuteScriptCompletedHandler : ICoreWebView2ExecuteScriptCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public string resultObjectAsJson { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2ExecuteScriptCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, string resultObjectAsJson)
    {
        this.resultObjectAsJson = resultObjectAsJson;
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2ExecuteScriptCompletedHandler GetAwaiter()
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
        return resultObjectAsJson;
    }
}
