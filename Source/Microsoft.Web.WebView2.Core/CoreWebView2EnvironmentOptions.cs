using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2EnvironmentOptions
{
	private class RawOptions : ICoreWebView2EnvironmentOptions, ICoreWebView2EnvironmentOptions2, ICoreWebView2EnvironmentOptions3, ICoreWebView2EnvironmentOptions4, ICoreWebView2EnvironmentOptions5
	{
		public string AdditionalBrowserArguments { get; set; }

		public string Language { get; set; }

		public string TargetCompatibleBrowserVersion { get; set; }

		public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }

		public int ExclusiveUserDataFolderAccess { get; set; }

		public int IsCustomCrashReportingEnabled { get; set; }

		public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations { get; set; }

		public int EnableTrackingPrevention { get; set; } = 1;


		public void GetCustomSchemeRegistrations(out uint count, IntPtr registrationsPtr)
		{
			if (CustomSchemeRegistrations == null || CustomSchemeRegistrations.Count == 0)
			{
				count = 0u;
				return;
			}
			count = (uint)CustomSchemeRegistrations.Count;
			Marshal.SizeOf<IntPtr>();
			IntPtr intPtr = Marshal.AllocCoTaskMem((int)count * Marshal.SizeOf<IntPtr>());
			for (int i = 0; i < count; i++)
			{
				Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), CustomSchemeRegistrations[i].GetNative());
			}
			Marshal.WriteIntPtr(registrationsPtr, intPtr);
		}

		public void SetCustomSchemeRegistrations(uint count, ref ICoreWebView2CustomSchemeRegistration registration)
		{
			throw new NotImplementedException();
		}

		public RawOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations)
		{
			AdditionalBrowserArguments = additionalBrowserArguments;
			Language = language;
			TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
			AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
			CustomSchemeRegistrations = customSchemeRegistrations;
		}
	}

	internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptionsValue;

	internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2Value;

	internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3Value;

	internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4Value;

	internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5Value;

	internal object _rawNative;

	public List<CoreWebView2CustomSchemeRegistration> CustomSchemeRegistrations { get; }

	internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptions
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptionsValue == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptionsValue = (ICoreWebView2EnvironmentOptions)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptionsValue;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptionsValue = value;
		}
	}

	internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions2Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions2Value = (ICoreWebView2EnvironmentOptions2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions2Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions2Value = value;
		}
	}

	internal ICoreWebView2EnvironmentOptions3 _nativeICoreWebView2EnvironmentOptions3
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions3Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions3Value = (ICoreWebView2EnvironmentOptions3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions3Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions3Value = value;
		}
	}

	internal ICoreWebView2EnvironmentOptions4 _nativeICoreWebView2EnvironmentOptions4
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions4Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions4Value = (ICoreWebView2EnvironmentOptions4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions4Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions4Value = value;
		}
	}

	internal ICoreWebView2EnvironmentOptions5 _nativeICoreWebView2EnvironmentOptions5
	{
		get
		{
			if (_nativeICoreWebView2EnvironmentOptions5Value == null)
			{
				try
				{
					_nativeICoreWebView2EnvironmentOptions5Value = (ICoreWebView2EnvironmentOptions5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2EnvironmentOptions5Value;
		}
		set
		{
			_nativeICoreWebView2EnvironmentOptions5Value = value;
		}
	}

	public string AdditionalBrowserArguments
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments;
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
				_nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments = value;
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

	public string Language
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.Language;
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
				_nativeICoreWebView2EnvironmentOptions.Language = value;
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

	public string TargetCompatibleBrowserVersion
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion;
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
				_nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion = value;
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

	public bool AllowSingleSignOnUsingOSPrimaryAccount
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount != 0;
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
				_nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount = (value ? 1 : 0);
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

	public bool ExclusiveUserDataFolderAccess
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess != 0;
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
				_nativeICoreWebView2EnvironmentOptions2.ExclusiveUserDataFolderAccess = (value ? 1 : 0);
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

	public bool IsCustomCrashReportingEnabled
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled != 0;
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
				_nativeICoreWebView2EnvironmentOptions3.IsCustomCrashReportingEnabled = (value ? 1 : 0);
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

	public bool EnableTrackingPrevention
	{
		get
		{
			try
			{
				return _nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention != 0;
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
				_nativeICoreWebView2EnvironmentOptions5.EnableTrackingPrevention = (value ? 1 : 0);
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

	public CoreWebView2EnvironmentOptions(string additionalBrowserArguments = null, string language = null, string targetCompatibleBrowserVersion = null, bool allowSingleSignOnUsingOSPrimaryAccount = false, List<CoreWebView2CustomSchemeRegistration> customSchemeRegistrations = null)
	{
		targetCompatibleBrowserVersion = BrowserInfo.PRODUCT_VERSION;
		_nativeICoreWebView2EnvironmentOptions5 = (ICoreWebView2EnvironmentOptions5)(_nativeICoreWebView2EnvironmentOptions4 = (ICoreWebView2EnvironmentOptions4)(_nativeICoreWebView2EnvironmentOptions3 = (ICoreWebView2EnvironmentOptions3)(_nativeICoreWebView2EnvironmentOptions2 = (ICoreWebView2EnvironmentOptions2)(_nativeICoreWebView2EnvironmentOptions = new RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount, customSchemeRegistrations)))));
		CustomSchemeRegistrations = customSchemeRegistrations;
	}

	internal CoreWebView2EnvironmentOptions(object rawCoreWebView2EnvironmentOptions)
	{
		_rawNative = rawCoreWebView2EnvironmentOptions;
	}
}
