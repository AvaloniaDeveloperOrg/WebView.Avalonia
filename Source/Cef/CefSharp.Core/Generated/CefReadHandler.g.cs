//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefSharp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using CefSharp.Core.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefReadHandler
    {
        private static Dictionary<IntPtr, CefReadHandler> _roots = new Dictionary<IntPtr, CefReadHandler>();
        
        private int _refct;
        private cef_read_handler_t* _self;
        
        private cef_read_handler_t.add_ref_delegate _ds0;
        private cef_read_handler_t.release_delegate _ds1;
        private cef_read_handler_t.has_one_ref_delegate _ds2;
        private cef_read_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_read_handler_t.read_delegate _ds4;
        private cef_read_handler_t.seek_delegate _ds5;
        private cef_read_handler_t.tell_delegate _ds6;
        private cef_read_handler_t.eof_delegate _ds7;
        private cef_read_handler_t.may_block_delegate _ds8;
        
        protected CefReadHandler()
        {
            _self = cef_read_handler_t.Alloc();
        
            _ds0 = new cef_read_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_read_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_read_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_read_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_read_handler_t.read_delegate(read);
            _self->_read = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_read_handler_t.seek_delegate(seek);
            _self->_seek = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_read_handler_t.tell_delegate(tell);
            _self->_tell = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_read_handler_t.eof_delegate(eof);
            _self->_eof = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_read_handler_t.may_block_delegate(may_block);
            _self->_may_block = Marshal.GetFunctionPointerForDelegate(_ds8);
        }
        
        ~CefReadHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_read_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_read_handler_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_read_handler_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_read_handler_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_read_handler_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_read_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_read_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
