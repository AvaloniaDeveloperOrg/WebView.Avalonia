using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2HttpHeadersCollectionIterator : IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
{
    private bool isInitialized;

    internal ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIteratorValue;

    internal object _rawNative;

    object IEnumerator.Current => Current;

    public KeyValuePair<string, string> Current
    {
        get
        {
            try
            {
                GetCurrentHeader(out var name, out var value);
                return new KeyValuePair<string, string>(name, value);
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    internal ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIterator
    {
        get
        {
            if (_nativeICoreWebView2HttpHeadersCollectionIteratorValue == null)
            {
                try
                {
                    _nativeICoreWebView2HttpHeadersCollectionIteratorValue = (ICoreWebView2HttpHeadersCollectionIterator)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2HttpHeadersCollectionIteratorValue;
        }
        set
        {
            _nativeICoreWebView2HttpHeadersCollectionIteratorValue = value;
        }
    }

    public bool HasCurrentHeader
    {
        get
        {
            try
            {
                return _nativeICoreWebView2HttpHeadersCollectionIterator.HasCurrentHeader != 0;
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

    public bool MoveNext()
    {
        if (isInitialized)
        {
            return _nativeICoreWebView2HttpHeadersCollectionIterator.MoveNext() != 0;
        }
        isInitialized = true;
        return HasCurrentHeader;
    }

    public void Reset()
    {
        throw new NotSupportedException();
    }

    public void Dispose()
    {
    }

    internal CoreWebView2HttpHeadersCollectionIterator(object rawCoreWebView2HttpHeadersCollectionIterator)
    {
        _rawNative = rawCoreWebView2HttpHeadersCollectionIterator;
    }

    private void GetCurrentHeader(out string name, out string value)
    {
        try
        {
            _nativeICoreWebView2HttpHeadersCollectionIterator.GetCurrentHeader(out name, out value);
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
