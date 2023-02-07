using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ContextMenuItem
{
	internal ICoreWebView2ContextMenuItem _nativeICoreWebView2ContextMenuItemValue;

	internal object _rawNative;

	private EventRegistrationToken _customItemSelectedToken;

	private EventHandler<object> customItemSelected;

	internal ICoreWebView2ContextMenuItem _nativeICoreWebView2ContextMenuItem
	{
		get
		{
			if (_nativeICoreWebView2ContextMenuItemValue == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuItemValue = (ICoreWebView2ContextMenuItem)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuItem.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ContextMenuItemValue;
		}
		set
		{
			_nativeICoreWebView2ContextMenuItemValue = value;
		}
	}

	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.Name;
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

	public string Label
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.Label;
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

	public int CommandId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.CommandId;
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

	public string ShortcutKeyDescription
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.ShortcutKeyDescription;
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

	public Stream Icon
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.StreamCOMToNet(_nativeICoreWebView2ContextMenuItem.Icon);
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

	public CoreWebView2ContextMenuItemKind Kind
	{
		get
		{
			try
			{
				return (CoreWebView2ContextMenuItemKind)_nativeICoreWebView2ContextMenuItem.Kind;
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

	public bool IsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.IsEnabled != 0;
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
				_nativeICoreWebView2ContextMenuItem.IsEnabled = (value ? 1 : 0);
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

	public bool IsChecked
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ContextMenuItem.IsChecked != 0;
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
				_nativeICoreWebView2ContextMenuItem.IsChecked = (value ? 1 : 0);
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

	public IList<CoreWebView2ContextMenuItem> Children
	{
		get
		{
			try
			{
				return COMDotNetTypeConverter.CoreWebView2ContextMenuItemCollectionCOMToNet(_nativeICoreWebView2ContextMenuItem.Children);
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

	public event EventHandler<object> CustomItemSelected
	{
		add
		{
			if (customItemSelected == null)
			{
				try
				{
					_nativeICoreWebView2ContextMenuItem.add_CustomItemSelected(new CoreWebView2CustomItemSelectedEventHandler(OnCustomItemSelected), out _customItemSelectedToken);
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
			customItemSelected = (EventHandler<object>)Delegate.Combine(customItemSelected, value);
		}
		remove
		{
			customItemSelected = (EventHandler<object>)Delegate.Remove(customItemSelected, value);
			if (customItemSelected != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2ContextMenuItem.remove_CustomItemSelected(_customItemSelectedToken);
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

	internal CoreWebView2ContextMenuItem(object rawCoreWebView2ContextMenuItem)
	{
		_rawNative = rawCoreWebView2ContextMenuItem;
	}

	internal void OnCustomItemSelected(object args)
	{
		customItemSelected?.Invoke(this, args);
	}
}
