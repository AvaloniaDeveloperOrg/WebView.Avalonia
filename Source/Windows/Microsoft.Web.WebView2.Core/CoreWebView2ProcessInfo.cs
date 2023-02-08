using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ProcessInfo
{
	internal ICoreWebView2ProcessInfo _nativeICoreWebView2ProcessInfoValue;

	internal object _rawNative;

	internal ICoreWebView2ProcessInfo _nativeICoreWebView2ProcessInfo
	{
		get
		{
			if (_nativeICoreWebView2ProcessInfoValue == null)
			{
				try
				{
					_nativeICoreWebView2ProcessInfoValue = (ICoreWebView2ProcessInfo)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ProcessInfoValue;
		}
		set
		{
			_nativeICoreWebView2ProcessInfoValue = value;
		}
	}

	public int ProcessId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ProcessInfo.ProcessId;
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

	public CoreWebView2ProcessKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2ProcessKind)_nativeICoreWebView2ProcessInfo.Kind;
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

	internal CoreWebView2ProcessInfo(object rawCoreWebView2ProcessInfo)
	{
		_rawNative = rawCoreWebView2ProcessInfo;
	}
}
