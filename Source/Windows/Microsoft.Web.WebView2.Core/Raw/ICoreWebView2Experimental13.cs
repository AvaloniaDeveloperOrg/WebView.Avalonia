namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1A90E7B5-2E71-427B-8EA5-119C7088ED24")]
[TypeIdentifier]
public interface ICoreWebView2Experimental13
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_StatusBarTextChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2StatusBarTextChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_StatusBarTextChanged([In] EventRegistrationToken token);

    [DispId(1610678274)]
    string StatusBarText
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
