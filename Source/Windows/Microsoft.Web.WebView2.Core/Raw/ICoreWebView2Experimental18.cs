namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("B96480A2-167A-469F-A090-5F0F5C88DBE4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental18
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void PostSharedBufferToScript([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalSharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In][MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson);
}
