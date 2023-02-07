namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("BBC7BAED-74C6-4C92-B63A-7F5AEAE03DE3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2NewWindowRequestedEventArgs2 : ICoreWebView2NewWindowRequestedEventArgs
{
    void _VtblGap1_8();

    [DispId(1610743808)]
    string Name
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
