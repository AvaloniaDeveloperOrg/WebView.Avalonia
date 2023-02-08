using Avalonia.Controls.Platform;
using Microsoft.Web.WebView2.Avalonia.Extensions;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Avalonia;

[ToolboxItem(true)]
public partial class WebView : NativeControlHost, INativeControlHostDestroyableControlHandle, IDisposable
{
    public WebView()
    {
        Loaded += _implicitInitGate.OnSynchronizationContextExists;
        SizeChanged += WebView2_SizeChanged;
        LoadedPropertyChanged();
    }

    private IntPtr _hwnd;
    readonly private TaskCompletionSource<IntPtr> _hwndTaskSource = new();
    readonly private ImplicitInitGate _implicitInitGate = new();

    private Task _initTask;
    private bool _browserHitTransparent;
    private bool _isExplicitEnvironment;
    private bool _isExplicitControllerOptions;
    private bool _disposed;
    private bool _browserCrashed;

    private AvaloniaProperty _propertyChangingFromCore;

    private CoreWebView2Environment Environment { get; set; }
    private CoreWebView2Controller CoreWebView2Controller { get; set; }
    private CoreWebView2ControllerOptions ControllerOptions { get; set; }


    [Browsable(false)]
    public CoreWebView2 CoreWebView2
    {
        get
        {
            VerifyAccess();
            VerifyNotDisposed();
            VerifyBrowserNotCrashed();
            return CoreWebView2Controller?.CoreWebView2;
        }
    }

    public IntPtr Handle => _hwnd;

    public string? HandleDescriptor { get; protected set; }

    //[Browsable(false)]
    //[EditorBrowsable(EditorBrowsableState.Never)]
    //public new double Opacity => base.Opacity;

    //[Browsable(false)]
    //[EditorBrowsable(EditorBrowsableState.Never)]
    //public new IBrush OpacityMask => base.OpacityMask;

    private bool LoadedPropertyChanged()
    {
        IsVisibleProperty.Changed.AddClassHandler<WebView, bool>((s, e) =>
        {
            if (s.CoreWebView2Controller is null)
                return;

            try
            {
                s.CoreWebView2Controller.IsVisible = e.NewValue.Value;
            }
            catch (Exception)
            {
            }
        });

        SourceProperty.Changed.AddClassHandler<WebView, Uri>((s, e) =>
        {
            if (s.IsPropertyChangingFromCore(SourceProperty))
                return;

            Uri uri = e.OldValue.Value;
            Uri uri2 = e.NewValue.Value;

            if (uri2 == null)
                throw new NotImplementedException("The Source property cannot be set to null.");

            if (s.CoreWebView2 != null && (uri == null || uri.AbsoluteUri != uri2.AbsoluteUri))
                s.CoreWebView2.Navigate(uri2.AbsoluteUri);

            s._implicitInitGate.RunWhenOpen(() => s.EnsureCoreWebView2Async());
        });

        ZoomFactorProperty.Changed.AddClassHandler<WebView, double>((s, e) =>
        {
            if (s.CoreWebView2Controller is null)
                return;

            s.CoreWebView2Controller.ZoomFactor = e.NewValue.Value;
        });

        AllowExternalDropProperty.Changed.AddClassHandler<WebView, bool>((s, e) =>
        {
            if (s.CoreWebView2Controller is null)
                return;

            try
            {
                s.CoreWebView2Controller.AllowExternalDrop = e.NewValue.Value;
            }
            catch (Exception)
            {
            }
        });

        DefaultBackgroundColorProperty.Changed.AddClassHandler<WebView, Color>((s, e) =>
        { 
            if (s.CoreWebView2Controller is null)
                return;

            s.CoreWebView2Controller.DefaultBackgroundColor = System.Drawing.Color.FromArgb(e.NewValue.Value.A, e.NewValue.Value.R, e.NewValue.Value.G, e.NewValue.Value.B);
        });

        return true;
    }

    private bool TiggerSizeChanged()
    {
        SizeChangedEventArgs e = new SizeChangedEventArgs(SizeChangedEvent, this, new Size(Bounds.Width, Bounds.Height), new Size(Bounds.Width, Bounds.Height));
        RaiseEvent(e);
        return true;
    }

    private void VerifyNotDisposed()
    {
        if (_disposed)
            throw new ObjectDisposedException(base.Name);
    }

    private void VerifyBrowserNotCrashed()
    {
        if (_browserCrashed)
            throw new InvalidOperationException("The WebView control is no longer valid because the browser process crashed.To work around this, please listen for the CoreWebView2.ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
    }

    private void VerifyCoreWebView2()
    {
        if (CoreWebView2 == null)
            throw new InvalidOperationException("Attempted to use WebView2 functionality which requires its CoreWebView2 prior to the CoreWebView2 being initialized.  Call EnsureCoreWebView2Async or set the Source property first.");
    }

    private bool IsPropertyChangingFromCore(AvaloniaProperty property)
    {
        if (property == null)
            throw new ArgumentNullException("property");

        return property == _propertyChangingFromCore;
    }

    public Task EnsureCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
    {
        VerifyAccess();
        VerifyNotDisposed();
        VerifyBrowserNotCrashed();

        if (SynchronizationContext.Current == null)
            throw new InvalidOperationException("EnsureCoreWebView2Async cannot be used before the application's event loop has started running.");

        if (_initTask == null || _initTask.IsFaulted)
            _initTask = Init();
        else
        {
            if ((!_isExplicitEnvironment && environment != null) || (_isExplicitEnvironment && environment != null && Environment != environment))
                throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2Environment. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");

            if ((!_isExplicitControllerOptions && controllerOptions != null) || (_isExplicitControllerOptions && controllerOptions != null && ControllerOptions != controllerOptions))
                throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2ControllerOptions. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
        }

        return _initTask;

        async Task Init()
        {
            _ = 5;
            try
            {
                if (environment != null)
                {
                    Environment = environment;
                    _isExplicitEnvironment = true;
                }
                else if (CreationProperties != null)
                {
                    CoreWebView2Environment environment2 = await CreationProperties.CreateEnvironmentAsync();
                    Environment = environment2;
                }

                if (Environment == null)
                {
                    CoreWebView2Environment environment2 = await CoreWebView2Environment.CreateAsync();
                    Environment = environment2;
                }

                if (controllerOptions != null)
                {
                    ControllerOptions = controllerOptions;
                    _isExplicitControllerOptions = true;
                }
                else if (CreationProperties != null)
                    ControllerOptions = CreationProperties.CreateCoreWebView2ControllerOptions(Environment);

                if (DefaultBackgroundColor != DefaultBackgroundColorProperty.GetDefaultValue(typeof(WebView)))
                    System.Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", System.Drawing.Color.FromArgb(DefaultBackgroundColor.A, DefaultBackgroundColor.R, DefaultBackgroundColor.G, DefaultBackgroundColor.B).Name);

                if (ControllerOptions != null)
                {
                    CoreWebView2Environment environment3 = Environment;
                    CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(await _hwndTaskSource.Task, ControllerOptions);
                    CoreWebView2Controller = coreWebView2Controller;
                }
                else
                {
                    CoreWebView2Environment environment3 = Environment;
                    CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(await _hwndTaskSource.Task);
                    CoreWebView2Controller = coreWebView2Controller;
                }

                //set webview size
                CoreWebView2Controller.Bounds = new System.Drawing.Rectangle(0, 0, Convert.ToInt32(Bounds.Width), Convert.ToInt32(Bounds.Height));

                try
                {
                    _browserHitTransparent = CoreWebView2Controller.IsBrowserHitTransparent;
                }
                catch (NotImplementedException)
                {
                }

                if (!_browserHitTransparent)
                    CoreWebView2Controller.AcceleratorKeyPressed += CoreWebView2Controller_AcceleratorKeyPressed;

                CoreWebView2Controller.GotFocus += CoreWebView2Controller_GotFocus;
                CoreWebView2Controller.LostFocus += CoreWebView2Controller_LostFocus;
                CoreWebView2Controller.MoveFocusRequested += CoreWebView2Controller_MoveFocusRequested;
                CoreWebView2Controller.ZoomFactorChanged += CoreWebView2Controller_ZoomFactorChanged;
                CoreWebView2.ContentLoading += CoreWebView2_ContentLoading;
                CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
                CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
                CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
                CoreWebView2.ProcessFailed += CoreWebView2_ProcessFailed;
                CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
                CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;

                if (CoreWebView2Controller.ParentWindow != _hwnd)
                    ReparentController(_hwnd, sync: false);

                if (CoreWebView2Controller.ParentWindow != IntPtr.Zero)
                    SyncControllerWithParentWindow();

                bool flag = Source != null;
                if (Source == null)
                    SetCurrentValueFromCore(SourceProperty, new Uri(CoreWebView2.Source));

                if (ZoomFactor != (double)ZoomFactorProperty.GetDefaultValue(typeof(WebView)))
                    CoreWebView2Controller.ZoomFactor = ZoomFactor;

                if (DefaultBackgroundColor != DefaultBackgroundColorProperty.GetDefaultValue(typeof(WebView)))
                    CoreWebView2Controller.DefaultBackgroundColor = System.Drawing.Color.FromArgb(DefaultBackgroundColor.A, DefaultBackgroundColor.R, DefaultBackgroundColor.G, DefaultBackgroundColor.B);

                if (AllowExternalDrop != AllowExternalDropProperty.GetDefaultValue(typeof(WebView)))
                {
                    try
                    {
                        CoreWebView2Controller.AllowExternalDrop = AllowExternalDrop;
                    }
                    catch (NotImplementedException)
                    {
                    }
                }

                CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs());
                if (flag)
                    CoreWebView2.Navigate(Source.AbsoluteUri);

                //TiggerSizeChanged();
            }
            catch (Exception ex2)
            {
                CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs(ex2));
                throw;
            }
        }
    }

    public Task EnsureCoreWebView2Async(CoreWebView2Environment environment) => EnsureCoreWebView2Async(environment, null);

    public async Task<string> ExecuteScriptAsync(string javaScript)
    {
        VerifyCoreWebView2();
        return await CoreWebView2.ExecuteScriptAsync(javaScript);
    }

    public void GoBack() => CoreWebView2?.GoBack();

    public void GoForward() => CoreWebView2?.GoForward();

    public void Reload()
    {
        VerifyCoreWebView2();
        CoreWebView2.Reload();
    }

    public void Stop()
    {
        VerifyCoreWebView2();
        CoreWebView2.Stop();
    }

    public void NavigateToString(string htmlContent)
    {
        VerifyCoreWebView2();
        CoreWebView2.NavigateToString(htmlContent);
    }

    private void ReparentController(IntPtr hwnd, bool sync = true)
    {
        if (hwnd == IntPtr.Zero)
        {
            CoreWebView2Controller.IsVisible = false;
            CoreWebView2Controller.ParentWindow = IntPtr.Zero;
            return;
        }

        CoreWebView2Controller.ParentWindow = hwnd;

        if (sync)
            SyncControllerWithParentWindow();
    }

    private void SyncControllerWithParentWindow()
    {
        TryUpdateNativeControlPosition();

        var keyboard = KeyboardDevice.Instance;
        if (keyboard?.FocusedElement == this)
            CoreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);

        CoreWebView2Controller.IsVisible = base.IsVisible;
    }

    private void SetCurrentValueFromCore(AvaloniaProperty property, object value)
    {
        Trace.Assert(_propertyChangingFromCore == null);
        _propertyChangingFromCore = property;
        SetValue(property, value);
        _propertyChangingFromCore = null;
    }

    private void Uninitialize(bool browserCrashed = false)
    {
        _browserCrashed = browserCrashed;
        if (CoreWebView2Controller != null)
        {
            CoreWebView2Controller coreWebView2Controller = CoreWebView2Controller;
            CoreWebView2Controller = null;
            if (!_browserCrashed)
            {
                coreWebView2Controller.CoreWebView2.ContentLoading -= CoreWebView2_ContentLoading;
                coreWebView2Controller.CoreWebView2.HistoryChanged -= CoreWebView2_HistoryChanged;
                coreWebView2Controller.CoreWebView2.NavigationCompleted -= CoreWebView2_NavigationCompleted;
                coreWebView2Controller.CoreWebView2.NavigationStarting -= CoreWebView2_NavigationStarting;
                coreWebView2Controller.CoreWebView2.ProcessFailed -= CoreWebView2_ProcessFailed;
                coreWebView2Controller.CoreWebView2.SourceChanged -= CoreWebView2_SourceChanged;
                coreWebView2Controller.CoreWebView2.WebMessageReceived -= CoreWebView2_WebMessageReceived;
                if (!_browserHitTransparent)
                    coreWebView2Controller.AcceleratorKeyPressed -= CoreWebView2Controller_AcceleratorKeyPressed;
                coreWebView2Controller.GotFocus -= CoreWebView2Controller_GotFocus;
                coreWebView2Controller.LostFocus -= CoreWebView2Controller_LostFocus;
                coreWebView2Controller.MoveFocusRequested -= CoreWebView2Controller_MoveFocusRequested;
                coreWebView2Controller.ZoomFactorChanged -= CoreWebView2Controller_ZoomFactorChanged;
                coreWebView2Controller.Close();
            }
            coreWebView2Controller = null;
        }
        Environment = null;
    }


    public void Destroy() => Dispose();

    public void Dispose()
    {
        if (!_disposed)
        {
            Uninitialize();
            _hwnd = IntPtr.Zero;
            _disposed = true;
        }
    }

    private void WebView2_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (CoreWebView2Controller is null)
            return;

        CoreWebView2Controller.Bounds = new System.Drawing.Rectangle(0, 0, Convert.ToInt32(e.NewSize.Width), Convert.ToInt32(e.NewSize.Height));
        CoreWebView2Controller.NotifyParentWindowPositionChanged();
    }

    private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e) => WebMessageReceived?.Invoke(this, e);

    private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
    {
        SetCurrentValueFromCore(SourceProperty, new Uri(CoreWebView2.Source));
        SourceChanged?.Invoke(this, e);
    }

    private void CoreWebView2_ProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs e)
    {
        if (e.ProcessFailedKind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
            Uninitialize(browserCrashed: true);
    }
    
    private void CoreWebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e) => NavigationStarting?.Invoke(this, e);

    private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e) => NavigationCompleted?.Invoke(this, e);

    private void CoreWebView2_HistoryChanged(object sender, object e)
    {
        SetValue(CanGoBackProperty, CoreWebView2.CanGoBack);
        SetValue(CanGoForwardProperty, CoreWebView2.CanGoForward);
    }

    private void CoreWebView2_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e) => ContentLoading?.Invoke(this, e);

    private void CoreWebView2Controller_ZoomFactorChanged(object sender, object e)
    {
        SetCurrentValueFromCore(ZoomFactorProperty, CoreWebView2Controller.ZoomFactor);
        ZoomFactorChanged?.Invoke(this, EventArgs.Empty);
    }

    private void CoreWebView2Controller_MoveFocusRequested(object sender, CoreWebView2MoveFocusRequestedEventArgs e)
    {
        switch (e.Reason)
        {
            case CoreWebView2MoveFocusReason.Programmatic:
            case CoreWebView2MoveFocusReason.Next:
                //MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                break;
            case CoreWebView2MoveFocusReason.Previous:
                //MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
                break;
        }
        e.Handled = true;
    }

    private void CoreWebView2Controller_LostFocus(object sender, object e)
    {

    }

    private void CoreWebView2Controller_GotFocus(object sender, object e)
    {

    }

    private void CoreWebView2Controller_AcceleratorKeyPressed(object sender, CoreWebView2AcceleratorKeyPressedEventArgs e)
    {
        var keyEventArgs = new KeyEventArgs
        {
            Device = KeyboardDevice.Instance,
            Key = KeyExtensions.KeyFromVirtualKey((int)e.VirtualKey),
            Source = this,
            KeyModifiers = KeyModifiers.None,
            RoutedEvent = WebViewKeyPressedEvent
        };

        RaiseEvent(keyEventArgs);
        e.Handled = keyEventArgs.Handled;
    }

}
