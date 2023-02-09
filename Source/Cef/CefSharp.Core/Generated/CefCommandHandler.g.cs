//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
using CefSharp.Core.Interop;

namespace CefSharp.Core;

// Role: HANDLER
public abstract unsafe partial class CefCommandHandler
{
    private static Dictionary<IntPtr, CefCommandHandler> _roots = new Dictionary<IntPtr, CefCommandHandler>();
    
    private int _refct;
    private cef_command_handler_t* _self;
    
    private cef_command_handler_t.add_ref_delegate _ds0;
    private cef_command_handler_t.release_delegate _ds1;
    private cef_command_handler_t.has_one_ref_delegate _ds2;
    private cef_command_handler_t.has_at_least_one_ref_delegate _ds3;
    private cef_command_handler_t.on_chrome_command_delegate _ds4;
    
    protected CefCommandHandler()
    {
        _self = cef_command_handler_t.Alloc();
    
        _ds0 = new cef_command_handler_t.add_ref_delegate(add_ref);
        _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
        _ds1 = new cef_command_handler_t.release_delegate(release);
        _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
        _ds2 = new cef_command_handler_t.has_one_ref_delegate(has_one_ref);
        _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
        _ds3 = new cef_command_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
        _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
        _ds4 = new cef_command_handler_t.on_chrome_command_delegate(on_chrome_command);
        _self->_on_chrome_command = Marshal.GetFunctionPointerForDelegate(_ds4);
    }
    
    ~CefCommandHandler()
    {
        Dispose(false);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (_self != null)
        {
            cef_command_handler_t.Free(_self);
            _self = null;
        }
    }
    
    private void add_ref(cef_command_handler_t* self)
    {
        if (Interlocked.Increment(ref _refct) == 1)
        {
            lock (_roots) { _roots.Add((IntPtr)_self, this); }
        }
    }
    
    private int release(cef_command_handler_t* self)
    {
        if (Interlocked.Decrement(ref _refct) == 0)
        {
            lock (_roots) { _roots.Remove((IntPtr)_self); }
            return 1;
        }
        return 0;
    }
    
    private int has_one_ref(cef_command_handler_t* self)
    {
        return _refct == 1 ? 1 : 0;
    }
    
    private int has_at_least_one_ref(cef_command_handler_t* self)
    {
        return _refct != 0 ? 1 : 0;
    }
    
    internal cef_command_handler_t* ToNative()
    {
        add_ref(_self);
        return _self;
    }
    
    [Conditional("DEBUG")]
    private void CheckSelf(cef_command_handler_t* self)
    {
        if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
    }
    
}
