namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("4D7B2EAB-9FDC-468D-B998-A9260B5ED651")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_9 : ICoreWebView2_8
{
    void _VtblGap1_85();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_IsDefaultDownloadDialogOpenChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_IsDefaultDownloadDialogOpenChanged([In] EventRegistrationToken token);

    [DispId(1611202562)]
    int IsDefaultDownloadDialogOpen
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void OpenDefaultDownloadDialog();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CloseDefaultDownloadDialog();

    [DispId(1611202565)]
    COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1611202567)]
    tagPOINT DefaultDownloadDialogMargin
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
