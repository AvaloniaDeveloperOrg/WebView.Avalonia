namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("04D4FE1D-AB87-42FB-A898-DA241D35B63C")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment6
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ContextMenuItem CreateContextMenuItem([In][MarshalAs(UnmanagedType.LPWStr)] string Label, [In][MarshalAs(UnmanagedType.Interface)] IStream iconStream, [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind);
}
