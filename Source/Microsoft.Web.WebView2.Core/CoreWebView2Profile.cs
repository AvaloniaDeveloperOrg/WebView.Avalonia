using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Profile
{
    internal ICoreWebView2Profile _nativeICoreWebView2ProfileValue;

    internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2Value;

    internal object _rawNative;

    internal ICoreWebView2Profile _nativeICoreWebView2Profile
    {
        get
        {
            if (_nativeICoreWebView2ProfileValue == null)
            {
                try
                {
                    _nativeICoreWebView2ProfileValue = (ICoreWebView2Profile)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ProfileValue;
        }
        set
        {
            _nativeICoreWebView2ProfileValue = value;
        }
    }

    internal ICoreWebView2Profile2 _nativeICoreWebView2Profile2
    {
        get
        {
            if (_nativeICoreWebView2Profile2Value == null)
            {
                try
                {
                    _nativeICoreWebView2Profile2Value = (ICoreWebView2Profile2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Profile2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Profile2Value;
        }
        set
        {
            _nativeICoreWebView2Profile2Value = value;
        }
    }

    public string ProfileName
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Profile.ProfileName;
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

    public bool IsInPrivateModeEnabled
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Profile.IsInPrivateModeEnabled != 0;
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

    public string ProfilePath
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Profile.ProfilePath;
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

    public string DefaultDownloadFolderPath
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Profile.DefaultDownloadFolderPath;
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
                _nativeICoreWebView2Profile.DefaultDownloadFolderPath = value;
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

    public CoreWebView2PreferredColorScheme PreferredColorScheme
    {
        get
        {
            try
            {
                return (CoreWebView2PreferredColorScheme)_nativeICoreWebView2Profile.PreferredColorScheme;
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
                _nativeICoreWebView2Profile.PreferredColorScheme = (COREWEBVIEW2_PREFERRED_COLOR_SCHEME)value;
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

    public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTime startTime, DateTime endTime)
    {
        CoreWebView2ClearBrowsingDataCompletedHandler handler;
        try
        {
            double startTime2 = new DateTimeOffset(startTime).ToUnixTimeSeconds();
            double endTime2 = new DateTimeOffset(endTime).ToUnixTimeSeconds();
            handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
            _nativeICoreWebView2Profile2.ClearBrowsingDataInTimeRange((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, startTime2, endTime2, handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
    }

    public async Task ClearBrowsingDataAsync()
    {
        CoreWebView2ClearBrowsingDataCompletedHandler handler;
        try
        {
            handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
            _nativeICoreWebView2Profile2.ClearBrowsingDataAll(handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
    }

    internal CoreWebView2Profile(object rawCoreWebView2Profile)
    {
        _rawNative = rawCoreWebView2Profile;
    }

    public async Task ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds)
    {
        CoreWebView2ClearBrowsingDataCompletedHandler handler;
        try
        {
            handler = new CoreWebView2ClearBrowsingDataCompletedHandler();
            _nativeICoreWebView2Profile2.ClearBrowsingData((COREWEBVIEW2_BROWSING_DATA_KINDS)dataKinds, handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
    }
}
