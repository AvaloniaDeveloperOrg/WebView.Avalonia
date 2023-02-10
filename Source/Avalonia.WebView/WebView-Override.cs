using Avalonia.WebView.Core;

namespace Avalonia.WebView;

partial class WebView
{
    protected override Size MeasureOverride(Size availableSize)
    {
        return LayoutHelper.MeasureChild(Child, availableSize, Padding, BorderThickness);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        return LayoutHelper.ArrangeChild(Child, finalSize, Padding, BorderThickness);
    }

    public override void Render(DrawingContext context)
    {
        var borderThickness = BorderThickness.Top;
        IPen? pen = null;
        if (BorderBrush != null && borderThickness > 0)
            pen = new ImmutablePen(BorderBrush.ToImmutable(), borderThickness, default, default, default);

        var rect = new Rect(Bounds.Size);
        if (!MathUtilities.IsZero(borderThickness))
            rect = rect.Deflate(borderThickness * 0.5);

        context.PlatformImpl.DrawRectangle(Background, pen, rect, default);
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        var platformView = _platformWebViewProvider.CreatePlatformView();
        RegisterWebViewEvent(platformView);
        _platformWebView = platformView;
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        Child = null;
        UnRegisterWebViewEvent(_platformWebView);
        _platformWebView?.Dispose();
    }

    bool RegisterWebViewEvent(IPlatformWebView? platformView)
    {
        if (platformView is null)
            return false;

        platformView.WebViewCreating += PlatformView_WebViewCreating;
        platformView.WebViewCreated += PlatformView_WebViewCreated;

        return true;
    }

    bool UnRegisterWebViewEvent(IPlatformWebView? platformView)
    {
        if (platformView is null)
            return false;

        platformView.WebViewCreating -= PlatformView_WebViewCreating;
        platformView.WebViewCreated -= PlatformView_WebViewCreated;
        return true;
    }

    private void PlatformView_WebViewCreating(object sender, string? e)
    {
         
    }

    private void PlatformView_WebViewCreated(object sender, string? e)
    {
        if (_platformWebView is null)
            return;

        Child = _platformWebView.AttachableControl;
    }
}
