//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core.Interop; 

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
[SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
internal unsafe struct cef_scheme_registrar_t
{
    internal cef_base_scoped_t _base;
    internal IntPtr _add_custom_scheme;
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate void del_delegate(cef_scheme_registrar_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    private delegate int add_custom_scheme_delegate(cef_scheme_registrar_t* self, cef_string_t* scheme_name, int options);
    
    // Del
    private static IntPtr _p0;
    private static del_delegate _d0;
    
    public static void del(cef_scheme_registrar_t* self)
    {
        del_delegate d;
        var p = self->_base._del;
        if (p == _p0) { d = _d0; }
        else
        {
            d = (del_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(del_delegate));
            if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
        }
        d(self);
    }
    
    // AddCustomScheme
    private static IntPtr _p1;
    private static add_custom_scheme_delegate _d1;
    
    public static int add_custom_scheme(cef_scheme_registrar_t* self, cef_string_t* scheme_name, int options)
    {
        add_custom_scheme_delegate d;
        var p = self->_add_custom_scheme;
        if (p == _p1) { d = _d1; }
        else
        {
            d = (add_custom_scheme_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_custom_scheme_delegate));
            if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
        }
        return d(self, scheme_name, options);
    }
    
}
