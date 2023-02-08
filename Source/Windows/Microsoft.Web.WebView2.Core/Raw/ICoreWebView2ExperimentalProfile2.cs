namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("EE9E58ED-807B-4648-9171-8C0922EFE071")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalProfile2
{
    [DispId(1610678272)]
    COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
