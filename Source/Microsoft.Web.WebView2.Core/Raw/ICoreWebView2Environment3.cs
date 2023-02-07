namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("80A22AE3-BE7C-4CE2-AFE1-5A50056CDEEB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment3 : ICoreWebView2Environment2
{
    void _VtblGap1_6();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void CreateCoreWebView2CompositionController(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo();
}
