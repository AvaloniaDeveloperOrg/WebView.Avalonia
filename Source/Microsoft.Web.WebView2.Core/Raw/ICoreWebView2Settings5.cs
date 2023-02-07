namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("183E7052-1D03-43A0-AB99-98E043B66B39")]
[TypeIdentifier]
public interface ICoreWebView2Settings5 : ICoreWebView2Settings4
{
    [DispId(1610940416)]
    int IsPinchZoomEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    void _VtblGap1_26();
}
