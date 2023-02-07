namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("9E8F0CF8-E670-4B5E-B2BC-73E061E3184C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_2 : ICoreWebView2
{
    [DispId(1610743813)]
    ICoreWebView2CookieManager CookieManager
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610743814)]
    ICoreWebView2Environment Environment
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    void _VtblGap1_58();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WebResourceResponseReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WebResourceResponseReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void NavigateWithWebResourceRequest([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DOMContentLoaded([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DOMContentLoaded([In] EventRegistrationToken token);
}
