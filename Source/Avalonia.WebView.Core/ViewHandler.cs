using Avalonia.WebView.Core.Configurations;

namespace Avalonia.WebView.Core;

public abstract class ViewHandler<TInterface, TPlatformView> : NativeControlHost, IPlatformWebView<TPlatformView> where TPlatformView : IDisposable
{
    protected bool _isDisposed = false;
    protected TPlatformView? _platformView;

    public IntPtr Handle { get; protected set; }

    public string? HandleDescriptor => typeof(TPlatformView).Name;

    public TPlatformView? PlatformView => _platformView;

    public object? PlatformViewContext => PlatformView;

    public WebViewCreationProperties Settings { get; protected set; } = default!;

    public bool IsCanBack { get; protected set; }

    public bool IsCanForward { get; protected set; }

    public event EventHandler<string?>? IsCanGoBackChanged;
    public event EventHandler<string?>? IsCanGoForwardChanged;
    public event EventHandler<string?>? WebViewCreating;
    public event EventHandler<string?>? WebViewCreated;
    public event EventHandler<string?>? ContentLoading;
    public event EventHandler<string?>? ContentLoaded;
    public event EventHandler<string?>? NavigationStarting;
    public event EventHandler<string?>? NavigationCompleted;
    public event EventHandler<string?>? NewWindowRequested;
    public event EventHandler<string?>? WebMessageReceived;

    public abstract Task<string> ExecuteScriptAsync(string javaScript);

    public abstract bool GoBack();

    public abstract bool GoForward();

    public abstract bool Init();

    public abstract bool Navigate(Uri uri);

    public abstract bool NavigateToString(string htmlContent);

    public abstract bool OpenDevToolsWindow();

    public abstract bool PostWebMessageAsJson(string webMessageAsJson);

    public abstract bool PostWebMessageAsString(string webMessageAsString);

    public abstract bool Reload();

    public abstract bool Resume();

    public abstract bool Stop();

    public virtual void Destroy() => Dispose();

    public virtual void Dispose()
    {
        if (_isDisposed)
            return;

        _platformView?.Dispose();
        _isDisposed = true;
    }
}
