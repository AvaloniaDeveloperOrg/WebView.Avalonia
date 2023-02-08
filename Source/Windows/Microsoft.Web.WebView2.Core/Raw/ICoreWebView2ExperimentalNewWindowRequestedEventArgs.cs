namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F813E079-73BA-4E6F-A4A8-D08C8358FDEB")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalNewWindowRequestedEventArgs
{
    [DispId(1610678272)]
    string Name
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
