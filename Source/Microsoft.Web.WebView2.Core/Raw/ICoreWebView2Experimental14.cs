namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C8F5F3A6-9890-4A1A-AF82-9C86CC99C2D6")]
[TypeIdentifier]
public interface ICoreWebView2Experimental14
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void CallDevToolsProtocolMethodForSession([In][MarshalAs(UnmanagedType.LPWStr)] string sessionId, [In][MarshalAs(UnmanagedType.LPWStr)] string methodName, [In][MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);
}
