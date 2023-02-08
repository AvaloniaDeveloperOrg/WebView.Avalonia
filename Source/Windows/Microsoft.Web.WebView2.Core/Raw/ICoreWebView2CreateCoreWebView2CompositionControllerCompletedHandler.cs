namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("02FAB84B-1428-4FB7-AD45-1B2E64736184")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int errorCode, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CompositionController webView);
}
