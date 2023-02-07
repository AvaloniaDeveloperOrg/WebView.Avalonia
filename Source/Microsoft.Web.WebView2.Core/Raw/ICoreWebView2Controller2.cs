namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("C979903E-D4CA-4228-92EB-47EE3FA96EAB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Controller2 : ICoreWebView2Controller
{
    [DispId(1610743808)]
    COREWEBVIEW2_COLOR DefaultBackgroundColor
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    void _VtblGap1_23();
}
