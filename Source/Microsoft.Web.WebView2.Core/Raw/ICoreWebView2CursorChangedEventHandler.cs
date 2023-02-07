namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9DA43CCC-26E1-4DAD-B56C-D8961C94C571")]
[TypeIdentifier]
public interface ICoreWebView2CursorChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CompositionController sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
