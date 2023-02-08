using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateKeyPressedEventArgs : EventArgs
{
    internal ICoreWebView2PrivateKeyPressedEventArgs _nativeICoreWebView2PrivateKeyPressedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2PrivateKeyPressedEventArgs _nativeICoreWebView2PrivateKeyPressedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2PrivateKeyPressedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2PrivateKeyPressedEventArgsValue = (ICoreWebView2PrivateKeyPressedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2PrivateKeyPressedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2PrivateKeyPressedEventArgsValue = value;
        }
    }

    internal CoreWebView2KeyEventKind KeyEventKind
    {
        get
        {
            try
            {
                return (CoreWebView2KeyEventKind)_nativeICoreWebView2PrivateKeyPressedEventArgs.KeyEventKind;
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

    internal uint VirtualKey
    {
        get
        {
            try
            {
                return _nativeICoreWebView2PrivateKeyPressedEventArgs.VirtualKey;
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

    internal int KeyEventLParam
    {
        get
        {
            try
            {
                return _nativeICoreWebView2PrivateKeyPressedEventArgs.KeyEventLParam;
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

    internal CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
    {
        get
        {
            try
            {
                return new CoreWebView2PhysicalKeyStatus(_nativeICoreWebView2PrivateKeyPressedEventArgs.PhysicalKeyStatus);
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

    internal bool Handled
    {
        get
        {
            try
            {
                return _nativeICoreWebView2PrivateKeyPressedEventArgs.Handled != 0;
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
                _nativeICoreWebView2PrivateKeyPressedEventArgs.Handled = (value ? 1 : 0);
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

    internal CoreWebView2PrivateKeyPressedEventArgs(object rawCoreWebView2PrivateKeyPressedEventArgs)
    {
        _rawNative = rawCoreWebView2PrivateKeyPressedEventArgs;
    }
}
