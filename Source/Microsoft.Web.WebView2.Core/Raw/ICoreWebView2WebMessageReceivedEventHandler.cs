namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("57213F19-00E6-49FA-8E07-898EA01ECBD2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2WebMessageReceivedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventArgs args);
}
