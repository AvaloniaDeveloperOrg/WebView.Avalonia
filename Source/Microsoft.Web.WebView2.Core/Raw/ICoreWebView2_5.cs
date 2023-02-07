namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("BEDB11B8-D63C-11EB-B8BC-0242AC130003")]
[TypeIdentifier]
public interface ICoreWebView2_5 : ICoreWebView2_4
{
    void _VtblGap1_74();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ClientCertificateRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ClientCertificateRequested([In] EventRegistrationToken token);
}
