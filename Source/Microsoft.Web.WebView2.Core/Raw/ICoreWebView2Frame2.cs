namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("7A6A5834-D185-4DBF-B63F-4A9BC43107D4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Frame2 : ICoreWebView2Frame
{
    void _VtblGap1_8();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NavigationStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationStartingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ContentLoading([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameContentLoadingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NavigationCompleted([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DOMContentLoaded([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DOMContentLoaded([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void ExecuteScript([In][MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsJson([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostWebMessageAsString([In][MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_WebMessageReceived([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameWebMessageReceivedEventHandler handler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_WebMessageReceived([In] EventRegistrationToken token);
}
