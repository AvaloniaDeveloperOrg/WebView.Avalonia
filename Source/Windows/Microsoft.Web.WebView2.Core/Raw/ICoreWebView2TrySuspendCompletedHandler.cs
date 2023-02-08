namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00F206A7-9D17-4605-91F6-4E8E4DE192E3")]
[TypeIdentifier]
public interface ICoreWebView2TrySuspendCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In] int isSuccessful);
}
