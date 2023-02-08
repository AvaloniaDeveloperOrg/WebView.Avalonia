namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("84FA7612-3F3D-4FBF-889D-FAD000492D72")]
[TypeIdentifier]
public interface ICoreWebView2ProcessInfo
{
    [DispId(1610678272)]
    int ProcessId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    COREWEBVIEW2_PROCESS_KIND Kind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
