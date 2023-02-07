namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("969B3A26-D85E-4795-8199-FEF57344DA22")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ServerCertificateErrorDetectedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ServerCertificateErrorDetectedEventArgs args);
}
