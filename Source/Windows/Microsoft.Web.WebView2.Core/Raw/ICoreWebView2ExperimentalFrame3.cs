namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6939FEF6-01AB-4B24-B639-7C1B82BC0984")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalFrame3
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_PermissionRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FramePermissionRequestedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_PermissionRequested([In] EventRegistrationToken token);
}
