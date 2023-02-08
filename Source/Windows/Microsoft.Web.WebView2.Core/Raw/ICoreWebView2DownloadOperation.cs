namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3D6B6CF2-AFE1-44C7-A995-C65117714336")]
[TypeIdentifier]
public interface ICoreWebView2DownloadOperation
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_BytesReceivedChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2BytesReceivedChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_BytesReceivedChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_EstimatedEndTimeChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_EstimatedEndTimeChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_StateChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2StateChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_StateChanged([In] EventRegistrationToken token);

    [DispId(1610678278)]
    string Uri
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678279)]
    string ContentDisposition
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678280)]
    string MimeType
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678281)]
    long TotalBytesToReceive
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678282)]
    long BytesReceived
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678283)]
    string EstimatedEndTime
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678284)]
    string ResultFilePath
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678285)]
    COREWEBVIEW2_DOWNLOAD_STATE State
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678286)]
    COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Cancel();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Pause();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Resume();

    [DispId(1610678290)]
    int CanResume
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
