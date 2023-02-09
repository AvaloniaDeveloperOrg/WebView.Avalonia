namespace CefSharp.Core.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_base_scoped_t
{
    internal UIntPtr _size;
    internal IntPtr _del;

    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
#if !DEBUG
    [SuppressUnmanagedCodeSecurity]
#endif
    public delegate void del_delegate(cef_base_ref_counted_t* self);
}
