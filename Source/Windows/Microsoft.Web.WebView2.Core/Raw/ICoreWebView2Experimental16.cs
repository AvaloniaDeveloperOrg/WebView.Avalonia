namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("679DDF3F-9044-486F-8458-16653A0E1603")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Experimental16
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddWebResourceRequestedFilterWithRequestSourceKinds([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveWebResourceRequestedFilterWithRequestSourceKinds([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);
}
