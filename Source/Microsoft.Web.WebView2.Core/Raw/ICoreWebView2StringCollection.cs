namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("F41F3F8A-BCC3-11EB-8529-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2StringCollection
{
    [DispId(1610678272)]
    uint Count
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string GetValueAtIndex([In] uint index);
}
