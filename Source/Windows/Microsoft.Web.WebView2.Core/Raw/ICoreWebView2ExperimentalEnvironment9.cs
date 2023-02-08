namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B0BCE74E-4E55-4201-A776-86012BE93981")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment9
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_ProcessInfosChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessInfosChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_ProcessInfosChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ProcessInfoCollection GetProcessInfos();
}
