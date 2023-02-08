namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("FA740D4B-5EAE-4344-A8AD-74BE31925397")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Profile2 : ICoreWebView2Profile
{
    void _VtblGap1_7();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearBrowsingData([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearBrowsingDataInTimeRange([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In] double startTime, [In] double endTime, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearBrowsingDataAll([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
}
