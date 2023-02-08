namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("11CB3ACD-9BC8-43B8-83BF-F40753714F87")]
[TypeIdentifier]
public interface ICoreWebView2Settings6 : ICoreWebView2Settings5
{
    void _VtblGap1_28();

    [DispId(1611005952)]
    int IsSwipeNavigationEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
