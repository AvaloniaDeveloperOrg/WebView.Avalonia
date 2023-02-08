using UIKit.WebView.Avalonia.Handlers;
using UIKit.WebView.Avalonia.Imps;

namespace UIKit.WKWebView.Avalonia;

public partial class WebView
{
    const string _initScript =
        """
            window.__receiveMessageCallbacks = [];
            window.__dispatchMessageCallback = function(message) {
            	window.__receiveMessageCallbacks.forEach(function(callback) { callback(message); });
            };
            window.external = {
            	sendMessage: function(message) {
            		window.webkit.messageHandlers.webwindowinterop.postMessage(message);
            	},
            	receiveMessage: function(callback) {
            		window.__receiveMessageCallbacks.push(callback);
            	}
            };
            
            (function () {
            	window.onpageshow = function(event) {
            		if (event.persisted) {
            			window.location.reload();
            		}
            	};
            })();  
        """;

    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        if (_webView is not null)
            _webView.Dispose();

        var config = WKWebViewConfiguration;
        if (config is null)
        {
            config = new WKWebViewConfiguration();


            config.Preferences.SetValueForKey(NSObject.FromObject(true), new NSString("developerExtrasEnabled"));

            config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(MessageReceived), "webwindowinterop");
            config.UserContentController.AddUserScript(new WKUserScript(new NSString(_initScript), WKUserScriptInjectionTime.AtDocumentEnd, true));

            // iOS WKWebView doesn't allow handling 'http'/'https' schemes, so we use the fake 'app' scheme
            config.SetUrlSchemeHandler(new SchemeHandler(this), urlScheme: "app");

            if (OperatingSystem.IsMacCatalystVersionAtLeast(10) || OperatingSystem.IsIOSVersionAtLeast(10))
            {
                config.AllowsPictureInPictureMediaPlayback = true;
                config.AllowsInlineMediaPlayback = true;
                config.MediaTypesRequiringUserActionForPlayback = WKAudiovisualMediaTypes.None;
            }
        }

        var webview = new IosWebView(CGRect.Empty, config)
        {
            BackgroundColor = UIColor.Clear,
            AutosizesSubviews = true
        };

        var handler = new PlatformHandleImp<IosWebView>(webview.Handle.Handle);
        HandleDescriptor = handler.HandleDescriptor;

        if (Source is not null)
            webview.LoadRequest(new NSUrlRequest(new NSUrl(Source.AbsoluteUri)));

        _webView = webview; 

        return handler;
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        base.DestroyNativeControlCore(control);
    }

    public override void BeginInit()
    {
        base.BeginInit();
        _implicitInitGate.BeginInit();
    }

    public override void EndInit()
    {
        _implicitInitGate.EndInit();
        base.EndInit();
    }

    private void MessageReceived(Uri uri, string message)
    {
        //_webviewManager?.MessageReceivedInternal(uri, message);
    }

}
