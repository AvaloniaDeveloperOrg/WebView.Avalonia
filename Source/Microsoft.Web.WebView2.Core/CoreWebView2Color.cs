using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public struct CoreWebView2Color
{
	public byte A;

	public byte R;

	public byte G;

	public byte B;

	internal CoreWebView2Color(COREWEBVIEW2_COLOR rawStruct)
	{
		A = rawStruct.A;
		R = rawStruct.R;
		G = rawStruct.G;
		B = rawStruct.B;
	}
}
