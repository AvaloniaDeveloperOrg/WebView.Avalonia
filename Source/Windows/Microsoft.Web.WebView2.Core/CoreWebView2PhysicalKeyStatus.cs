using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public struct CoreWebView2PhysicalKeyStatus
{
    public uint RepeatCount;

    public uint ScanCode;

    public int IsExtendedKey;

    public int IsMenuKeyDown;

    public int WasKeyDown;

    public int IsKeyReleased;

    internal CoreWebView2PhysicalKeyStatus(COREWEBVIEW2_PHYSICAL_KEY_STATUS rawStruct)
    {
        RepeatCount = rawStruct.RepeatCount;
        ScanCode = rawStruct.ScanCode;
        IsExtendedKey = rawStruct.IsExtendedKey;
        IsMenuKeyDown = rawStruct.IsMenuKeyDown;
        WasKeyDown = rawStruct.WasKeyDown;
        IsKeyReleased = rawStruct.IsKeyReleased;
    }
}
