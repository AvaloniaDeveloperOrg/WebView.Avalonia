namespace Appkit.WebView.Anvalonia;

partial class WebView  
{
    public static readonly StyledProperty<Uri?> SourceProperty =
    AvaloniaProperty.Register<WebView, Uri?>(nameof(Source), defaultValue: null, defaultBindingMode: BindingMode.TwoWay, validate: uri =>
    {
        if (uri is not null)
            return uri.IsAbsoluteUri;

        return true;
    });

    [Category("Common")]
    public Uri? Source
    {
        get => GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }
}
