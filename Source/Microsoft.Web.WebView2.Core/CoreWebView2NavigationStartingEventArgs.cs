using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2NavigationStartingEventArgs : EventArgs
{
    internal ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgsValue;

    internal ICoreWebView2NavigationStartingEventArgs2 _nativeICoreWebView2NavigationStartingEventArgs2Value;

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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2NavigationStartingEventArgs2Value;
        }
        set
        {
            _nativeICoreWebView2NavigationStartingEventArgs2Value = value;
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
                return _nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors;
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
                _nativeICoreWebView2NavigationStartingEventArgs2.AdditionalAllowedFrameAncestors = value;
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
