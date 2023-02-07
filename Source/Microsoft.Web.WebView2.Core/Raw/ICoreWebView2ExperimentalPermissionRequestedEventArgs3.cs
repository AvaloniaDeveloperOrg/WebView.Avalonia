namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("E61670BC-3DCE-4177-86D2-C629AE3CB6AC")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalPermissionRequestedEventArgs3 : ICoreWebView2PermissionRequestedEventArgs2
{
    void _VtblGap1_8();

    [DispId(1610809344)]
    int SavesInProfile
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
