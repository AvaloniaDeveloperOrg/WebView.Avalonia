using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2HttpResponseHeaders : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
    internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeadersValue;

    internal object _rawNative;

    internal ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeaders
    {
        get
        {
            if (_nativeICoreWebView2HttpResponseHeadersValue == null)
            {
                try
                {
                    _nativeICoreWebView2HttpResponseHeadersValue = (ICoreWebView2HttpResponseHeaders)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2HttpResponseHeadersValue;
        }
        set
        {
            _nativeICoreWebView2HttpResponseHeadersValue = value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public CoreWebView2HttpHeadersCollectionIterator GetEnumerator()
    {
        return GetIterator();
    }

    internal CoreWebView2HttpResponseHeaders(object rawCoreWebView2HttpResponseHeaders)
    {
        _rawNative = rawCoreWebView2HttpResponseHeaders;
    }

    public void AppendHeader(string name, string value)
    {
        try
        {
            _nativeICoreWebView2HttpResponseHeaders.AppendHeader(name, value);
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

    public bool Contains(string name)
    {
        try
        {
            return _nativeICoreWebView2HttpResponseHeaders.Contains(name) != 0;
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

    public string GetHeader(string name)
    {
        try
        {
            return _nativeICoreWebView2HttpResponseHeaders.GetHeader(name);
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

    public CoreWebView2HttpHeadersCollectionIterator GetHeaders(string name)
    {
        try
        {
            return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpResponseHeaders.GetHeaders(name));
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

    public CoreWebView2HttpHeadersCollectionIterator GetIterator()
    {
        try
        {
            return new CoreWebView2HttpHeadersCollectionIterator(_nativeICoreWebView2HttpResponseHeaders.GetIterator());
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
