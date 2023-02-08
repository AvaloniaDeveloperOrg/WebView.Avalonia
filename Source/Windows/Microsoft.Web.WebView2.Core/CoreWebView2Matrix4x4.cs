using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public struct CoreWebView2Matrix4x4
{
	public float _11;

	public float _12;

	public float _13;

	public float _14;

	public float _21;

	public float _22;

	public float _23;

	public float _24;

	public float _31;

	public float _32;

	public float _33;

	public float _34;

	public float _41;

	public float _42;

	public float _43;

	public float _44;

	internal CoreWebView2Matrix4x4(COREWEBVIEW2_MATRIX_4X4 rawStruct)
	{
		_11 = rawStruct._11;
		_12 = rawStruct._12;
		_13 = rawStruct._13;
		_14 = rawStruct._14;
		_21 = rawStruct._21;
		_22 = rawStruct._22;
		_23 = rawStruct._23;
		_24 = rawStruct._24;
		_31 = rawStruct._31;
		_32 = rawStruct._32;
		_33 = rawStruct._33;
		_34 = rawStruct._34;
		_41 = rawStruct._41;
		_42 = rawStruct._42;
		_43 = rawStruct._43;
		_44 = rawStruct._44;
	}
}
