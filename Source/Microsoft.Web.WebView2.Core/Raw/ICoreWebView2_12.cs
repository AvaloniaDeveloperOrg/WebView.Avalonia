namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("35D69927-BCFA-4566-9349-6B3E0D154CAC")]
[TypeIdentifier]
public interface ICoreWebView2_12 : ICoreWebView2_11
{
    void _VtblGap1_99();

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_StatusBarTextChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2StatusBarTextChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_StatusBarTextChanged([In] EventRegistrationToken token);

    [DispId(1611399170)]
    string StatusBarText
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
