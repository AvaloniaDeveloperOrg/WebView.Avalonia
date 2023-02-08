namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("697E05E9-3D8F-45FA-96F4-8FFE1EDEDAF5")]
[TypeIdentifier]
public interface ICoreWebView2CapturePreviewCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode);
}
