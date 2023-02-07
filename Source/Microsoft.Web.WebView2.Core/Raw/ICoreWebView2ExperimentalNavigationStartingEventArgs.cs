namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6B18B9FD-DE08-4F73-9B93-3ACA84EBC16F")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalNavigationStartingEventArgs
{
    [DispId(1610678272)]
    string AdditionalAllowedFrameAncestors
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.LPWStr)]
        set;
    }
}
