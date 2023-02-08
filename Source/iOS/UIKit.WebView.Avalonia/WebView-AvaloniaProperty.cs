namespace UIKit.WKWebView.Avalonia;

partial class WebView
{
    public static readonly StyledProperty<WKWebViewConfiguration?> WKWebViewConfigurationProperty =
           AvaloniaProperty.Register<WebView, WKWebViewConfiguration?>(nameof(WKWebViewConfiguration), defaultValue: default);

    public static readonly StyledProperty<Uri?> SourceProperty =
           AvaloniaProperty.Register<WebView, Uri?>(nameof(Source), defaultValue: null, defaultBindingMode: BindingMode.TwoWay, validate: uri =>
           {
               if (uri is not null)
                   return uri.IsAbsoluteUri;

               return true;
           });

    [Category("Common")]
    public WKWebViewConfiguration? WKWebViewConfiguration
    {
        get => GetValue(WKWebViewConfigurationProperty);
        set => SetValue(WKWebViewConfigurationProperty, value);
    }

    [Category("Common")]
    public Uri? Source
    {
        get => GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }
}
