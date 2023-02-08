namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D98DE66D-46D7-4090-91E1-EDF8E66FDB7B")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSettings6
{
    [DispId(1610678272)]
    COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
