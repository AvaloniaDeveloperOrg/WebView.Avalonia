namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("517B2D1D-7DAE-4A66-A4F4-10352FFB9518")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_15 : ICoreWebView2_14
{
    void _VtblGap1_106();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FaviconChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FaviconChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FaviconChanged([In] EventRegistrationToken token);

    [DispId(1611595778)]
    string FaviconUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetFavicon([In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetFaviconCompletedHandler completedHandler);
}
