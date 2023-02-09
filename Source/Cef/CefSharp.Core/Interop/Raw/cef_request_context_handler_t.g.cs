//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
[SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
internal unsafe struct cef_request_context_handler_t
{
    internal cef_base_ref_counted_t _base;
    internal IntPtr _on_request_context_initialized;
    internal IntPtr _get_resource_request_handler;
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void add_ref_delegate(cef_request_context_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int release_delegate(cef_request_context_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int has_one_ref_delegate(cef_request_context_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int has_at_least_one_ref_delegate(cef_request_context_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void on_request_context_initialized_delegate(cef_request_context_handler_t* self, cef_request_context_t* request_context);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate cef_resource_request_handler_t* get_resource_request_handler_delegate(cef_request_context_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling);
    
    private static int _sizeof;
    
    static cef_request_context_handler_t()
    {
        _sizeof = Marshal.SizeOf(typeof(cef_request_context_handler_t));
    }
    
    internal static cef_request_context_handler_t* Alloc()
    {
        var ptr = (cef_request_context_handler_t*)Marshal.AllocHGlobal(_sizeof);
        *ptr = new cef_request_context_handler_t();
        ptr->_base._size = (UIntPtr)_sizeof;
        return ptr;
    }
    
    internal static void Free(cef_request_context_handler_t* ptr)
    {
        Marshal.FreeHGlobal((IntPtr)ptr);
    }
    
}
