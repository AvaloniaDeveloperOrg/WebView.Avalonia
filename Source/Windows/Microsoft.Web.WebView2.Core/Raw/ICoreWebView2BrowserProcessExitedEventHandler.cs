namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FA504257-A216-4911-A860-FE8825712861")]
[TypeIdentifier]
public interface ICoreWebView2BrowserProcessExitedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventArgs args);
}
