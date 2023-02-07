namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0CE15963-3698-4DF7-9399-71ED6CDD8C9F")]
[TypeIdentifier]
public interface ICoreWebView2ExperimentalExecuteScriptResult
{
    [DispId(1610678272)]
    int Succeeded
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678273)]
    string ResultAsJson
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    void TryGetResultAsString([MarshalAs(UnmanagedType.LPWStr)] out string stringResult, out int value);

    [DispId(1610678275)]
    ICoreWebView2ExperimentalScriptException Exception
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }
}
