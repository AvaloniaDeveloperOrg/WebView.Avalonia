namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2F890C1D-02C1-4612-B2BA-E2CC0C7DA07C")]
[TypeIdentifier]
public interface ICoreWebView2Experimental10
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_BasicAuthenticationRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BasicAuthenticationRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_BasicAuthenticationRequested([In] EventRegistrationToken token);
}
