namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1BB5317B-8238-4C67-A7FF-BAF6558F289D")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalExecuteScriptWithResultCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalExecuteScriptResult result);
}
