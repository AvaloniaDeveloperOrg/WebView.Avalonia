namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B29C7E28-FA79-41A8-8E44-65811C76DCB2")]
[TypeIdentifier]
public interface ICoreWebView2AcceleratorKeyPressedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2AcceleratorKeyPressedEventArgs args);
}
