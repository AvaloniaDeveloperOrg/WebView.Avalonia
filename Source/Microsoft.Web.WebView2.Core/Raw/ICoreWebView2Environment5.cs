namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("319E423D-E0D7-4B8D-9254-AE9475DE9B17")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment5 : ICoreWebView2Environment4
{
    void _VtblGap1_9();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_BrowserProcessExited([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_BrowserProcessExited([In] EventRegistrationToken token);
}
