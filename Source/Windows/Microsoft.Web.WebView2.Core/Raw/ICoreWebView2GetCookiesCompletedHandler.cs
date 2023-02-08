namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5A4F5069-5C15-47C3-8646-F4DE1C116670")]
[TypeIdentifier]
public interface ICoreWebView2GetCookiesCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int result, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CookieList cookieList);
}
