namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("DD503E49-AB19-47C0-B2AD-6DDD09CC3E3A")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalUpdateRuntimeResult
{
    [DispId(1610678272)]
    COREWEBVIEW2_UPDATE_RUNTIME_STATUS Status
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    int ExtendedError
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Error)]
        get;
    }
}
