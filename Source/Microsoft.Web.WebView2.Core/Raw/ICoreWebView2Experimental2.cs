namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("84E547A6-2CF7-4966-A44E-3DD10BE69A7F")]
[TypeIdentifier]
public interface ICoreWebView2Experimental2
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_DownloadStarting([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_DownloadStarting([In] EventRegistrationToken token);
}
