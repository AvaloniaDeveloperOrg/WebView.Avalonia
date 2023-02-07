using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2EnvironmentOptions
{
    private class RawOptions : ICoreWebView2EnvironmentOptions, ICoreWebView2EnvironmentOptions2
    {
        public string AdditionalBrowserArguments { get; set; }

        public string Language { get; set; }

        public string TargetCompatibleBrowserVersion { get; set; }

        public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }

        public int ExclusiveUserDataFolderAccess { get; set; }

        public RawOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount)
        {
            AdditionalBrowserArguments = additionalBrowserArguments;
            Language = language;
            TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
            AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
        }
    }

    internal ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptionsValue;

    internal ICoreWebView2EnvironmentOptions2 _nativeICoreWebView2EnvironmentOptions2Value;

    internal object _rawNative;

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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2EnvironmentOptions2Value;
        }
        set
        {
            _nativeICoreWebView2EnvironmentOptions2Value = value;
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

    public CoreWebView2EnvironmentOptions(string additionalBrowserArguments = null, string language = null, string targetCompatibleBrowserVersion = null, bool allowSingleSignOnUsingOSPrimaryAccount = false)
    {
        targetCompatibleBrowserVersion = BrowserInfo.PRODUCT_VERSION;
        _nativeICoreWebView2EnvironmentOptions2 = (ICoreWebView2EnvironmentOptions2)(_nativeICoreWebView2EnvironmentOptions = new RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount));
    }

    internal CoreWebView2EnvironmentOptions(object rawCoreWebView2EnvironmentOptions)
    {
        _rawNative = rawCoreWebView2EnvironmentOptions;
    }
}
