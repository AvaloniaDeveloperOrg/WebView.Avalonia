namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("FDF8B738-EE1E-4DB2-A329-8D7D7B74D792")]
[TypeIdentifier]
public interface ICoreWebView2NavigationCompletedEventArgs2 : ICoreWebView2NavigationCompletedEventArgs
{
    [DispId(1610743808)]
    int HttpStatusCode
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    void _VtblGap1_3();
}
