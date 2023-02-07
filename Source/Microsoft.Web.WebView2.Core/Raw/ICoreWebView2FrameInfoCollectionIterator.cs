namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1BF89E2D-1B2B-4629-B28F-05099B41BB03")]
[TypeIdentifier]
public interface ICoreWebView2FrameInfoCollectionIterator
{
    [DispId(1610678272)]
    int HasCurrent
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2FrameInfo GetCurrent();

    [MethodImpl(MethodImplOptions.InternalCall)]
    int MoveNext();
}
