namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D267CA18-6779-49F9-B18E-75C25C61FA9B")]
[TypeIdentifier]
public interface ICoreWebView2Experimental15
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ServerCertificateErrorDetected([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ServerCertificateErrorDetectedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ServerCertificateErrorDetected([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearServerCertificateErrorActions([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler);
}
