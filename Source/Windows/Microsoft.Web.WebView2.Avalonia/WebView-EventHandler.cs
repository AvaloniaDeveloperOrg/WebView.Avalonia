using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Avalonia;

partial class WebView
{

    public event EventHandler<CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

    public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged;

    public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting;

    public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

    public event EventHandler<EventArgs> ZoomFactorChanged;

    public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading;

    public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;
}
