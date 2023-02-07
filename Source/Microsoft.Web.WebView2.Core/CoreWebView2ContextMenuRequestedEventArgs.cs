using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ContextMenuRequestedEventArgs : EventArgs
{
    internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2ContextMenuRequestedEventArgs _nativeICoreWebView2ContextMenuRequestedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ContextMenuRequestedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ContextMenuRequestedEventArgsValue = (ICoreWebView2ContextMenuRequestedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContextMenuRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ContextMenuRequestedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ContextMenuRequestedEventArgsValue = value;
        }
    }

    public IList<CoreWebView2ContextMenuItem> MenuItems
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.CoreWebView2ContextMenuItemCollectionCOMToNet(_nativeICoreWebView2ContextMenuRequestedEventArgs.MenuItems);
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

    public CoreWebView2ContextMenuTarget ContextMenuTarget
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget == null) ? null : new CoreWebView2ContextMenuTarget(_nativeICoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget);
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

    public Point Location
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2ContextMenuRequestedEventArgs.Location);
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

    public int SelectedCommandId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId;
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
                _nativeICoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId = value;
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
                return _nativeICoreWebView2ContextMenuRequestedEventArgs.Handled != 0;
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
                _nativeICoreWebView2ContextMenuRequestedEventArgs.Handled = (value ? 1 : 0);
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

    internal CoreWebView2ContextMenuRequestedEventArgs(object rawCoreWebView2ContextMenuRequestedEventArgs)
    {
        _rawNative = rawCoreWebView2ContextMenuRequestedEventArgs;
    }

    public CoreWebView2Deferral GetDeferral()
    {
        try
        {
            return new CoreWebView2Deferral(_nativeICoreWebView2ContextMenuRequestedEventArgs.GetDeferral());
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
