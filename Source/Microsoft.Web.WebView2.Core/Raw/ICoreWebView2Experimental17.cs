namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("531FFEE9-6225-43F3-9EA9-5AD3EC887EFD")]
[TypeIdentifier]
public interface ICoreWebView2Experimental17
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Print([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ShowPrintUI([In] COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PrintToPdfStream([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfStreamCompletedHandler handler);
}
