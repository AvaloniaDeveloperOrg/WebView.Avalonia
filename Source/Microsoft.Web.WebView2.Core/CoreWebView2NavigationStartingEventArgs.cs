using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2NavigationStartingEventArgs : EventArgs
{
	internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgsValue;

	internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2Value;

	internal ICoreWebView2ExperimentalNavigationStartingEventArgs2 _nativeICoreWebView2ExperimentalNavigationStartingEventArgs2Value;

	internal ICoreWebView2ExperimentalNavigationStartingEventArgs _nativeICoreWebView2ExperimentalNavigationStartingEventArgsValue;

	internal object _rawNative;

	internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2NavigationStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgsValue = (ICoreWebView2NavigationStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2NavigationStartingEventArgsValue = value;
		}
	}

	internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2NavigationStartingEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgs2Value = (ICoreWebView2NavigationStartingEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2NavigationStartingEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2NavigationStartingEventArgs2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalNavigationStartingEventArgs2 _nativeICoreWebView2ExperimentalNavigationStartingEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalNavigationStartingEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalNavigationStartingEventArgs2Value = (ICoreWebView2ExperimentalNavigationStartingEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalNavigationStartingEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalNavigationStartingEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalNavigationStartingEventArgs2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalNavigationStartingEventArgs _nativeICoreWebView2ExperimentalNavigationStartingEventArgs
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalNavigationStartingEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalNavigationStartingEventArgsValue = (ICoreWebView2ExperimentalNavigationStartingEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalNavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalNavigationStartingEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalNavigationStartingEventArgsValue = value;
		}
	}

	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.Uri;
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

	public bool IsUserInitiated
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.IsUserInitiated != 0;
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

	public bool IsRedirected
	{
		get
		{
			try
			{
				return _nativeICoreWebView2NavigationStartingEventArgs.IsRedirected != 0;
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

	public CoreWebView2HttpRequestHeaders RequestHeaders
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders == null) ? null : new CoreWebView2HttpRequestHeaders(_nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders);
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
				return _nativeICoreWebView2NavigationStartingEventArgs.Cancel != 0;
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
				_nativeICoreWebView2NavigationStartingEventArgs.Cancel = (value ? 1 : 0);
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
				return _nativeICoreWebView2NavigationStartingEventArgs.NavigationId;
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

	public string AdditionalAllowedFrameAncestors
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalNavigationStartingEventArgs.AdditionalAllowedFrameAncestors;
				}
			}
			catch (InvalidCastException ex2)
			{
				if (ex2.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
				}
				throw ex2;
			}
			catch (COMException ex3)
			{
				if (ex3.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
				}
				throw ex3;
			}
		}
		set
		{
			try
			{
				try
				{
					_nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalNavigationStartingEventArgs.AdditionalAllowedFrameAncestors = value;
				}
			}
			catch (InvalidCastException ex2)
			{
				if (ex2.HResult == -2147467262)
				{
					throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
				}
				throw ex2;
			}
			catch (COMException ex3)
			{
				if (ex3.HResult == -2147019873)
				{
					throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
				}
				throw ex3;
			}
		}
	}

	public CoreWebView2NavigationKind NavigationKind
	{
		get
		{
			try
			{
				return (CoreWebView2NavigationKind)_nativeICoreWebView2ExperimentalNavigationStartingEventArgs2.NavigationKind;
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

	internal CoreWebView2NavigationStartingEventArgs(object rawCoreWebView2NavigationStartingEventArgs)
	{
		_rawNative = rawCoreWebView2NavigationStartingEventArgs;
	}
}
