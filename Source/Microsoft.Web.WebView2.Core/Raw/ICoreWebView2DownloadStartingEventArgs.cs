namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("E99BBE21-43E9-4544-A732-282764EAFA60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2DownloadStartingEventArgs
{
    [DispId(1610678272)]
    ICoreWebView2DownloadOperation DownloadOperation
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678273)]
    int Cancel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610678275)]
    string ResultFilePath
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
    int Handled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();
}
