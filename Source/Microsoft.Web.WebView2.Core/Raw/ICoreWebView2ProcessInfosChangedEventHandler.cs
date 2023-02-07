namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F4AF0C39-44B9-40E9-8B11-0484CFB9E0A1")]
[TypeIdentifier]
public interface ICoreWebView2ProcessInfosChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
