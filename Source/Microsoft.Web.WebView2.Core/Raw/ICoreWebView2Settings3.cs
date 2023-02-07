namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FDB5AB74-AF33-4854-84F0-0A631DEB5EBA")]
[TypeIdentifier]
public interface ICoreWebView2Settings3 : ICoreWebView2Settings2
{
    void _VtblGap1_20();

    [DispId(1610809344)]
    int AreBrowserAcceleratorKeysEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
