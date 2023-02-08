namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("45B1F964-F703-47AC-A19A-B589DD0C5559")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSettings5
{
    [DispId(1610678272)]
    int IsSwipeNavigationEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
