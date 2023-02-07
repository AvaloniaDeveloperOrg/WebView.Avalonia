namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("92CF9F34-F403-4D46-BFC3-0B5ED17D55CA")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalFrame4
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostSharedBufferToScript([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalSharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In][MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson);
}
