namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8F834154-D38E-4D90-AFFB-6800A7272839")]
[TypeIdentifier]
public interface ICoreWebView2FrameInfoCollection
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2FrameInfoCollectionIterator GetIterator();
}
