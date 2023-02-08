using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CallDevToolsProtocolMethodCompletedHandler : ICoreWebView2CallDevToolsProtocolMethodCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public string returnObjectAsJson { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public CoreWebView2CallDevToolsProtocolMethodCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, string returnObjectAsJson)
    {
        this.returnObjectAsJson = returnObjectAsJson;
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2CallDevToolsProtocolMethodCompletedHandler GetAwaiter()
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
        return returnObjectAsJson;
    }
}
