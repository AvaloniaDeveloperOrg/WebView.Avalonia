namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E6041D7F-18AC-4654-A04E-8B3F81251C33")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalCompositionController4
{
    void _VtblGap1_1();

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2PointerInfo CreateCoreWebView2PointerInfoFromPointerId([In] uint PointerId, [In] IntPtr ParentWindow, [In] COREWEBVIEW2_MATRIX_4X4 transform);
}
