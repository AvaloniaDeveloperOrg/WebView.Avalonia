namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("97D418D5-A426-4E49-A151-E1A10F327D9E")]
[TypeIdentifier]
public interface ICoreWebView2Controller4 : ICoreWebView2Controller3
{
    [DispId(1610874880)]
    int AllowExternalDrop
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    void _VtblGap1_33();
}
