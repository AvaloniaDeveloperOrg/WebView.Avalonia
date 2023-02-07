namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("EFEDC989-C396-41CA-83F7-07F845A55724")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2DownloadStartingEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventArgs args);
}
