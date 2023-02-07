namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("43C22296-3BBD-43A4-9C00-5C0DF6DD29A2")]
[TypeIdentifier]
public interface ICoreWebView2Environment7 : ICoreWebView2Environment6
{
    void _VtblGap1_12();

    [DispId(1611071488)]
    string UserDataFolder
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
