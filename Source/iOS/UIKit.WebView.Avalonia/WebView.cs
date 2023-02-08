using Microsoft.Web.WebView2.Avalonia;

namespace UIKit.WKWebView.Avalonia;

public partial class WebView : NativeControlHost, INativeControlHostDestroyableControlHandle, IDisposable
{
    public WebView()
    {
        Loaded += _implicitInitGate.OnSynchronizationContextExists;
        SizeChanged += WebView_SizeChanged;
        LoadedPropertyChanged();
    }

    readonly private ImplicitInitGate _implicitInitGate = new();

    private IosWebView? _webView;

    public IntPtr Handle => _webView?.Handle.Handle ?? IntPtr.Zero;

    public string? HandleDescriptor { get; protected set; } 

    private bool LoadedPropertyChanged()
    {
        IsVisibleProperty.Changed.AddClassHandler<WebView, bool>((s, e) =>
        {
            if (s._webView is null)
                return;

            s._webView.Hidden = e.NewValue.Value;
        });

        SourceProperty.Changed.AddClassHandler<WebView, Uri?>((s, e) =>
        {
            if (s._webView is null)
                return;

            if (e.NewValue.Value is null) 
                return;

            s._webView.LoadRequest(new NSUrlRequest(new NSUrl(e.NewValue.Value.AbsoluteUri)));

            //if (e.NewValue.Value.IsFile)
            //    s._webView.LoadFileRequest(new NSUrlRequest(new NSUrl(e.NewValue.Value.LocalPath)), new NSUrl(urlString: e.NewValue.Value.LocalPath));
            //else
            //    s._webView.LoadRequest(new NSUrlRequest(new NSUrl(e.NewValue.Value.AbsoluteUri)));
        });
        return true;
    }

    private void WebView_SizeChanged(object? sender, SizeChangedEventArgs e)
    {
        if (_webView is not null) 
            _webView.Bounds = new CGRect(0, 0, e.NewSize.Width, e.NewSize.Height);
    }


    public void Destroy()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }


}
