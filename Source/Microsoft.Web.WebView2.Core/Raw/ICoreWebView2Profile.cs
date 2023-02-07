namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("79110AD3-CD5D-4373-8BC3-C60658F17A5F")]
[TypeIdentifier]
public interface ICoreWebView2Profile
{
    [DispId(1610678272)]
    string ProfileName
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678273)]
    int IsInPrivateModeEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    string ProfilePath
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678275)]
    string DefaultDownloadFolderPath
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.LPWStr)]
        set;
    }

    [DispId(1610678277)]
    COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
