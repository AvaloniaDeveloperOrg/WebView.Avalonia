namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E371E005-6D1D-4517-934B-A8F1629C62A5")]
[TypeIdentifier]
public interface ICoreWebView2FrameWebMessageReceivedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Frame sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventArgs args);
}
