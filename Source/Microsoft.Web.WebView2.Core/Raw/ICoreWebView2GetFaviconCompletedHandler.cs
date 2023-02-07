namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A2508329-7DA8-49D7-8C05-FA125E4AEE8D")]
[TypeIdentifier]
public interface ICoreWebView2GetFaviconCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Interface)] IStream faviconStream);
}
