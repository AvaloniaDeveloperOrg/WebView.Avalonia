namespace Microsoft.Web.WebView2.Core;

[Serializable]
public class WebView2RuntimeNotFoundException : Exception
{
    public WebView2RuntimeNotFoundException()
        : this((Exception)null)
    {
    }

    public WebView2RuntimeNotFoundException(string message)
        : base(message)
    {
    }

    public WebView2RuntimeNotFoundException(Exception inner)
        : base("Couldn't find a compatible Webview2 Runtime installation to host WebViews.", inner)
    {
    }

    public WebView2RuntimeNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
