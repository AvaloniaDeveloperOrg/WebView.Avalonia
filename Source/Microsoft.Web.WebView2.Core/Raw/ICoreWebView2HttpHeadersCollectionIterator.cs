namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0702FC30-F43B-47BB-AB52-A42CB552AD9F")]
[TypeIdentifier]
public interface ICoreWebView2HttpHeadersCollectionIterator
{
    [DispId(1610678273)]
    int HasCurrentHeader
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetCurrentHeader([MarshalAs(UnmanagedType.LPWStr)] out string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    int MoveNext();
}
