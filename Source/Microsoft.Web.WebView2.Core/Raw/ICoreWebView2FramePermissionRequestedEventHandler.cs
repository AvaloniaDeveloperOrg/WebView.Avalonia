namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("845D0EDD-8BD8-429B-9915-4821789F23E9")]
[TypeIdentifier]
public interface ICoreWebView2FramePermissionRequestedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Frame sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PermissionRequestedEventArgs2 args);
}
