namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9C98C8B1-AC53-427E-A345-3049B5524BBE")]
[TypeIdentifier]
public interface ICoreWebView2RasterizationScaleChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
