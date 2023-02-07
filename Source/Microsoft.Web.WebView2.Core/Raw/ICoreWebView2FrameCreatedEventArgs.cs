namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4D6E7B5E-9BAA-11EB-A8B3-0242AC130003")]
[TypeIdentifier]
public interface ICoreWebView2FrameCreatedEventArgs
{
    [DispId(1610678272)]
    ICoreWebView2Frame Frame
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }
}
