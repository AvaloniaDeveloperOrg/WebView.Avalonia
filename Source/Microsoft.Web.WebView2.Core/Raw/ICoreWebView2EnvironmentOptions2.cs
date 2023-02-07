namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("FF85C98A-1BA7-4A6B-90C8-2B752C89E9E2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2EnvironmentOptions2
{
    [DispId(1610678272)]
    int ExclusiveUserDataFolderAccess
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }
}
