namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("58B4D6C2-18D4-497E-B39B-9A96533FA278")]
[TypeIdentifier]
public interface ICoreWebView2BasicAuthenticationRequestedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BasicAuthenticationRequestedEventArgs args);
}
