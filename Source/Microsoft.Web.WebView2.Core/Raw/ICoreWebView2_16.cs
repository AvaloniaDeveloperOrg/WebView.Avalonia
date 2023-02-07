namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0EB34DC9-9F91-41E1-8639-95CD5943906B")]
[TypeIdentifier]
public interface ICoreWebView2_16 : ICoreWebView2_15
{
    void _VtblGap1_110();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Print([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ShowPrintUI([In] COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PrintToPdfStream([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfStreamCompletedHandler handler);
}
