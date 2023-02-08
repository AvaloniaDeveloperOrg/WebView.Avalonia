namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("6C4819F3-C9B7-4260-8127-C9F5BDE7F68C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int errorCode, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller createdController);
}
