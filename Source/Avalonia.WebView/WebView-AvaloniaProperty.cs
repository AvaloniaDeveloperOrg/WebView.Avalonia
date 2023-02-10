namespace Avalonia.WebView;

partial class WebView
{
    protected static readonly StyledProperty<Control?> ChildProperty =
              AvaloniaProperty.Register<WebView, Control?>(nameof(Child));

    public static readonly StyledProperty<Thickness> PaddingProperty =
           AvaloniaProperty.Register<WebView, Thickness>(nameof(Padding));

    public static readonly StyledProperty<IBrush?> BackgroundProperty =
           AvaloniaProperty.Register<Border, IBrush?>(nameof(Background));

    public static readonly StyledProperty<IBrush?> BorderBrushProperty =
           AvaloniaProperty.Register<Border, IBrush?>(nameof(BorderBrush));

    public static readonly StyledProperty<Thickness> BorderThicknessProperty =
           AvaloniaProperty.Register<WebView, Thickness>(nameof(BorderThickness));

    [Content]
    protected Control? Child
    {
        get { return GetValue(ChildProperty); }
        set { SetValue(ChildProperty, value); }
    }

    public Thickness Padding
    {
        get { return GetValue(PaddingProperty); }
        set { SetValue(PaddingProperty, value); }
    }

    public IBrush? Background
    {
        get { return GetValue(BackgroundProperty); }
        set { SetValue(BackgroundProperty, value); }
    }

    public IBrush? BorderBrush
    {
        get { return GetValue(BorderBrushProperty); }
        set { SetValue(BorderBrushProperty, value); }
    }

    public Thickness BorderThickness
    {
        get { return GetValue(BorderThicknessProperty); }
        set { SetValue(BorderThicknessProperty, value); }
    }

}
