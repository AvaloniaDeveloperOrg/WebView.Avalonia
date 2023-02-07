using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2AcceleratorKeyPressedEventArgs : EventArgs
{
	internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;

	internal object _rawNative;

	internal ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgs
	{
		get
		{
			if (_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue == null)
			{
				try
				{
					_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = (ICoreWebView2AcceleratorKeyPressedEventArgs)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;
		}
		set
		{
			_nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = value;
		}
	}

	public CoreWebView2KeyEventKind KeyEventKind
	{
		get
		{
			try
			{
				return (CoreWebView2KeyEventKind)_nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventKind;
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

	public uint VirtualKey
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.VirtualKey;
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

	public int KeyEventLParam
	{
		get
		{
			try
			{
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam;
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

	public CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
	{
		get
		{
			try
			{
				return new CoreWebView2PhysicalKeyStatus(_nativeICoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus);
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
				return _nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled != 0;
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
				_nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled = (value ? 1 : 0);
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

	internal CoreWebView2AcceleratorKeyPressedEventArgs(object rawCoreWebView2AcceleratorKeyPressedEventArgs)
	{
		_rawNative = rawCoreWebView2AcceleratorKeyPressedEventArgs;
	}
}
