namespace Microsoft.Web.WebView2.Avalonia;

partial class WebView2
{
    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
    }

    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        var handler = base.CreateNativeControlCore(parent);
        if (CoreWebView2Controller != null)
            ReparentController(handler.Handle);

        if (!_hwndTaskSource.Task.IsCompleted)
            _hwndTaskSource.SetResult(handler.Handle);

        _hwnd = handler.Handle;
        return handler;
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        if (CoreWebView2Controller != null)
            ReparentController(IntPtr.Zero);

        base.DestroyNativeControlCore(control);
    }

    public override void BeginInit()
    {
        base.BeginInit();
        _implicitInitGate.BeginInit();
    }

    public override void EndInit()
    {
        _implicitInitGate.EndInit();
        base.EndInit();
    }


    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        base.OnKeyUp(e);
    }


}
