using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2WebResourceResponseView
{
    internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseViewValue;

    internal object _rawNative;

    internal ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseView
    {
        get
        {
            if (_nativeICoreWebView2WebResourceResponseViewValue == null)
            {
                try
                {
                    _nativeICoreWebView2WebResourceResponseViewValue = (ICoreWebView2WebResourceResponseView)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2WebResourceResponseViewValue;
        }
        set
        {
            _nativeICoreWebView2WebResourceResponseViewValue = value;
        }
    }

    public CoreWebView2HttpResponseHeaders Headers
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2WebResourceResponseView.Headers == null) ? null : new CoreWebView2HttpResponseHeaders(_nativeICoreWebView2WebResourceResponseView.Headers);
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

    public int StatusCode
    {
        get
        {
            try
            {
                return _nativeICoreWebView2WebResourceResponseView.StatusCode;
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

    public string ReasonPhrase
    {
        get
        {
            try
            {
                return _nativeICoreWebView2WebResourceResponseView.ReasonPhrase;
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

    internal CoreWebView2WebResourceResponseView(object rawCoreWebView2WebResourceResponseView)
    {
        _rawNative = rawCoreWebView2WebResourceResponseView;
    }

    public async Task<Stream> GetContentAsync()
    {
        CoreWebView2WebResourceResponseViewGetContentCompletedHandler handler;
        try
        {
            handler = new CoreWebView2WebResourceResponseViewGetContentCompletedHandler();
            _nativeICoreWebView2WebResourceResponseView.GetContent(handler);
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
        return handler.Content;
    }
}
