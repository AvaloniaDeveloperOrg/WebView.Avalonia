namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("AE714520-D062-4D20-9D08-5096F590ED1A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment8
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions([In][MarshalAs(UnmanagedType.LPWStr)] string ProfileName, [In] int IsInPrivateModeEnabled);
}
