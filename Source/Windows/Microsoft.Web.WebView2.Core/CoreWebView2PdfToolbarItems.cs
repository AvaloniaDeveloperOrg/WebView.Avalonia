namespace Microsoft.Web.WebView2.Core;

[Flags]
public enum CoreWebView2PdfToolbarItems
{
    None = 0,
    Save = 1,
    Print = 2,
    SaveAs = 4,
    ZoomIn = 8,
    ZoomOut = 0x10,
    Rotate = 0x20,
    FitPage = 0x40,
    PageLayout = 0x80,
    Bookmarks = 0x100,
    PageSelector = 0x200,
    Search = 0x400,
    FullScreen = 0x800,
    MoreSettings = 0x1000
}
