using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2NewWindowRequestedEventArgs : EventArgs
{
    internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgsValue;

    internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2Value;

    internal ICoreWebView2ExperimentalNewWindowRequestedEventArgs _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2NewWindowRequestedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2NewWindowRequestedEventArgsValue = (ICoreWebView2NewWindowRequestedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2NewWindowRequestedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2NewWindowRequestedEventArgsValue = value;
        }
    }

    internal ICoreWebView2NewWindowRequestedEventArgs2 _nativeICoreWebView2NewWindowRequestedEventArgs2
    {
        get
        {
            if (_nativeICoreWebView2NewWindowRequestedEventArgs2Value == null)
            {
                try
                {
                    _nativeICoreWebView2NewWindowRequestedEventArgs2Value = (ICoreWebView2NewWindowRequestedEventArgs2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2NewWindowRequestedEventArgs2Value;
        }
        set
        {
            _nativeICoreWebView2NewWindowRequestedEventArgs2Value = value;
        }
    }

    internal ICoreWebView2ExperimentalNewWindowRequestedEventArgs _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalNewWindowRequestedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgsValue = (ICoreWebView2ExperimentalNewWindowRequestedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalNewWindowRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgsValue = value;
        }
    }

    public string Uri
    {
        get
        {
            try
            {
                return _nativeICoreWebView2NewWindowRequestedEventArgs.Uri;
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

    public CoreWebView2 NewWindow
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow == null) ? null : new CoreWebView2(_nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow);
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
                _nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow = value._nativeICoreWebView2;
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

    public bool Handled
    {
        get
        {
            try
            {
                return _nativeICoreWebView2NewWindowRequestedEventArgs.Handled != 0;
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
                _nativeICoreWebView2NewWindowRequestedEventArgs.Handled = (value ? 1 : 0);
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
                return _nativeICoreWebView2NewWindowRequestedEventArgs.IsUserInitiated != 0;
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

    public CoreWebView2WindowFeatures WindowFeatures
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures == null) ? null : new CoreWebView2WindowFeatures(_nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures);
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

    public string Name
    {
        get
        {
            try
            {
                try
                {
                    return _nativeICoreWebView2NewWindowRequestedEventArgs2.Name;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalNewWindowRequestedEventArgs.Name;
                }
            }
            catch (InvalidCastException ex2)
            {
                if (ex2.HResult == -2147467262)
                {
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex2);
                }
                throw ex2;
            }
            catch (COMException ex3)
            {
                if (ex3.HResult == -2147019873)
                {
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex3);
                }
                throw ex3;
            }
        }
    }

    internal CoreWebView2NewWindowRequestedEventArgs(object rawCoreWebView2NewWindowRequestedEventArgs)
    {
        _rawNative = rawCoreWebView2NewWindowRequestedEventArgs;
    }

    public CoreWebView2Deferral GetDeferral()
    {
        try
        {
            return new CoreWebView2Deferral(_nativeICoreWebView2NewWindowRequestedEventArgs.GetDeferral());
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
