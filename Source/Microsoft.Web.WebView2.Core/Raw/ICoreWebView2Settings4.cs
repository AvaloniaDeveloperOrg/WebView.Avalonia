namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("CB56846C-4168-4D53-B04F-03B6D6796FF2")]
[TypeIdentifier]
public interface ICoreWebView2Settings4 : ICoreWebView2Settings3
{
    void _VtblGap1_22();

    [DispId(1610874880)]
    int IsPasswordAutosaveEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610874882)]
    int IsGeneralAutofillEnabled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
