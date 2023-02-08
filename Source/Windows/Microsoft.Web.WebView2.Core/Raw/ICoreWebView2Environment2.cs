namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("41F3632B-5EF4-404F-AD82-2D606C5A9A21")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment2 : ICoreWebView2Environment
{
    void _VtblGap1_5();

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2WebResourceRequest CreateWebResourceRequest([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In][MarshalAs(UnmanagedType.LPWStr)] string Method, [In][MarshalAs(UnmanagedType.Interface)] IStream postData, [In][MarshalAs(UnmanagedType.LPWStr)] string Headers);
}
