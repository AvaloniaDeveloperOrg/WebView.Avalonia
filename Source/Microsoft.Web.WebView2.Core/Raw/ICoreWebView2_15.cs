using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("517B2D1D-7DAE-4A66-A4F4-10352FFB9518")]
[TypeIdentifier]
public interface ICoreWebView2_15 : ICoreWebView2_14
{
	[DispId(1611595778)]
	string FaviconUri
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	void _VtblGap1_106();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void add_FaviconChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FaviconChangedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void remove_FaviconChanged([In] EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFavicon([In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetFaviconCompletedHandler completedHandler);
}
