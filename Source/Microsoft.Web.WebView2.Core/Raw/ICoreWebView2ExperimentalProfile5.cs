namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("89B9907D-863E-4B1A-9C8C-0A80F0045622")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalProfile5
{
    [DispId(1610678272)]
    COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
