namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("D1DB483D-6796-4B8B-80FC-13712BB716F4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2WebResourceResponseReceivedEventArgs
{
    [DispId(1610678272)]
    ICoreWebView2WebResourceRequest Request
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678273)]
    ICoreWebView2WebResourceResponseView Response
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }
}
