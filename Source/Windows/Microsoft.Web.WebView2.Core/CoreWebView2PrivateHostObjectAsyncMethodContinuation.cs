using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateHostObjectAsyncMethodContinuation
{
    internal ICoreWebView2PrivateHostObjectAsyncMethodContinuation _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue;

    internal object _rawNative;

    internal ICoreWebView2PrivateHostObjectAsyncMethodContinuation _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation
    {
        get
        {
            if (_nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue == null)
            {
                try
                {
                    _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue = (ICoreWebView2PrivateHostObjectAsyncMethodContinuation)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectAsyncMethodContinuation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue;
        }
        set
        {
            _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuationValue = value;
        }
    }

    internal CoreWebView2PrivateHostObjectAsyncMethodContinuation(object rawCoreWebView2PrivateHostObjectAsyncMethodContinuation)
    {
        _rawNative = rawCoreWebView2PrivateHostObjectAsyncMethodContinuation;
    }

    internal void Invoke(int errorCode, object result)
    {
        try
        {
            ICoreWebView2PrivateHostObjectAsyncMethodContinuation nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation = _nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation;
            object result2 = result;
            nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation.Invoke(errorCode, ref result2);
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
