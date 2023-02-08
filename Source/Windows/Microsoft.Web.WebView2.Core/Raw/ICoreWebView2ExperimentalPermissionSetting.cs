namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("792B6ECA-5576-421C-9119-74EBB3A4FFB3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalPermissionSetting
{
    [DispId(1610678272)]
    COREWEBVIEW2_PERMISSION_KIND PermissionKind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    string PermissionOrigin
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678274)]
    COREWEBVIEW2_PERMISSION_STATE PermissionState
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
