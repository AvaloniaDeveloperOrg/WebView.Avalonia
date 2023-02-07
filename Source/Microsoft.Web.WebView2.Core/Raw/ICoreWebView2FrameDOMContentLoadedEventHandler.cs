namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("38D9520D-340F-4D1E-A775-43FCE9753683")]
[TypeIdentifier]
public interface ICoreWebView2FrameDOMContentLoadedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Frame sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventArgs args);
}
