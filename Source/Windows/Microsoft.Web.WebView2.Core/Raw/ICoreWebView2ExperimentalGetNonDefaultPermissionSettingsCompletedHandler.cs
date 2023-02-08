namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("38274481-A15C-4563-94CF-990EDC9AEB95")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalGetNonDefaultPermissionSettingsCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalPermissionSettingCollectionView collectionView);
}
