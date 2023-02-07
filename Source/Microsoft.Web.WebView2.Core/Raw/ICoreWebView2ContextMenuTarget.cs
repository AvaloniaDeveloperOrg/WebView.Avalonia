namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("B8611D99-EED6-4F3F-902C-A198502AD472")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ContextMenuTarget
{
    [DispId(1610678272)]
    COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    int IsEditable
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    int IsRequestedForMainFrame
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678275)]
    string PageUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678276)]
    string FrameUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678277)]
    int HasLinkUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678278)]
    string LinkUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678279)]
    int HasLinkText
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678280)]
    string LinkText
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678281)]
    int HasSourceUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678282)]
    string SourceUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678283)]
    int HasSelection
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678284)]
    string SelectionText
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
