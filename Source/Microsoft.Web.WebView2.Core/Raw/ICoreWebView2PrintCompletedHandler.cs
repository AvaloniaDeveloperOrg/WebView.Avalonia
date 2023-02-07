namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8FD80075-ED08-42DB-8570-F5D14977461E")]
[TypeIdentifier]
public interface ICoreWebView2PrintCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In] COREWEBVIEW2_PRINT_STATUS printStatus);
}
