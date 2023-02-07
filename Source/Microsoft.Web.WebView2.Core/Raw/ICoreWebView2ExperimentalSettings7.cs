namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D667D3A7-C1B7-479F-8833-DB7547DF6687")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalSettings7
{
    [DispId(1610678272)]
    int IsReputationCheckingRequired
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
