namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("1F00663F-AF8C-4782-9CDD-DD01C52E34CB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2BrowserProcessExitedEventArgs
{
    [DispId(1610678272)]
    COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    uint BrowserProcessId
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }
}
