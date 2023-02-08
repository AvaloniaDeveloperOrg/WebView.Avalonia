namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("083CB0D7-E464-4108-807E-80AE4EAA3B28")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalEnvironment5
{
    [DispId(1610678272)]
    string UserDataFolder
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }
}
