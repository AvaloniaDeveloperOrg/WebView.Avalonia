namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("F811AA06-BCC3-11EB-8529-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental3
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ClientCertificateRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ClientCertificateRequested([In] EventRegistrationToken token);
}
