namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E05E04CA-7924-4C04-A84C-A90572DBA22A")]
[TypeIdentifier]
public interface ICoreWebView2Experimental5
{
    [DispId(1610678272)]
    COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL MemoryUsageTargetLevel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
