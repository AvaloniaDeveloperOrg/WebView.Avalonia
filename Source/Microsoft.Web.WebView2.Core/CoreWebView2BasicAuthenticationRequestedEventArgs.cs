using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2BasicAuthenticationRequestedEventArgs : EventArgs
{
	internal ICoreWebView2BasicAuthenticationRequestedEventArgs _nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue;

	internal object _rawNative;

	internal ICoreWebView2BasicAuthenticationRequestedEventArgs _nativeICoreWebView2BasicAuthenticationRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue = (ICoreWebView2BasicAuthenticationRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BasicAuthenticationRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2BasicAuthenticationRequestedEventArgsValue = value;
		}
	}

	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Uri;
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

	public string Challenge
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Challenge;
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

	public CoreWebView2BasicAuthenticationResponse Response
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Response == null) ? null : new CoreWebView2BasicAuthenticationResponse(_nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Response);
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

	public bool Cancel
	{
		get
		{
			try
			{
				return _nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Cancel != 0;
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
		set
		{
			try
			{
				_nativeICoreWebView2BasicAuthenticationRequestedEventArgs.Cancel = (value ? 1 : 0);
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

	internal CoreWebView2BasicAuthenticationRequestedEventArgs(object rawCoreWebView2BasicAuthenticationRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2BasicAuthenticationRequestedEventArgs;
	}

	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2BasicAuthenticationRequestedEventArgs.GetDeferral());
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
