using Avalonia.WebView.Core.Configrations;

namespace Avalonia.WebView.Core;

public interface IPlatformWebView : INativeControlHostDestroyableControlHandle, IDisposable
{
    object? PlatformViewContext { get; }
    WebViewCreationProperties Configration { get; }
    bool IsCanBack { get; }
    bool IsCanForward { get; }
    bool Init();
    bool Navigate(Uri uri);
    bool NavigateToString(string htmlContent);
    bool GoBack();
    bool GoForward();
    bool Stop();
    bool Resume();
    bool Reload();

    bool PostWebMessageAsJson(string webMessageAsJson);
    bool PostWebMessageAsString(string webMessageAsString);

    Task<string> ExecuteScriptAsync(string javaScript);

    bool OpenDevToolsWindow();

    event EventHandler<string?>? NavigationStarting;
    event EventHandler<string?>? NavigationCompleted;
    event EventHandler<string?>? NewWindowRequested;
    event EventHandler<string?>? WebMessageReceived;
}
