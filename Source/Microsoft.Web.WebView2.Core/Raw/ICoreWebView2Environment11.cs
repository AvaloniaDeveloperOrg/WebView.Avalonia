namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("F0913DC6-A0EC-42EF-9805-91DFF3A2966A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment11 : ICoreWebView2Environment10
{
    void _VtblGap1_20();

    [DispId(1611333632)]
    string FailureReportFolderPath
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
