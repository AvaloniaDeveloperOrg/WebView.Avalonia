namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("F1131A5E-9BA9-11EB-A8B3-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Frame
{
    [DispId(1610678272)]
    string Name
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_NameChanged([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNameChangedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_NameChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void AddHostObjectToScriptWithOrigins([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.Struct)] ref object @object, [In] uint originsCount, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 2)] string[] origins);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void RemoveHostObjectFromScript([In][MarshalAs(UnmanagedType.LPWStr)] string name);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void add_Destroyed([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDestroyedEventHandler eventHandler, out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void remove_Destroyed([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall)]
    int IsDestroyed();
}
