namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("CCF1EF04-FD8E-4D5F-B2DE-0983E41B8C36")]
[TypeIdentifier]
public interface ICoreWebView2PrintToPdfCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, int isSuccessful);
}
