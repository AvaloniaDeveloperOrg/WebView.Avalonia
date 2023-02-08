using Avalonia.WebView.Core.Configrations;

namespace Avalonia.WebView.Core;

public interface IPlatformWebViewProvider : IDisposable
{
    IPlatformWebView CreatePlatformView(IPlatformHandle parentHandle, Action<WebViewCreationProperties>? configDelegate = default);
    IPlatformWebView CreatePlatformView(IPlatformHandle parentHandle, IPlatformHandle previewHandle, Action<WebViewCreationProperties>? configDelegate = default);
    IPlatformWebView CreatePlatformView(IPlatformHandle parentHandle, Func<IPlatformHandle> defaultHanle, Action<WebViewCreationProperties>? configDelegate = default);
}
