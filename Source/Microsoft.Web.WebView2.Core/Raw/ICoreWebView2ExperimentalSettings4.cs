namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("19F47D09-D208-4FEB-9E19-A3AFD2FE13CA")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSettings4
{
    [DispId(1610678272)]
    int IsPinchZoomEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
