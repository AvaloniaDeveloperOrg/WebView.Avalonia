namespace UIKit.WebView.Avalonia.Handlers;

internal class SchemeHandler : NSObject, IWKUrlSchemeHandler
{
    private readonly object _webViewHandler;

    public SchemeHandler(object webViewHandler)
    {
        _webViewHandler = webViewHandler;
    }

    [Export("webView:startURLSchemeTask:")]
    [SupportedOSPlatform("ios11.0")]
    public void StartUrlSchemeTask(IosWebView webView, IWKUrlSchemeTask urlSchemeTask)
    {
        var responseBytes = GetResponseBytes(urlSchemeTask.Request.Url?.AbsoluteString ?? "", out var contentType, statusCode: out var statusCode);
        if (statusCode == 200)
        {
            using (var dic = new NSMutableDictionary<NSString, NSString>())
            {
                dic.Add((NSString)"Content-Length", (NSString)(responseBytes.Length.ToString(CultureInfo.InvariantCulture)));
                dic.Add((NSString)"Content-Type", (NSString)contentType);
                // Disable local caching. This will prevent user scripts from executing correctly.
                dic.Add((NSString)"Cache-Control", (NSString)"no-cache, max-age=0, must-revalidate, no-store");
                if (urlSchemeTask.Request.Url != null)
                {
                    using var response = new NSHttpUrlResponse(urlSchemeTask.Request.Url, statusCode, "HTTP/1.1", dic);
                    urlSchemeTask.DidReceiveResponse(response);
                }

            }
            urlSchemeTask.DidReceiveData(NSData.FromArray(responseBytes));
            urlSchemeTask.DidFinish();
        }
    }

    private byte[] GetResponseBytes(string? url, out string contentType, out int statusCode)
    {
        //var allowFallbackOnHostPage = AppOriginUri.IsBaseOfPage(url);
        //url = QueryStringHelper.RemovePossibleQueryString(url);

        //if (_webViewHandler._webviewManager!.TryGetResponseContentInternal(url, allowFallbackOnHostPage, out statusCode, out var statusMessage, out var content, out var headers))
        //{
        //    statusCode = 200;
        //    //using var ms = new MemoryStream();

        //    //return ms.ToArray();
        //    return Array.Empty<byte>();
        //}
        //else
        {
 
            statusCode = 404;
            contentType = string.Empty;
            return Array.Empty<byte>();
        }
    }

    [Export("webView:stopURLSchemeTask:")]
    public void StopUrlSchemeTask(IosWebView webView, IWKUrlSchemeTask urlSchemeTask)
    {
    }
}