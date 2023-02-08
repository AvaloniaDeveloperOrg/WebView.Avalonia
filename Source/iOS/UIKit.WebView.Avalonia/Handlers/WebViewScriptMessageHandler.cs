namespace UIKit.WebView.Avalonia.Handlers;
internal sealed class WebViewScriptMessageHandler : NSObject, IWKScriptMessageHandler
{
    internal const string AppOrigin = $"app://0.0.0.0/";
    private Action<Uri, string> _messageReceivedAction;

    public WebViewScriptMessageHandler(Action<Uri, string> messageReceivedAction)
    {
        _messageReceivedAction = messageReceivedAction ?? throw new ArgumentNullException(nameof(messageReceivedAction));
    }

    public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }
        _messageReceivedAction(new Uri(AppOrigin), ((NSString)message.Body).ToString());
    }
}
