namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2InitializationCompletedEventArgs : EventArgs
{
    public bool IsSuccess => InitializationException == null;

    public Exception InitializationException { get; private set; }

    public CoreWebView2InitializationCompletedEventArgs(Exception ex = null)
    {
        InitializationException = ex;
    }
}
