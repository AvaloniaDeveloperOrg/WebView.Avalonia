namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F80EDFF2-EF0A-4B35-919B-AA9863E732AA")]
[TypeIdentifier]
public interface ICoreWebView2Experimental9
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_IsMutedChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsMutedChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_IsMutedChanged([In] EventRegistrationToken token);

    [DispId(1610678274)]
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

    [DispId(1610678278)]
    int IsDocumentPlayingAudio
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
