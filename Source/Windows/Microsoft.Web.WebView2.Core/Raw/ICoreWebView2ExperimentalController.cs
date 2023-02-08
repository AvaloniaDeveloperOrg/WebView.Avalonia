namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("3413543F-7A0E-4B56-98C1-7AF3A37416CA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalController
{
    [DispId(1610678272)]
    double RasterizationScale
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610678274)]
    int ShouldDetectMonitorScaleChanges
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_RasterizationScaleChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalRasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_RasterizationScaleChanged([In] EventRegistrationToken token);

    [DispId(1610678278)]
    COREWEBVIEW2_BOUNDS_MODE BoundsMode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
