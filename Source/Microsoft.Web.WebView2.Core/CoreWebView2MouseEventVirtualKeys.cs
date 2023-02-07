namespace Microsoft.Web.WebView2.Core;

[Flags]
public enum CoreWebView2MouseEventVirtualKeys
{
    None = 0,
    LeftButton = 1,
    RightButton = 2,
    Shift = 4,
    Control = 8,
    MiddleButton = 0x10,
    XButton1 = 0x20,
    XButton2 = 0x40
}
