namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D")]
[TypeIdentifier]
public interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int errorCode, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment createdEnvironment);
}
