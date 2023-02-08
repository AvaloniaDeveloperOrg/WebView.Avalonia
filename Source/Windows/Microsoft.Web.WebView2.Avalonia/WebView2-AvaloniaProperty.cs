namespace Microsoft.Web.WebView2.Avalonia;

partial class WebView2
{
    public static readonly StyledProperty<CoreWebView2CreationProperties> CreationPropertiesProperty =
       AvaloniaProperty.Register<WebView2, CoreWebView2CreationProperties>(nameof(CreationProperties), defaultValue: null, defaultBindingMode: BindingMode.TwoWay, coerce: (s, o) =>
       {
           if (s is not WebView2 view)
               return null;

           if (view.Environment is not null)
               return null;

           return o;
       });

    public static readonly StyledProperty<Uri> SourceProperty =
           AvaloniaProperty.Register<WebView2, Uri>(nameof(Source), defaultValue: null, defaultBindingMode: BindingMode.TwoWay, validate: uri =>
           {
               if (uri is not null)
                   return uri.IsAbsoluteUri;

               return true;
           });

    public static readonly StyledProperty<bool> CanGoBackProperty =
           AvaloniaProperty.Register<WebView2, bool>(nameof(CanGoBack), defaultValue: false);

    public static readonly StyledProperty<bool> CanGoForwardProperty =
           AvaloniaProperty.Register<WebView2, bool>(nameof(CanGoForward), defaultValue: false);

    public static readonly StyledProperty<double> ZoomFactorProperty =
           AvaloniaProperty.Register<WebView2, double>(nameof(ZoomFactor), defaultValue: 1d, defaultBindingMode: BindingMode.TwoWay);

    public static readonly StyledProperty<bool> AllowExternalDropProperty =
           AvaloniaProperty.Register<WebView2, bool>(nameof(AllowExternalDrop), defaultValue: true, defaultBindingMode: BindingMode.TwoWay);

    public static readonly StyledProperty<Color> DefaultBackgroundColorProperty =
           AvaloniaProperty.Register<WebView2, Color>(nameof(DefaultBackgroundColor), defaultValue: Colors.White, defaultBindingMode: BindingMode.TwoWay);

    public static readonly StyledProperty<Color> DesignModeForegroundColorProperty =
           AvaloniaProperty.Register<WebView2, Color>(nameof(DesignModeForegroundColor), defaultValue: Colors.Black, defaultBindingMode: BindingMode.TwoWay);


    public static readonly RoutedEvent<KeyEventArgs> WebViewKeyPressedEvent =
           RoutedEvent.Register<WebView2, KeyEventArgs>(nameof(WebViewKeyPressed), RoutingStrategies.Direct);


    [Category("Common")]
    public CoreWebView2CreationProperties CreationProperties
    {
        get => GetValue(CreationPropertiesProperty);
        set => SetValue(CreationPropertiesProperty, value);
    }

    [Category("Common")]
    public Uri Source
    {
        get => GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    [Browsable(false)]
    public bool CanGoBack => GetValue(CanGoBackProperty);

    [Browsable(false)]
    public bool CanGoForward => (bool)GetValue(CanGoForwardProperty);

    [Category("Common")]
    public double ZoomFactor
    {
        get => GetValue(ZoomFactorProperty);
        set => SetValue(ZoomFactorProperty, value);
    }

    [Category("Common")]
    public bool AllowExternalDrop
    {
        get => GetValue(AllowExternalDropProperty);
        set => SetValue(AllowExternalDropProperty, value);
    }

    [Category("Common")]
    public Color DefaultBackgroundColor
    {
        get => GetValue(DefaultBackgroundColorProperty);
        set => SetValue(DefaultBackgroundColorProperty, value);
    }

    [Category("Common")]
    public Color DesignModeForegroundColor
    {
        get => GetValue(DesignModeForegroundColorProperty);
        set => SetValue(DesignModeForegroundColorProperty, value);
    }

    public event EventHandler<KeyEventArgs>? WebViewKeyPressed
    {
        add => AddHandler(WebViewKeyPressedEvent, value);
        remove => RemoveHandler(WebViewKeyPressedEvent, value);
    }

}
