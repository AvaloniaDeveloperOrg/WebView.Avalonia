namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2B1AAA06-CE28-4565-AE06-26404C2E8D10")]
[TypeIdentifier]
public interface ICoreWebView2Experimental12
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FaviconChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FaviconChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FaviconChanged([In] EventRegistrationToken token);

    [DispId(1610678274)]
    string FaviconUri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetFavicon([In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetFaviconCompletedHandler completedHandler);
}
