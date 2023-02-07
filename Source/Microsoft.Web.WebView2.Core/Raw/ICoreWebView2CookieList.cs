namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("F7F6F714-5D2A-43C6-9503-346ECE02D186")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CookieList
{
    [DispId(1610678272)]
    uint Count
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie GetValueAtIndex([In] uint index);
}
