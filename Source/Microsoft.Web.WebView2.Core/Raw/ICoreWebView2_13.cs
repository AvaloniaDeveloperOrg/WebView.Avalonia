using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F75F09A8-667E-4983-88D6-C8773F315E84")]
[TypeIdentifier]
public interface ICoreWebView2_13 : ICoreWebView2_12
{
	[DispId(1611464704)]
	ICoreWebView2Profile Profile
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_102();
}
