namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("EE9A0F68-F46C-4E32-AC23-EF8CAC224D2A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Settings2 : ICoreWebView2Settings
{
    [DispId(1610743808)]
    string UserAgent
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.LPWStr)]
        set;
    }

    void _VtblGap1_18();
}
