using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateContextMenuItem
{
	internal ICoreWebView2PrivateContextMenuItem _nativeICoreWebView2PrivateContextMenuItemValue;

	internal object _rawNative;

	internal ICoreWebView2PrivateContextMenuItem _nativeICoreWebView2PrivateContextMenuItem
	{
		get
		{
			if (_nativeICoreWebView2PrivateContextMenuItemValue == null)
			{
				try
				{
					_nativeICoreWebView2PrivateContextMenuItemValue = (ICoreWebView2PrivateContextMenuItem)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateContextMenuItem.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrivateContextMenuItemValue;
		}
		set
		{
			_nativeICoreWebView2PrivateContextMenuItemValue = value;
		}
	}

	internal CoreWebView2PrivateContextMenuItem(object rawCoreWebView2PrivateContextMenuItem)
	{
		_rawNative = rawCoreWebView2PrivateContextMenuItem;
	}

	internal void ReportSelected()
	{
		try
		{
			_nativeICoreWebView2PrivateContextMenuItem.ReportSelected();
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

	internal int IsCustom()
	{
		try
		{
			return _nativeICoreWebView2PrivateContextMenuItem.IsCustom();
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

	internal void SetHasReadIconStream(bool has_read_icon_stream)
	{
		try
		{
			_nativeICoreWebView2PrivateContextMenuItem.SetHasReadIconStream(has_read_icon_stream ? 1 : 0);
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

	internal int HasReadIconStream()
	{
		try
		{
			return _nativeICoreWebView2PrivateContextMenuItem.HasReadIconStream();
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
