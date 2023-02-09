//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core.Interop;

[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
[SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
internal unsafe struct cef_browser_process_handler_t
{
    internal cef_base_ref_counted_t _base;
    internal IntPtr _on_context_initialized;
    internal IntPtr _on_before_child_process_launch;
    internal IntPtr _on_schedule_message_pump_work;
    internal IntPtr _get_default_client;
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void add_ref_delegate(cef_browser_process_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int release_delegate(cef_browser_process_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int has_one_ref_delegate(cef_browser_process_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate int has_at_least_one_ref_delegate(cef_browser_process_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void on_context_initialized_delegate(cef_browser_process_handler_t* self);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void on_before_child_process_launch_delegate(cef_browser_process_handler_t* self, cef_command_line_t* command_line);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate void on_schedule_message_pump_work_delegate(cef_browser_process_handler_t* self, long delay_ms);
    
    [UnmanagedFunctionPointer(libcef.CEF_CALLAPI)]
    #if !DEBUG
    [SuppressUnmanagedCodeSecurity]
    #endif
    internal delegate cef_client_t* get_default_client_delegate(cef_browser_process_handler_t* self);
    
    private static int _sizeof;
    
    static cef_browser_process_handler_t()
    {
        _sizeof = Marshal.SizeOf(typeof(cef_browser_process_handler_t));
    }
    
    internal static cef_browser_process_handler_t* Alloc()
    {
        var ptr = (cef_browser_process_handler_t*)Marshal.AllocHGlobal(_sizeof);
        *ptr = new cef_browser_process_handler_t();
        ptr->_base._size = (UIntPtr)_sizeof;
        return ptr;
    }
    
    internal static void Free(cef_browser_process_handler_t* ptr)
    {
        Marshal.FreeHGlobal((IntPtr)ptr);
    }
    
}
