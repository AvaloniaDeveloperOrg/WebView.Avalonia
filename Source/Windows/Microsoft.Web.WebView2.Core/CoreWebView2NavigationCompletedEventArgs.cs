using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2NavigationCompletedEventArgs : EventArgs
{
	internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgsValue;

	internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2Value;

	internal object _rawNative;

	internal ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NavigationCompletedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NavigationCompletedEventArgsValue = (ICoreWebView2NavigationCompletedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationCompletedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NavigationCompletedEventArgsValue = value;
		}
	}

	internal ICoreWebView2NavigationCompletedEventArgs2 _nativeICoreWebView2NavigationCompletedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2NavigationCompletedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2NavigationCompletedEventArgs2Value = (ICoreWebView2NavigationCompletedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationCompletedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2NavigationCompletedEventArgs2Value = value;
		}
	}

	public bool IsSuccess
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationCompletedEventArgs.IsSuccess != 0;
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

	public CoreWebView2WebErrorStatus WebErrorStatus
	{
		get
		{
			try
			{
				return (CoreWebView2WebErrorStatus)_nativeICoreWebView2NavigationCompletedEventArgs.WebErrorStatus;
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

	public ulong NavigationId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationCompletedEventArgs.NavigationId;
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

	public int HttpStatusCode
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationCompletedEventArgs2.HttpStatusCode;
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

	internal CoreWebView2NavigationCompletedEventArgs(object rawCoreWebView2NavigationCompletedEventArgs)
	{
		_rawNative = rawCoreWebView2NavigationCompletedEventArgs;
	}
}
