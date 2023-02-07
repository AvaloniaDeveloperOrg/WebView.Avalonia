namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4C765E35-5BEB-4631-B931-5E52D9B0A9BE")]
[TypeIdentifier]
public interface ICoreWebView2Experimental19
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void ExecuteScriptWithResult([In][MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalExecuteScriptWithResultCompletedHandler handler);
}
