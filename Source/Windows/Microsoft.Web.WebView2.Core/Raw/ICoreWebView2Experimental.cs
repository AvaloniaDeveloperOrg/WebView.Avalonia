namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("A3D0C16A-9BA9-11EB-A8B3-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FrameCreated([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FrameCreated([In] EventRegistrationToken token);
}
