namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E2FDA4BE-5456-406C-A261-3D452138362C")]
[TypeIdentifier]
public interface ICoreWebView2DevToolsProtocolEventReceivedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DevToolsProtocolEventReceivedEventArgs args);
}
