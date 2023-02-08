namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4E4D8937-7FC7-4D40-A101-D3C74BBC3785")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalProfile3
{
    [DispId(1610678272)]
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
}
