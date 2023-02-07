namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("3FE03F21-30D5-45C1-B31F-2F5881EF11A3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalFrame2
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsJson([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsString([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WebMessageReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameWebMessageReceivedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WebMessageReceived([In] EventRegistrationToken token);
}
