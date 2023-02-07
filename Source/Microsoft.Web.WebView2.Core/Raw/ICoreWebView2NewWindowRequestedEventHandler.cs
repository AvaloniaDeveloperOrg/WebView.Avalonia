namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D4C185FE-C81C-4989-97AF-2D3FA7AB5651")]
[TypeIdentifier]
public interface ICoreWebView2NewWindowRequestedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2 sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewWindowRequestedEventArgs args);
}
