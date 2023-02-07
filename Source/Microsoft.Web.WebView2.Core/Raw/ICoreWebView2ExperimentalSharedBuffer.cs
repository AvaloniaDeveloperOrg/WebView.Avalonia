namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("B747A495-0C6F-449E-97B8-2F81E9D6AB43")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSharedBuffer
{
    [DispId(1610678272)]
    ulong Size
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    IntPtr Buffer
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    IStream OpenStream();

    [DispId(1610678275)]
    IntPtr FileMappingHandle
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void Close();
}
