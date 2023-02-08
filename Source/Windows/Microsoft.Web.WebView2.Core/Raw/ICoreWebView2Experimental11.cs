namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("9139C04D-8F37-42AE-8B63-01940C34D22F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental11
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_IsDefaultDownloadDialogOpenChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_IsDefaultDownloadDialogOpenChanged([In] EventRegistrationToken token);

    [DispId(1610678274)]
    int IsDefaultDownloadDialogOpen
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void OpenDefaultDownloadDialog();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CloseDefaultDownloadDialog();

    [DispId(1610678277)]
    COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610678279)]
    tagPOINT DefaultDownloadDialogMargin
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
