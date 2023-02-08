namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("EE38B7E1-221D-465D-864B-EA4C22194DCA")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalProfile4
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearBrowsingData([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
}
