namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("EE0EB9DF-6F12-46CE-B53F-3F47B9C928E0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment10 : ICoreWebView2Environment9
{
    void _VtblGap1_17();

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CreateCoreWebView2ControllerWithOptions([In] IntPtr ParentWindow, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CreateCoreWebView2CompositionControllerWithOptions([In] IntPtr ParentWindow, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);
}
