using Avalonia.WebView.Core.Configurations;

namespace Avalonia.WebView.Core;

public abstract class ViewHandler<TInterface, TPlatformView> : NativeControlHost, IPlatformWebView<TPlatformView> where TPlatformView : IDisposable
{
    protected bool _isInitialization = false;
    protected bool _isDisposed = false;
    protected TPlatformView? _platformView;

    public Control AttachableControl => throw new NotImplementedException();

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

    public virtual bool Initialize()
    {
        if (_isInitialization)
            return true;

        _isInitialization = true;
        return true;
    }

    public abstract bool Navigate(Uri uri);

    public abstract bool NavigateToString(string htmlContent);

    public abstract bool PostWebMessageAsJson(string webMessageAsJson);

    public abstract bool PostWebMessageAsString(string webMessageAsString);

    public abstract Task<string> ExecuteScriptAsync(string javaScript);

    public abstract bool GoBack();

    public abstract bool GoForward();

    public abstract bool Reload();

    public abstract bool Resume();

    public abstract bool Stop();

    public abstract bool OpenDevToolsWindow();

    void INativeControlHostDestroyableControlHandle.Destroy() => ((IDisposable)this).Dispose();

    void IDisposable.Dispose()
    {
        if (_isDisposed)
            return;

        Disposing();
        _platformView?.Dispose();
        _isDisposed = true;
    }

    public abstract void Disposing();

}
