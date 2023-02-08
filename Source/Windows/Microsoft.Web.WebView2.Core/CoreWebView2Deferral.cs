using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Deferral : IDisposable
{
	private bool disposed;

	private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, ownsHandle: true);

	internal ICoreWebView2Deferral _nativeICoreWebView2DeferralValue;

	internal object _rawNative;

	internal ICoreWebView2Deferral _nativeICoreWebView2Deferral
	{
		get
		{
			if (_nativeICoreWebView2DeferralValue == null)
			{
				try
				{
					_nativeICoreWebView2DeferralValue = (ICoreWebView2Deferral)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2DeferralValue;
		}
		set
		{
			_nativeICoreWebView2DeferralValue = value;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				handle.Dispose();
			}
			Complete();
			disposed = true;
		}
	}

	internal CoreWebView2Deferral(object rawCoreWebView2Deferral)
	{
		_rawNative = rawCoreWebView2Deferral;
	}

	public void Complete()
	{
		try
		{
			_nativeICoreWebView2Deferral.Complete();
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
