namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("B188E659-5685-4E05-BDBA-FC640E0F1992")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Profile3 : ICoreWebView2Profile2
{
    void _VtblGap1_10();

    [DispId(1610809344)]
    COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
