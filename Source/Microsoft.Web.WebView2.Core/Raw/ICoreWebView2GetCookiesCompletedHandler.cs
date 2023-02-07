namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("5A4F5069-5C15-47C3-8646-F4DE1C116670")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2GetCookiesCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int result, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CookieList cookieList);
}
