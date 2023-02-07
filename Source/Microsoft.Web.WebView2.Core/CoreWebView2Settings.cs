using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Settings
{
	internal ICoreWebView2Settings _nativeICoreWebView2SettingsValue;

	internal ICoreWebView2Settings2 _nativeICoreWebView2Settings2Value;

	internal ICoreWebView2Settings3 _nativeICoreWebView2Settings3Value;

	internal ICoreWebView2Settings4 _nativeICoreWebView2Settings4Value;

	internal ICoreWebView2Settings5 _nativeICoreWebView2Settings5Value;

	internal ICoreWebView2Settings6 _nativeICoreWebView2Settings6Value;

	internal ICoreWebView2Settings7 _nativeICoreWebView2Settings7Value;

	internal ICoreWebView2ExperimentalSettings7 _nativeICoreWebView2ExperimentalSettings7Value;

	internal ICoreWebView2ExperimentalSettings6 _nativeICoreWebView2ExperimentalSettings6Value;

	internal ICoreWebView2ExperimentalSettings5 _nativeICoreWebView2ExperimentalSettings5Value;

	internal ICoreWebView2ExperimentalSettings4 _nativeICoreWebView2ExperimentalSettings4Value;

	internal ICoreWebView2ExperimentalSettings3 _nativeICoreWebView2ExperimentalSettings3Value;

	internal ICoreWebView2ExperimentalSettings2 _nativeICoreWebView2ExperimentalSettings2Value;

	internal ICoreWebView2ExperimentalSettings _nativeICoreWebView2ExperimentalSettingsValue;

	internal object _rawNative;

	internal ICoreWebView2Settings _nativeICoreWebView2Settings
	{
		get
		{
			if (_nativeICoreWebView2SettingsValue == null)
			{
				try
				{
					_nativeICoreWebView2SettingsValue = (ICoreWebView2Settings)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2SettingsValue;
		}
		set
		{
			_nativeICoreWebView2SettingsValue = value;
		}
	}

	internal ICoreWebView2Settings2 _nativeICoreWebView2Settings2
	{
		get
		{
			if (_nativeICoreWebView2Settings2Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings2Value = (ICoreWebView2Settings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings2Value;
		}
		set
		{
			_nativeICoreWebView2Settings2Value = value;
		}
	}

	internal ICoreWebView2Settings3 _nativeICoreWebView2Settings3
	{
		get
		{
			if (_nativeICoreWebView2Settings3Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings3Value = (ICoreWebView2Settings3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings3Value;
		}
		set
		{
			_nativeICoreWebView2Settings3Value = value;
		}
	}

	internal ICoreWebView2Settings4 _nativeICoreWebView2Settings4
	{
		get
		{
			if (_nativeICoreWebView2Settings4Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings4Value = (ICoreWebView2Settings4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings4Value;
		}
		set
		{
			_nativeICoreWebView2Settings4Value = value;
		}
	}

	internal ICoreWebView2Settings5 _nativeICoreWebView2Settings5
	{
		get
		{
			if (_nativeICoreWebView2Settings5Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings5Value = (ICoreWebView2Settings5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings5Value;
		}
		set
		{
			_nativeICoreWebView2Settings5Value = value;
		}
	}

	internal ICoreWebView2Settings6 _nativeICoreWebView2Settings6
	{
		get
		{
			if (_nativeICoreWebView2Settings6Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings6Value = (ICoreWebView2Settings6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings6Value;
		}
		set
		{
			_nativeICoreWebView2Settings6Value = value;
		}
	}

	internal ICoreWebView2Settings7 _nativeICoreWebView2Settings7
	{
		get
		{
			if (_nativeICoreWebView2Settings7Value == null)
			{
				try
				{
					_nativeICoreWebView2Settings7Value = (ICoreWebView2Settings7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Settings7Value;
		}
		set
		{
			_nativeICoreWebView2Settings7Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings7 _nativeICoreWebView2ExperimentalSettings7
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings7Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings7Value = (ICoreWebView2ExperimentalSettings7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings7Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings7Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings6 _nativeICoreWebView2ExperimentalSettings6
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings6Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings6Value = (ICoreWebView2ExperimentalSettings6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings6Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings6Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings5 _nativeICoreWebView2ExperimentalSettings5
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings5Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings5Value = (ICoreWebView2ExperimentalSettings5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings5Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings5Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings4 _nativeICoreWebView2ExperimentalSettings4
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings4Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings4Value = (ICoreWebView2ExperimentalSettings4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings4Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings4Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings3 _nativeICoreWebView2ExperimentalSettings3
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings3Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings3Value = (ICoreWebView2ExperimentalSettings3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings3Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings3Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings2 _nativeICoreWebView2ExperimentalSettings2
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettings2Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettings2Value = (ICoreWebView2ExperimentalSettings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettings2Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettings2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalSettings _nativeICoreWebView2ExperimentalSettings
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalSettingsValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalSettingsValue = (ICoreWebView2ExperimentalSettings)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalSettings.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalSettingsValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalSettingsValue = value;
		}
	}

	public bool IsScriptEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsScriptEnabled != 0;
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
				_nativeICoreWebView2Settings.IsScriptEnabled = (value ? 1 : 0);
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

	public bool IsWebMessageEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsWebMessageEnabled != 0;
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
				_nativeICoreWebView2Settings.IsWebMessageEnabled = (value ? 1 : 0);
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

	public bool AreDefaultScriptDialogsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDefaultScriptDialogsEnabled != 0;
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
				_nativeICoreWebView2Settings.AreDefaultScriptDialogsEnabled = (value ? 1 : 0);
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

	public bool IsStatusBarEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsStatusBarEnabled != 0;
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
				_nativeICoreWebView2Settings.IsStatusBarEnabled = (value ? 1 : 0);
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

	public bool AreDevToolsEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDevToolsEnabled != 0;
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
				_nativeICoreWebView2Settings.AreDevToolsEnabled = (value ? 1 : 0);
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

	public bool AreDefaultContextMenusEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreDefaultContextMenusEnabled != 0;
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
				_nativeICoreWebView2Settings.AreDefaultContextMenusEnabled = (value ? 1 : 0);
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

	public bool AreHostObjectsAllowed
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.AreHostObjectsAllowed != 0;
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
				_nativeICoreWebView2Settings.AreHostObjectsAllowed = (value ? 1 : 0);
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

	public bool IsZoomControlEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsZoomControlEnabled != 0;
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
				_nativeICoreWebView2Settings.IsZoomControlEnabled = (value ? 1 : 0);
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

	public bool IsBuiltInErrorPageEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings.IsBuiltInErrorPageEnabled != 0;
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
				_nativeICoreWebView2Settings.IsBuiltInErrorPageEnabled = (value ? 1 : 0);
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

	public string UserAgent
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2Settings2.UserAgent;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalSettings.UserAgent;
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
					_nativeICoreWebView2Settings2.UserAgent = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings.UserAgent = value;
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

	public bool AreBrowserAcceleratorKeysEnabled
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2Settings3.AreBrowserAcceleratorKeysEnabled != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalSettings2.AreBrowserAcceleratorKeysEnabled != 0;
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
					_nativeICoreWebView2Settings3.AreBrowserAcceleratorKeysEnabled = (value ? 1 : 0);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings2.AreBrowserAcceleratorKeysEnabled = (value ? 1 : 0);
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

	public bool IsPasswordAutosaveEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Settings4.IsPasswordAutosaveEnabled != 0;
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
				_nativeICoreWebView2Settings4.IsPasswordAutosaveEnabled = (value ? 1 : 0);
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

	public bool IsGeneralAutofillEnabled
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2Settings4.IsGeneralAutofillEnabled != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalSettings3.IsGeneralAutofillEnabled != 0;
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
					_nativeICoreWebView2Settings4.IsGeneralAutofillEnabled = (value ? 1 : 0);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings3.IsGeneralAutofillEnabled = (value ? 1 : 0);
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

	public bool IsPinchZoomEnabled
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2Settings5.IsPinchZoomEnabled != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalSettings4.IsPinchZoomEnabled != 0;
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
					_nativeICoreWebView2Settings5.IsPinchZoomEnabled = (value ? 1 : 0);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings4.IsPinchZoomEnabled = (value ? 1 : 0);
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

	public bool IsSwipeNavigationEnabled
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2Settings6.IsSwipeNavigationEnabled != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalSettings5.IsSwipeNavigationEnabled != 0;
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
					_nativeICoreWebView2Settings6.IsSwipeNavigationEnabled = (value ? 1 : 0);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings5.IsSwipeNavigationEnabled = (value ? 1 : 0);
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

	public CoreWebView2PdfToolbarItems HiddenPdfToolbarItems
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2PdfToolbarItems)_nativeICoreWebView2Settings7.HiddenPdfToolbarItems;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2PdfToolbarItems)_nativeICoreWebView2ExperimentalSettings6.HiddenPdfToolbarItems;
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
					_nativeICoreWebView2Settings7.HiddenPdfToolbarItems = (COREWEBVIEW2_PDF_TOOLBAR_ITEMS)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalSettings6.HiddenPdfToolbarItems = (COREWEBVIEW2_PDF_TOOLBAR_ITEMS)value;
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

	public bool IsReputationCheckingRequired
	{
		get
		{
			try
			{
				return _nativeICoreWebView2ExperimentalSettings7.IsReputationCheckingRequired != 0;
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
				_nativeICoreWebView2ExperimentalSettings7.IsReputationCheckingRequired = (value ? 1 : 0);
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

	internal CoreWebView2Settings(object rawCoreWebView2Settings)
	{
		_rawNative = rawCoreWebView2Settings;
	}
}
