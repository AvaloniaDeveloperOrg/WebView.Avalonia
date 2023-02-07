namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("5DA51469-DCFB-435E-8ABE-E716312C577E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental6
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ContextMenuRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ContextMenuRequested([In] EventRegistrationToken token);
}
