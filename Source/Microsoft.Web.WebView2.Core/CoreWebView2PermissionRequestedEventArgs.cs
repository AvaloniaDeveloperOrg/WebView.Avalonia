using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2PermissionRequestedEventArgs : EventArgs
{
	internal ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgsValue;

	internal ICoreWebView2PermissionRequestedEventArgs2 _nativeICoreWebView2PermissionRequestedEventArgs2Value;

	internal ICoreWebView2ExperimentalPermissionRequestedEventArgs3 _nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3Value;

	internal object _rawNative;

	internal ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2PermissionRequestedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2PermissionRequestedEventArgsValue = (ICoreWebView2PermissionRequestedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionRequestedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2PermissionRequestedEventArgsValue = value;
		}
	}

	internal ICoreWebView2PermissionRequestedEventArgs2 _nativeICoreWebView2PermissionRequestedEventArgs2
	{
		get
		{
			if (_nativeICoreWebView2PermissionRequestedEventArgs2Value == null)
			{
				try
				{
					_nativeICoreWebView2PermissionRequestedEventArgs2Value = (ICoreWebView2PermissionRequestedEventArgs2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PermissionRequestedEventArgs2Value;
		}
		set
		{
			_nativeICoreWebView2PermissionRequestedEventArgs2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalPermissionRequestedEventArgs3 _nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3Value = (ICoreWebView2ExperimentalPermissionRequestedEventArgs3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalPermissionRequestedEventArgs3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3Value = value;
		}
	}

	public string Uri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs.Uri;
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

	public CoreWebView2PermissionKind PermissionKind
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionKind)_nativeICoreWebView2PermissionRequestedEventArgs.PermissionKind;
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
				return _nativeICoreWebView2PermissionRequestedEventArgs.IsUserInitiated != 0;
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

	public CoreWebView2PermissionState State
	{
		get
		{
			try
			{
				return (CoreWebView2PermissionState)_nativeICoreWebView2PermissionRequestedEventArgs.State;
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
				_nativeICoreWebView2PermissionRequestedEventArgs.State = (COREWEBVIEW2_PERMISSION_STATE)value;
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

	public bool Handled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PermissionRequestedEventArgs2.Handled != 0;
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
				_nativeICoreWebView2PermissionRequestedEventArgs2.Handled = (value ? 1 : 0);
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

	public bool SavesInProfile
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3.SavesInProfile != 0;
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
				_nativeICoreWebView2ExperimentalPermissionRequestedEventArgs3.SavesInProfile = (value ? 1 : 0);
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

	internal CoreWebView2PermissionRequestedEventArgs(object rawCoreWebView2PermissionRequestedEventArgs)
	{
		_rawNative = rawCoreWebView2PermissionRequestedEventArgs;
	}

	public CoreWebView2Deferral GetDeferral()
	{
		try
		{
			return new CoreWebView2Deferral(_nativeICoreWebView2PermissionRequestedEventArgs.GetDeferral());
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
