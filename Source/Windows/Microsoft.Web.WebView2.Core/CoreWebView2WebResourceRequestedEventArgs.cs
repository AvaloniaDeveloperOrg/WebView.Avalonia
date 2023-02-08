using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2WebResourceRequestedEventArgs : EventArgs
{
    internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgsValue;

    internal ICoreWebView2ExperimentalWebResourceRequestedEventArgs _nativeICoreWebView2ExperimentalWebResourceRequestedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2WebResourceRequestedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2WebResourceRequestedEventArgsValue = (ICoreWebView2WebResourceRequestedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2WebResourceRequestedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2WebResourceRequestedEventArgsValue = value;
        }
    }

    internal ICoreWebView2ExperimentalWebResourceRequestedEventArgs _nativeICoreWebView2ExperimentalWebResourceRequestedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalWebResourceRequestedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalWebResourceRequestedEventArgsValue = (ICoreWebView2ExperimentalWebResourceRequestedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalWebResourceRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalWebResourceRequestedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ExperimentalWebResourceRequestedEventArgsValue = value;
        }
    }

    public CoreWebView2WebResourceRequest Request
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2WebResourceRequestedEventArgs.Request == null) ? null : new CoreWebView2WebResourceRequest(_nativeICoreWebView2WebResourceRequestedEventArgs.Request);
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

    public CoreWebView2WebResourceResponse Response
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2WebResourceRequestedEventArgs.Response == null) ? null : new CoreWebView2WebResourceResponse(_nativeICoreWebView2WebResourceRequestedEventArgs.Response);
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
                _nativeICoreWebView2WebResourceRequestedEventArgs.Response = value._nativeICoreWebView2WebResourceResponse;
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

    public CoreWebView2WebResourceContext ResourceContext
    {
        get
        {
            try
            {
                return (CoreWebView2WebResourceContext)_nativeICoreWebView2WebResourceRequestedEventArgs.ResourceContext;
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

    public CoreWebView2WebResourceRequestSourceKinds RequestedSourceKind
    {
        get
        {
            try
            {
                return (CoreWebView2WebResourceRequestSourceKinds)_nativeICoreWebView2ExperimentalWebResourceRequestedEventArgs.RequestedSourceKind;
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

    internal CoreWebView2WebResourceRequestedEventArgs(object rawCoreWebView2WebResourceRequestedEventArgs)
    {
        _rawNative = rawCoreWebView2WebResourceRequestedEventArgs;
    }

    public CoreWebView2Deferral GetDeferral()
    {
        try
        {
            return new CoreWebView2Deferral(_nativeICoreWebView2WebResourceRequestedEventArgs.GetDeferral());
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
