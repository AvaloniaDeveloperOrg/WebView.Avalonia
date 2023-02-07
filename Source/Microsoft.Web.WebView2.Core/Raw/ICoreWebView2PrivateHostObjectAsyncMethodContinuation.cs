namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("FF1BBF9A-37E0-45F8-88C5-9DF6B5DD5F4C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2PrivateHostObjectAsyncMethodContinuation
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Error)] int errorCode, [In][MarshalAs(UnmanagedType.Struct)] ref object result);
}
