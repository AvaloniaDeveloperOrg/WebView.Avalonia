using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2PrintSettings
{
	internal ICoreWebView2PrintSettings _nativeICoreWebView2PrintSettingsValue;

	internal ICoreWebView2PrintSettings2 _nativeICoreWebView2PrintSettings2Value;

	internal ICoreWebView2ExperimentalPrintSettings2 _nativeICoreWebView2ExperimentalPrintSettings2Value;

	internal object _rawNative;

	internal ICoreWebView2PrintSettings _nativeICoreWebView2PrintSettings
	{
		get
		{
			if (_nativeICoreWebView2PrintSettingsValue == null)
			{
				try
				{
					_nativeICoreWebView2PrintSettingsValue = (ICoreWebView2PrintSettings)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrintSettings.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrintSettingsValue;
		}
		set
		{
			_nativeICoreWebView2PrintSettingsValue = value;
		}
	}

	internal ICoreWebView2PrintSettings2 _nativeICoreWebView2PrintSettings2
	{
		get
		{
			if (_nativeICoreWebView2PrintSettings2Value == null)
			{
				try
				{
					_nativeICoreWebView2PrintSettings2Value = (ICoreWebView2PrintSettings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrintSettings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrintSettings2Value;
		}
		set
		{
			_nativeICoreWebView2PrintSettings2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalPrintSettings2 _nativeICoreWebView2ExperimentalPrintSettings2
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalPrintSettings2Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalPrintSettings2Value = (ICoreWebView2ExperimentalPrintSettings2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalPrintSettings2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalPrintSettings2Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalPrintSettings2Value = value;
		}
	}

	public CoreWebView2PrintOrientation Orientation
	{
		get
		{
			try
			{
				return (CoreWebView2PrintOrientation)_nativeICoreWebView2PrintSettings.Orientation;
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
				_nativeICoreWebView2PrintSettings.Orientation = (COREWEBVIEW2_PRINT_ORIENTATION)value;
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

	public double ScaleFactor
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ScaleFactor;
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
				_nativeICoreWebView2PrintSettings.ScaleFactor = value;
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

	public double PageWidth
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.PageWidth;
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
				_nativeICoreWebView2PrintSettings.PageWidth = value;
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

	public double PageHeight
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.PageHeight;
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
				_nativeICoreWebView2PrintSettings.PageHeight = value;
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

	public double MarginTop
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginTop;
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
				_nativeICoreWebView2PrintSettings.MarginTop = value;
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

	public double MarginBottom
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginBottom;
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
				_nativeICoreWebView2PrintSettings.MarginBottom = value;
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

	public double MarginLeft
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginLeft;
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
				_nativeICoreWebView2PrintSettings.MarginLeft = value;
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

	public double MarginRight
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.MarginRight;
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
				_nativeICoreWebView2PrintSettings.MarginRight = value;
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

	public bool ShouldPrintBackgrounds
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintBackgrounds != 0;
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
				_nativeICoreWebView2PrintSettings.ShouldPrintBackgrounds = (value ? 1 : 0);
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

	public bool ShouldPrintSelectionOnly
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintSelectionOnly != 0;
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
				_nativeICoreWebView2PrintSettings.ShouldPrintSelectionOnly = (value ? 1 : 0);
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

	public bool ShouldPrintHeaderAndFooter
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.ShouldPrintHeaderAndFooter != 0;
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
				_nativeICoreWebView2PrintSettings.ShouldPrintHeaderAndFooter = (value ? 1 : 0);
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

	public string HeaderTitle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.HeaderTitle;
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
				_nativeICoreWebView2PrintSettings.HeaderTitle = value;
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

	public string FooterUri
	{
		get
		{
			try
			{
				return _nativeICoreWebView2PrintSettings.FooterUri;
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
				_nativeICoreWebView2PrintSettings.FooterUri = value;
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

	public string PageRanges
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2PrintSettings2.PageRanges;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalPrintSettings2.PageRanges;
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
					_nativeICoreWebView2PrintSettings2.PageRanges = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.PageRanges = value;
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

	public int PagesPerSide
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2PrintSettings2.PagesPerSide;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalPrintSettings2.PagesPerSide;
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
					_nativeICoreWebView2PrintSettings2.PagesPerSide = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.PagesPerSide = value;
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

	public int Copies
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2PrintSettings2.Copies;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalPrintSettings2.Copies;
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
					_nativeICoreWebView2PrintSettings2.Copies = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.Copies = value;
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

	public CoreWebView2PrintCollation Collation
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2PrintCollation)_nativeICoreWebView2PrintSettings2.Collation;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2PrintCollation)_nativeICoreWebView2ExperimentalPrintSettings2.Collation;
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
					_nativeICoreWebView2PrintSettings2.Collation = (COREWEBVIEW2_PRINT_COLLATION)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.Collation = (COREWEBVIEW2_PRINT_COLLATION)value;
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

	public CoreWebView2PrintColorMode ColorMode
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2PrintColorMode)_nativeICoreWebView2PrintSettings2.ColorMode;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2PrintColorMode)_nativeICoreWebView2ExperimentalPrintSettings2.ColorMode;
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
					_nativeICoreWebView2PrintSettings2.ColorMode = (COREWEBVIEW2_PRINT_COLOR_MODE)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.ColorMode = (COREWEBVIEW2_PRINT_COLOR_MODE)value;
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

	public CoreWebView2PrintDuplex Duplex
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2PrintDuplex)_nativeICoreWebView2PrintSettings2.Duplex;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2PrintDuplex)_nativeICoreWebView2ExperimentalPrintSettings2.Duplex;
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
					_nativeICoreWebView2PrintSettings2.Duplex = (COREWEBVIEW2_PRINT_DUPLEX)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.Duplex = (COREWEBVIEW2_PRINT_DUPLEX)value;
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

	public CoreWebView2PrintMediaSize MediaSize
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2PrintMediaSize)_nativeICoreWebView2PrintSettings2.MediaSize;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2PrintMediaSize)_nativeICoreWebView2ExperimentalPrintSettings2.MediaSize;
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
					_nativeICoreWebView2PrintSettings2.MediaSize = (COREWEBVIEW2_PRINT_MEDIA_SIZE)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.MediaSize = (COREWEBVIEW2_PRINT_MEDIA_SIZE)value;
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

	public string PrinterName
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2PrintSettings2.PrinterName;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2ExperimentalPrintSettings2.PrinterName;
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
					_nativeICoreWebView2PrintSettings2.PrinterName = value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalPrintSettings2.PrinterName = value;
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

	internal CoreWebView2PrintSettings(object rawCoreWebView2PrintSettings)
	{
		_rawNative = rawCoreWebView2PrintSettings;
	}
}
