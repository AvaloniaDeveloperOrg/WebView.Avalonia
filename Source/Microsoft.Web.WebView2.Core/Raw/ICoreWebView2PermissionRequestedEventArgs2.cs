namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("74D7127F-9DE6-4200-8734-42D6FB4FF741")]
[TypeIdentifier]
public interface ICoreWebView2PermissionRequestedEventArgs2 : ICoreWebView2PermissionRequestedEventArgs
{
    [DispId(1610743808)]
    int Handled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    void _VtblGap1_6();
}
