namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("8F3EC528-0596-4D51-9F9E-2DA580AC9787")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalWebResourceRequestedEventArgs
{
    [DispId(1610678272)]
    COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS RequestedSourceKind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
