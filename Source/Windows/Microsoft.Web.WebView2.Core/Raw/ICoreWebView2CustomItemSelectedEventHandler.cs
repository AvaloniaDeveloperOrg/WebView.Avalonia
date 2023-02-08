namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("49E1D0BC-FE9E-4481-B7C2-32324AA21998")]
[TypeIdentifier]
public interface ICoreWebView2CustomItemSelectedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuItem sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
