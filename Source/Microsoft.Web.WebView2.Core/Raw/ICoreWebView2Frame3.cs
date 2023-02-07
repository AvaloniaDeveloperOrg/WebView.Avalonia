namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B50D82CC-CC28-481D-9614-CB048895E6A0")]
[TypeIdentifier]
public interface ICoreWebView2Frame3 : ICoreWebView2Frame2
{
    void _VtblGap1_21();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_PermissionRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FramePermissionRequestedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_PermissionRequested([In] EventRegistrationToken token);
}
