namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("177CD9E7-B6F5-451A-94A0-5D7A3A4C4141")]
[TypeIdentifier]
public interface ICoreWebView2CookieManager
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CreateCookie([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string value, [In][MarshalAs(UnmanagedType.LPWStr)] string Domain, [In][MarshalAs(UnmanagedType.LPWStr)] string Path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CopyCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookieParam);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetCookies([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetCookiesCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddOrUpdateCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void DeleteCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void DeleteCookies([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string uri);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void DeleteCookiesWithDomainAndPath([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string Domain, [In][MarshalAs(UnmanagedType.LPWStr)] string Path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void DeleteAllCookies();
}
