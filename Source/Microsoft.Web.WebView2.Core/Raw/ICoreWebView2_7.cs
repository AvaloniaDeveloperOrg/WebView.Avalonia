namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("79C24D83-09A3-45AE-9418-487F32A58740")]
[TypeIdentifier]
public interface ICoreWebView2_7 : ICoreWebView2_6
{
    void _VtblGap1_77();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PrintToPdf([In][MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings? printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler);
}
