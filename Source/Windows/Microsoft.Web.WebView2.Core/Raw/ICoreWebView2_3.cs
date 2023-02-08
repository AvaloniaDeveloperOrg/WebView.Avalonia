namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("A0D6DF20-3B92-416D-AA0C-437A9C727857")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_3 : ICoreWebView2_2
{
    void _VtblGap1_65();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void TrySuspend([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Resume();

    [DispId(1610809346)]
    int IsSuspended
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetVirtualHostNameToFolderMapping([In][MarshalAs(UnmanagedType.LPWStr)] string hostName, [In][MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ClearVirtualHostNameToFolderMapping([In][MarshalAs(UnmanagedType.LPWStr)] string hostName);
}
