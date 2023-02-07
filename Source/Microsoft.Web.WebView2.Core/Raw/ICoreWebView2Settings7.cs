namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("488DC902-35EF-42D2-BC7D-94B65C4BC49C")]
[TypeIdentifier]
public interface ICoreWebView2Settings7 : ICoreWebView2Settings6
{
    void _VtblGap1_30();

    [DispId(1611071488)]
    COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
