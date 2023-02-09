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
    
    // Role: PROXY
    public sealed unsafe partial class CefServer : IDisposable
    {
        internal static CefServer FromNative(cef_server_t* ptr)
        {
            return new CefServer(ptr);
        }
        
        internal static CefServer FromNativeOrNull(cef_server_t* ptr)
        {
            if (ptr == null) return null;
            return new CefServer(ptr);
        }
        
        private cef_server_t* _self;
        private int _disposed = 0;
        
        private CefServer(cef_server_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefServer()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_server_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_server_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_server_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_server_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_server_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
