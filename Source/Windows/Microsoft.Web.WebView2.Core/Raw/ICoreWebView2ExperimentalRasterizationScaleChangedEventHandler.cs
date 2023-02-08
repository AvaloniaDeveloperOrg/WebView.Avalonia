namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("51560BE0-0AD4-4157-90CF-E6DAD638D8AA")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalRasterizationScaleChangedEventHandler
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    void Invoke([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalController sender, [In][MarshalAs(UnmanagedType.IUnknown)] object args);
}
