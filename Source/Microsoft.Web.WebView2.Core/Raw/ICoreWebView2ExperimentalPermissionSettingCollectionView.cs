namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F5596F62-3DE5-47B1-91E8-A4104B596B96")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalPermissionSettingCollectionView
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ExperimentalPermissionSetting GetValueAtIndex([In] uint index);

    [DispId(1610678273)]
    uint Count
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
