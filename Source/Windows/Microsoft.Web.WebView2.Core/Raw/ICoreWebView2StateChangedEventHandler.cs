namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("81336594-7EDE-4BA9-BF71-ACF0A95B58DD")]
[TypeIdentifier]
public interface ICoreWebView2StateChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
