namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("875738E1-9FA2-40E3-8B74-2E8972DD6FE7")]
[TypeIdentifier]
public interface ICoreWebView2WebResourceResponseViewGetContentCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Interface)] IStream Content);
}
