namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("38059770-9BAA-11EB-A8B3-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2FrameCreatedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventArgs args);
}
