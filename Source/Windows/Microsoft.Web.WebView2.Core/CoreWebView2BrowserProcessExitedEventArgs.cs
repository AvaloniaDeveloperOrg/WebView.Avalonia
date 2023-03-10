using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2BrowserProcessExitedEventArgs : EventArgs
{
    internal ICoreWebView2BrowserProcessExitedEventArgs _nativeICoreWebView2BrowserProcessExitedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2BrowserProcessExitedEventArgs _nativeICoreWebView2BrowserProcessExitedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2BrowserProcessExitedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2BrowserProcessExitedEventArgsValue = (ICoreWebView2BrowserProcessExitedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BrowserProcessExitedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2BrowserProcessExitedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2BrowserProcessExitedEventArgsValue = value;
        }
    }

    public CoreWebView2BrowserProcessExitKind BrowserProcessExitKind
    {
        get
        {
            try
            {
                return (CoreWebView2BrowserProcessExitKind)_nativeICoreWebView2BrowserProcessExitedEventArgs.BrowserProcessExitKind;
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

    public uint BrowserProcessId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2BrowserProcessExitedEventArgs.BrowserProcessId;
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

    internal CoreWebView2BrowserProcessExitedEventArgs(object rawCoreWebView2BrowserProcessExitedEventArgs)
    {
        _rawNative = rawCoreWebView2BrowserProcessExitedEventArgs;
    }
}
