namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FC77FB30-9C9E-4076-B8C7-7644A703CA1B")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSetPermissionStateCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode);
}
