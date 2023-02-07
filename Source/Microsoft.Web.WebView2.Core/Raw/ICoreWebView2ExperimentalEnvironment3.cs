namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("9A2BE885-7F0B-4B26-B6DD-C969BAA00BF1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment3
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void UpdateRuntime([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler handler);
}
