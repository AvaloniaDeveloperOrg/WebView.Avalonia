using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2UpdateRuntimeResult
{
	internal ICoreWebView2ExperimentalUpdateRuntimeResult _nativeICoreWebView2ExperimentalUpdateRuntimeResultValue;

	internal object _rawNative;

	internal ICoreWebView2ExperimentalUpdateRuntimeResult _nativeICoreWebView2ExperimentalUpdateRuntimeResult
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalUpdateRuntimeResultValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalUpdateRuntimeResultValue = (ICoreWebView2ExperimentalUpdateRuntimeResult)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalUpdateRuntimeResult.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalUpdateRuntimeResultValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalUpdateRuntimeResultValue = value;
		}
	}

	public CoreWebView2UpdateRuntimeStatus Status
	{
		get
		{
			try
			{
				return (CoreWebView2UpdateRuntimeStatus)_nativeICoreWebView2ExperimentalUpdateRuntimeResult.Status;
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

	public int ExtendedError
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalUpdateRuntimeResult.ExtendedError;
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

	internal CoreWebView2UpdateRuntimeResult(object rawCoreWebView2UpdateRuntimeResult)
	{
		_rawNative = rawCoreWebView2UpdateRuntimeResult;
	}
}
