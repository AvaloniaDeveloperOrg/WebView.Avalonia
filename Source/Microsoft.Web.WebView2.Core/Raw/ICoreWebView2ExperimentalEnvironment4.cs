namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0204E16B-7BC8-4BDC-94D7-1E70C4D1A8A7")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment4
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_BrowserProcessExited([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_BrowserProcessExited([In] EventRegistrationToken token);
}
