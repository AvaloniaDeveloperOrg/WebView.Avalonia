namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("E9632730-6E1E-43AB-B7B8-7B2C9E62E094")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2_8 : ICoreWebView2_7
{
    void _VtblGap1_78();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_IsMutedChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsMutedChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_IsMutedChanged([In] EventRegistrationToken token);

    [DispId(1611137026)]
    int IsMuted
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_IsDocumentPlayingAudioChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDocumentPlayingAudioChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_IsDocumentPlayingAudioChanged([In] EventRegistrationToken token);

    [DispId(1611137030)]
    int IsDocumentPlayingAudio
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
