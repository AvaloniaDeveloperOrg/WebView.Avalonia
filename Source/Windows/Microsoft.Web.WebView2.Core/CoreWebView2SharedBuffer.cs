using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2SharedBuffer : IDisposable
{
	internal class WebView2SharedBufferSafeHandle : SafeHandle
	{
		protected CoreWebView2SharedBuffer _shared_buffer;

		public override bool IsInvalid
		{
			get
			{
				if (!base.IsClosed && _shared_buffer != null)
				{
					return _shared_buffer.UnsafeFileMappingHandle == IntPtr.Zero;
				}
				return true;
			}
		}

		public WebView2SharedBufferSafeHandle(CoreWebView2SharedBuffer shared_buffer)
			: base(IntPtr.Zero, ownsHandle: false)
		{
			IntPtr unsafeFileMappingHandle = shared_buffer.UnsafeFileMappingHandle;
			if (unsafeFileMappingHandle != IntPtr.Zero)
			{
				SetHandle(unsafeFileMappingHandle);
				_shared_buffer = shared_buffer;
			}
		}

		protected override bool ReleaseHandle()
		{
			_shared_buffer = null;
			return true;
		}
	}

	private bool _disposed;

	private WebView2SharedBufferSafeHandle _safeFileMappingHandle;

	internal ICoreWebView2ExperimentalSharedBuffer _nativeICoreWebView2ExperimentalSharedBufferValue;

	internal object _rawNative;

	internal IntPtr UnsafeFileMappingHandle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalSharedBuffer.FileMappingHandle;
			}
			catch (Exception)
			{
				return IntPtr.Zero;
			}
		}
	}

	public SafeHandle FileMappingHandle
	{
		get
		{
			if (!_disposed && _safeFileMappingHandle == null)
			{
				_safeFileMappingHandle = new WebView2SharedBufferSafeHandle(this);
			}
			return _safeFileMappingHandle;
		}
	}

	internal ICoreWebView2ExperimentalSharedBuffer _nativeICoreWebView2ExperimentalSharedBuffer
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSharedBufferValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSharedBufferValue = (ICoreWebView2ExperimentalSharedBuffer)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSharedBuffer.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSharedBufferValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSharedBufferValue = value;
		}
	}

	public ulong Size
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalSharedBuffer.Size;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	public IntPtr Buffer
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalSharedBuffer.Buffer;
			}
			catch (InvalidCastException ex)
			{
				if (ex.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
				}
				throw ex;
			}
			catch (COMException ex2)
			{
				if (ex2.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
				}
				throw ex2;
			}
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			_disposed = true;
			Close();
			if (disposing && _safeFileMappingHandle != null)
			{
				_safeFileMappingHandle.SetHandleAsInvalid();
				_safeFileMappingHandle = null;
			}
		}
	}

	internal CoreWebView2SharedBuffer(object rawCoreWebView2SharedBuffer)
	{
		_rawNative = rawCoreWebView2SharedBuffer;
	}

	public Stream OpenStream()
	{
		try
		{
			return COMDotNetTypeConverter.StreamCOMToNet(_nativeICoreWebView2ExperimentalSharedBuffer.OpenStream());
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}

	public void Close()
	{
		try
		{
			_nativeICoreWebView2ExperimentalSharedBuffer.Close();
		}
		catch (InvalidCastException ex)
		{
			if (ex.HResult == -2147467262)
			{
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
			}
			throw ex;
		}
		catch (COMException ex2)
		{
			if (ex2.HResult == -2147019873)
			{
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
			}
			throw ex2;
		}
	}
}
