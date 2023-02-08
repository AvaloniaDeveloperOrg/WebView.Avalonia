namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("B1690564-6F5A-4983-8E48-31D1143FECDB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_10 : ICoreWebView2_9
{
    void _VtblGap1_94();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_BasicAuthenticationRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BasicAuthenticationRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_BasicAuthenticationRequested([In] EventRegistrationToken token);
}
