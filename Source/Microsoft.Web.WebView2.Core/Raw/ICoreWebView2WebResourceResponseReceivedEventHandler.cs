namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7DE9898A-24F5-40C3-A2DE-D4F458E69828")]
[TypeIdentifier]
public interface ICoreWebView2WebResourceResponseReceivedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventArgs args);
}
