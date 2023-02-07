namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("488DC902-35EF-42D2-BC7D-94B65C4BC49C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Settings7 : ICoreWebView2Settings6
{
    [DispId(1611071488)]
    COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    void _VtblGap1_30();
}
