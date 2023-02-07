namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("AC52D13F-0D38-475A-9DCA-876580D6793E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2EnvironmentOptions4
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetCustomSchemeRegistrations(out uint Count, [Out] IntPtr schemeRegistrations);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetCustomSchemeRegistrations([In] uint Count, [In][MarshalAs(UnmanagedType.Interface)] ref ICoreWebView2CustomSchemeRegistration schemeRegistrations);
}
