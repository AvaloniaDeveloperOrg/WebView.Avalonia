using Avalonia.WebView.Core.Configurations;

namespace Avalonia.WebView.Core;

public interface IPlatformWebView :  INativeControlHostDestroyableControlHandle, IDisposable
{
    Control AttachableControl { get; }
    object? PlatformViewContext { get; }
    WebViewCreationProperties Settings { get; }
    bool IsCanBack { get; }
    bool IsCanForward { get; }
    bool Initialize();
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

    event EventHandler<string?>? IsCanGoBackChanged;
    event EventHandler<string?>? IsCanGoForwardChanged;
    event EventHandler<string?>? WebViewCreating;
    event EventHandler<string?>? WebViewCreated;
    event EventHandler<string?>? ContentLoading;
    event EventHandler<string?>? ContentLoaded;
    event EventHandler<string?>? NavigationStarting;
    event EventHandler<string?>? NavigationCompleted;
    event EventHandler<string?>? NewWindowRequested;
    event EventHandler<string?>? WebMessageReceived;
}
