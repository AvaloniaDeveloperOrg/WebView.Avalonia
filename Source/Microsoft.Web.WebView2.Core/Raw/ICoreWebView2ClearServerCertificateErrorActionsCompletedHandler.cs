namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3B40AAC6-ACFE-4FFD-8211-F607B96E2D5B")]
[TypeIdentifier]
public interface ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode);
}
