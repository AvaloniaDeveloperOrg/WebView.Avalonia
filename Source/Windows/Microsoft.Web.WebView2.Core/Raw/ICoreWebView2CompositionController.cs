namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("3DF9B733-B9AE-4A15-86B4-EB9EE9826469")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CompositionController
{
    [DispId(1610678272)]
    object RootVisualTarget
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.IUnknown)]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SendMouseInput([In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, [In] uint mouseData, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SendPointerInput([In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PointerInfo pointerInfo);

    [DispId(1610678276)]
    IntPtr Cursor
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678277)]
    uint SystemCursorId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_CursorChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_CursorChanged([In] EventRegistrationToken token);
}
