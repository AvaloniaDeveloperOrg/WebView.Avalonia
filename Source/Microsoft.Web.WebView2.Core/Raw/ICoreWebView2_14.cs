namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("6DAA4F10-4A90-4753-8898-77C5DF534165")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_14 : ICoreWebView2_13
{
    void _VtblGap1_103();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ServerCertificateErrorDetected([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ServerCertificateErrorDetectedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ServerCertificateErrorDetected([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearServerCertificateErrorActions([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler);
}
