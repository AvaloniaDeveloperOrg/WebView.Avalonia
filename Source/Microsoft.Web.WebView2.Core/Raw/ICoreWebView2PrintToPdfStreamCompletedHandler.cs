namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4C9F8229-8F93-444F-A711-2C0DFD6359D5")]
[TypeIdentifier]
public interface ICoreWebView2PrintToPdfStreamCompletedHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Interface)] IStream pdfStream);
}
