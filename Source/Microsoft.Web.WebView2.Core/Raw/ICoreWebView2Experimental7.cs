namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("72A78E99-C92E-4616-8130-D57407EC5341")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental7
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void PrintToPdf([In][MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler);
}
