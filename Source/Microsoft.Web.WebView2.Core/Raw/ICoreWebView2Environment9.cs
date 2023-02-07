namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F06F41BF-4B5A-49D8-B9F6-FA16CD29F274")]
[TypeIdentifier]
public interface ICoreWebView2Environment9 : ICoreWebView2Environment8
{
    void _VtblGap1_16();

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ContextMenuItem CreateContextMenuItem([In][MarshalAs(UnmanagedType.LPWStr)] string Label, [In][MarshalAs(UnmanagedType.Interface)] IStream iconStream, [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind);
}
