namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("20D02D59-6DF2-42DC-BD06-F98A694B1302")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_4 : ICoreWebView2_3
{
    void _VtblGap1_70();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_FrameCreated([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_FrameCreated([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DownloadStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DownloadStarting([In] EventRegistrationToken token);
}
