namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("93186BDD-0499-4939-AD58-FBC5ED97AE11")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment
{
    [DispId(1610678272)]
    string FailureReportFolderPath
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
