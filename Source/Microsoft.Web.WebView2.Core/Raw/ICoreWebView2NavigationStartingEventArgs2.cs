namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("9086BE93-91AA-472D-A7E0-579F2BA006AD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2NavigationStartingEventArgs2 : ICoreWebView2NavigationStartingEventArgs
{
    [DispId(1610743808)]
    string AdditionalAllowedFrameAncestors
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.LPWStr)]
        set;
    }

    void _VtblGap1_7();
}
