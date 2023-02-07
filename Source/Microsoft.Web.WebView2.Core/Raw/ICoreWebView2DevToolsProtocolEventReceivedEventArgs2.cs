namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2DC4959D-1494-4393-95BA-BEA4CB9EBD1B")]
[TypeIdentifier]
public interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 : ICoreWebView2DevToolsProtocolEventReceivedEventArgs
{
    void _VtblGap1_1();

    [DispId(1610743808)]
    string SessionId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
