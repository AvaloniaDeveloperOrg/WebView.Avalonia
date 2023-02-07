namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("402B99CD-A0CC-4FA5-B7A5-51D86A1D2339")]
[TypeIdentifier]
public interface ICoreWebView2ProcessInfoCollection
{
    [DispId(1610678272)]
    uint Count
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ProcessInfo GetValueAtIndex([In] uint index);
}
