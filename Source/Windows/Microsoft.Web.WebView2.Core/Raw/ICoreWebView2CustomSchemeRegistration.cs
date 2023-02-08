namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("D60AC92C-37A6-4B26-A39E-95CFE59047BB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CustomSchemeRegistration
{
    [DispId(1610678272)]
    string SchemeName
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678273)]
    int TreatAsSecure
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetAllowedOrigins(out uint allowedOriginsCount, [Out] IntPtr allowedOrigins);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetAllowedOrigins([In] uint allowedOriginsCount, [In][MarshalAs(UnmanagedType.LPWStr)] ref string allowedOrigins);

    [DispId(1610678277)]
    int HasAuthorityComponent
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
