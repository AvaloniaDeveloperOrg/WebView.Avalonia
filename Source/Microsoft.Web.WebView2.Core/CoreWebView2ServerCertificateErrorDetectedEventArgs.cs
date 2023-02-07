using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ServerCertificateErrorDetectedEventArgs : EventArgs
{
    internal ICoreWebView2ServerCertificateErrorDetectedEventArgs _nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2ServerCertificateErrorDetectedEventArgs _nativeICoreWebView2ServerCertificateErrorDetectedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue = (ICoreWebView2ServerCertificateErrorDetectedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ServerCertificateErrorDetectedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ServerCertificateErrorDetectedEventArgsValue = value;
        }
    }

    public CoreWebView2WebErrorStatus ErrorStatus
    {
        get
        {
            try
            {
                return (CoreWebView2WebErrorStatus)_nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ErrorStatus;
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

    public string RequestUri
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.RequestUri;
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

    public CoreWebView2Certificate ServerCertificate
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ServerCertificate == null) ? null : new CoreWebView2Certificate(_nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.ServerCertificate);
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

    public CoreWebView2ServerCertificateErrorAction Action
    {
        get
        {
            try
            {
                return (CoreWebView2ServerCertificateErrorAction)_nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.Action;
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
                _nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.Action = (COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION)value;
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

    internal CoreWebView2ServerCertificateErrorDetectedEventArgs(object rawCoreWebView2ServerCertificateErrorDetectedEventArgs)
    {
        _rawNative = rawCoreWebView2ServerCertificateErrorDetectedEventArgs;
    }

    public CoreWebView2Deferral GetDeferral()
    {
        try
        {
            return new CoreWebView2Deferral(_nativeICoreWebView2ServerCertificateErrorDetectedEventArgs.GetDeferral());
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
