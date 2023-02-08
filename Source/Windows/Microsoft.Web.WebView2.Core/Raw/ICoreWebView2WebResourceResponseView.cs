namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("79701053-7759-4162-8F7D-F1B3F084928D")]
[TypeIdentifier]
public interface ICoreWebView2WebResourceResponseView
{
    [DispId(1610678272)]
    ICoreWebView2HttpResponseHeaders Headers
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678273)]
    int StatusCode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    string ReasonPhrase
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetContent([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseViewGetContentCompletedHandler handler);
}
