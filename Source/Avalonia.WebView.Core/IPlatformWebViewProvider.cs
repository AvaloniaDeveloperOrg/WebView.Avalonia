using Avalonia.WebView.Core.Configurations;

namespace Avalonia.WebView.Core;

public interface IPlatformWebViewProvider : IDisposable
{
    IPlatformWebView CreatePlatformView(Action<WebViewCreationProperties>? configDelegate = default); 
}
