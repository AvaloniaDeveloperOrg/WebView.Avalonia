namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("86825D04-196D-4D7E-A58B-F2178A51C390")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2PrivateContextMenuItem
{
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
    void ReportSelected();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
    int IsCustom();

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
    void SetHasReadIconStream([In] int has_read_icon_stream);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
    int HasReadIconStream();
}
