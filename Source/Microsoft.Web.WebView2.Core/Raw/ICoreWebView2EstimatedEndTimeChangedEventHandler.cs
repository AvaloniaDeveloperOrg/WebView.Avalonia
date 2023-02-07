namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("28F0D425-93FE-4E63-9F8D-2AEEC6D3BA1E")]
[TypeIdentifier]
public interface ICoreWebView2EstimatedEndTimeChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
