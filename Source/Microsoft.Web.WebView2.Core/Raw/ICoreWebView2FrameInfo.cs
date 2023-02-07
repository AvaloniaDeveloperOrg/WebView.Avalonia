namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("DA86B8A1-BDF3-4F11-9955-528CEFA59727")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2FrameInfo
{
    [DispId(1610678272)]
    string Name
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678273)]
    string Source
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
