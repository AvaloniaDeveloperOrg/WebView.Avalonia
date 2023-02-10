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

    public static readonly StyledProperty<Uri?> UrlProperty =
           AvaloniaProperty.Register<WebView, Uri?>(nameof(Url));


    [Content]
    protected Control? Child
    {
        get => GetValue(ChildProperty);
        set => SetValue(ChildProperty, value);
    }

    public Thickness Padding
    {
        get =>  GetValue(PaddingProperty); 
        set => SetValue(PaddingProperty, value); 
    }

    public IBrush? Background
    {
        get => GetValue(BackgroundProperty); 
        set => SetValue(BackgroundProperty, value); 
    }

    public IBrush? BorderBrush
    {
        get => GetValue(BorderBrushProperty); 
        set => SetValue(BorderBrushProperty, value); 
    }

    public Thickness BorderThickness
    {
        get => GetValue(BorderThicknessProperty); 
        set => SetValue(BorderThicknessProperty, value); 
    }

    public Uri? Url
    {
        get => GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }

    bool LoadDependencyObjectsChanged()
    {
        ChildProperty.Changed.AddClassHandler<WebView, Control?>((x, e) => 
        {
            var oldChild = e.OldValue.Value;
            var newChild = e.NewValue.Value;

            if (oldChild != null)
            {
                ((ISetLogicalParent)oldChild).SetParent(null);
                LogicalChildren.Clear();
                VisualChildren.Remove(oldChild);
            }

            if (newChild != null)
            {
                ((ISetLogicalParent)newChild).SetParent(this);
                VisualChildren.Add(newChild);
                LogicalChildren.Add(newChild);
            }
        });

        UrlProperty.Changed.AddClassHandler<WebView, Uri?>((s, e) =>
        {

        });


        return true;
    }
}
