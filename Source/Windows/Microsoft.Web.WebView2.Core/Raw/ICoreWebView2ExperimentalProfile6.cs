namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("CF9A4B21-5022-4E67-983D-922DDD53D4B6")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalProfile6
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetPermissionState([In] COREWEBVIEW2_PERMISSION_KIND PermissionKind, [In][MarshalAs(UnmanagedType.LPWStr)] string origin, [In] COREWEBVIEW2_PERMISSION_STATE State, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalSetPermissionStateCompletedHandler completedHandler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetNonDefaultPermissionSettings([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalGetNonDefaultPermissionSettingsCompletedHandler completedHandler);
}
