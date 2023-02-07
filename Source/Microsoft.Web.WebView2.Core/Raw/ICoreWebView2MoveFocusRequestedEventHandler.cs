namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("69035451-6DC7-4CB8-9BCE-B2BD70AD289F")]
[TypeIdentifier]
public interface ICoreWebView2MoveFocusRequestedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller sender, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2MoveFocusRequestedEventArgs args);
}
