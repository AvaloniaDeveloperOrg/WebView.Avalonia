namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("609302AD-0E36-4F9A-A210-6A45272842A9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2FrameNavigationCompletedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Frame sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventArgs args);
}
