namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("4DAB9422-46FA-4C3E-A5D2-41D2071D3680")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ProcessFailedEventArgs2 : ICoreWebView2ProcessFailedEventArgs
{
    [DispId(1610743808)]
    COREWEBVIEW2_PROCESS_FAILED_REASON Reason
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610743809)]
    int ExitCode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610743810)]
    string ProcessDescription
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610743811)]
    ICoreWebView2FrameInfoCollection FrameInfosForFailedProcess
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    void _VtblGap1_1();
}
