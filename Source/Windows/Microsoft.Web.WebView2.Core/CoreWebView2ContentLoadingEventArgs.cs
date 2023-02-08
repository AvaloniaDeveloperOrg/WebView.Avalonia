using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ContentLoadingEventArgs : EventArgs
{
    internal ICoreWebView2ContentLoadingEventArgs _nativeICoreWebView2ContentLoadingEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2ContentLoadingEventArgs _nativeICoreWebView2ContentLoadingEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ContentLoadingEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ContentLoadingEventArgsValue = (ICoreWebView2ContentLoadingEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ContentLoadingEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ContentLoadingEventArgsValue = value;
        }
    }

    public bool IsErrorPage
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ContentLoadingEventArgs.IsErrorPage != 0;
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
                return _nativeICoreWebView2ContentLoadingEventArgs.NavigationId;
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

    internal CoreWebView2ContentLoadingEventArgs(object rawCoreWebView2ContentLoadingEventArgs)
    {
        _rawNative = rawCoreWebView2ContentLoadingEventArgs;
    }
}
