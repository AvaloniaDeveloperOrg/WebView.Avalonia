namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("D6EB91DD-C3D2-45E5-BD29-6DC2BC4DE9CF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Environment8 : ICoreWebView2Environment7
{
    void _VtblGap1_13();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ProcessInfosChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessInfosChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ProcessInfosChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ProcessInfoCollection GetProcessInfos();
}
