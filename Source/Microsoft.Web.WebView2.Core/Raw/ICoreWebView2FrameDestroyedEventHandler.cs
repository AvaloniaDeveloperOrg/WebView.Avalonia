namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("59DD7B4C-9BAA-11EB-A8B3-0242AC130003")]
[TypeIdentifier]
public interface ICoreWebView2FrameDestroyedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Frame sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
