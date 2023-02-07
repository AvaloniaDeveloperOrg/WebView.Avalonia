namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("EC9B3015-B7B2-4C3A-998F-A8BCDFA0FB33")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2PrivateEnvironmentTesting
{
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
    void SetShouldCheckUninitializeForTesting([In] int should_check);
}
