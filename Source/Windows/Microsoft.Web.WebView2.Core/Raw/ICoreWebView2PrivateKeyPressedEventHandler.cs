namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E8A34C9D-4BF8-4AEF-BB0B-4A392C987A6E")]
[TypeIdentifier]
public interface ICoreWebView2PrivateKeyPressedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateKeyPressedEventArgs args);
}
