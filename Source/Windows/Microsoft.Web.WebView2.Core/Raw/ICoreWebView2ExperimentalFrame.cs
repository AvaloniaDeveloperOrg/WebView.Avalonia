namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("423BA05F-55DD-4C50-8339-22AFD009ED31")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalFrame
{
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
}
