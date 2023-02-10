using Avalonia.WebView.Core;
using Dotnet.Toolkit.Extensions;

namespace Avalonia.WebView;

public partial class WebView : Control
{
    static WebView()
    {
        AffectsRender<WebView>(BackgroundProperty, BorderBrushProperty, BorderThicknessProperty);
        AffectsMeasure<WebView>(ChildProperty, PaddingProperty, BorderThicknessProperty);
    }

    public WebView(IServiceProvider? serviceProvider = default)
    {
        if (serviceProvider is not null)
            _platformWebViewProvider = serviceProvider.GetRequiredService<IPlatformWebViewProvider>();
        else
            _platformWebViewProvider = AvaloniaLocator.Current.GetRequiredService<IPlatformWebViewProvider>();

        LoadDependencyObjectsChanged();
    }

    readonly IPlatformWebViewProvider _platformWebViewProvider;
    IPlatformWebView? _platformWebView;
}
