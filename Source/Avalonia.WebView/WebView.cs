using Avalonia.WebView.Core;
using Dotnet.Toolkit.Extensions;

namespace Avalonia.WebView;

public partial class WebView : Control
{
    static WebView()
    {
        AffectsRender<WebView>(BackgroundProperty, BorderBrushProperty, BorderThicknessProperty);
        AffectsMeasure<WebView>(ChildProperty, PaddingProperty, BorderThicknessProperty);
        ChildProperty.Changed.AddClassHandler<WebView>((x, e) => x.ChildChanged(e));
    }

    public WebView(IServiceProvider? serviceProvider = default)
    {
        if (serviceProvider is not null)
            _platformWebViewProvider = serviceProvider.GetRequiredService<IPlatformWebViewProvider>();
        else
            _platformWebViewProvider = AvaloniaLocator.Current.GetRequiredService<IPlatformWebViewProvider>();
    }

    readonly IPlatformWebViewProvider _platformWebViewProvider;
    IPlatformWebView? _platformWebView;

    


    private void ChildChanged(AvaloniaPropertyChangedEventArgs e)
    {
        var oldChild = (Control?)e.OldValue;
        var newChild = (Control?)e.NewValue;

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
    }

}
