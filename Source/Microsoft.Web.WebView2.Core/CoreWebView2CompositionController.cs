using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2CompositionController
{
    internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionControllerValue;

    internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2Value;

    internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3Value;

    internal object _rawNative;

    private EventRegistrationToken _cursorChangedToken;

    private EventHandler<object> cursorChanged;

    internal ICoreWebView2CompositionController _nativeICoreWebView2CompositionController
    {
        get
        {
            if (_nativeICoreWebView2CompositionControllerValue == null)
            {
                try
                {
                    _nativeICoreWebView2CompositionControllerValue = (ICoreWebView2CompositionController)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2CompositionControllerValue;
        }
        set
        {
            _nativeICoreWebView2CompositionControllerValue = value;
        }
    }

    internal ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2
    {
        get
        {
            if (_nativeICoreWebView2CompositionController2Value == null)
            {
                try
                {
                    _nativeICoreWebView2CompositionController2Value = (ICoreWebView2CompositionController2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2CompositionController2Value;
        }
        set
        {
            _nativeICoreWebView2CompositionController2Value = value;
        }
    }

    internal ICoreWebView2CompositionController3 _nativeICoreWebView2CompositionController3
    {
        get
        {
            if (_nativeICoreWebView2CompositionController3Value == null)
            {
                try
                {
                    _nativeICoreWebView2CompositionController3Value = (ICoreWebView2CompositionController3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2CompositionController3Value;
        }
        set
        {
            _nativeICoreWebView2CompositionController3Value = value;
        }
    }

    public object RootVisualTarget
    {
        get
        {
            try
            {
                return _nativeICoreWebView2CompositionController.RootVisualTarget;
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
                _nativeICoreWebView2CompositionController.RootVisualTarget = value;
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

    public IntPtr Cursor
    {
        get
        {
            try
            {
                return _nativeICoreWebView2CompositionController.Cursor;
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

    public uint SystemCursorId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2CompositionController.SystemCursorId;
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

    public event EventHandler<object> CursorChanged
    {
        add
        {
            if (cursorChanged == null)
            {
                try
                {
                    _nativeICoreWebView2CompositionController.add_CursorChanged(new CoreWebView2CursorChangedEventHandler(OnCursorChanged), out _cursorChangedToken);
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
            cursorChanged = (EventHandler<object>)Delegate.Combine(cursorChanged, value);
        }
        remove
        {
            cursorChanged = (EventHandler<object>)Delegate.Remove(cursorChanged, value);
            if (cursorChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2CompositionController.remove_CursorChanged(_cursorChangedToken);
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

    internal CoreWebView2CompositionController(object rawCoreWebView2CompositionController)
    {
        _rawNative = rawCoreWebView2CompositionController;
    }

    internal void OnCursorChanged(object args)
    {
        cursorChanged?.Invoke(this, args);
    }

    public void SendMouseInput(CoreWebView2MouseEventKind eventKind, CoreWebView2MouseEventVirtualKeys virtualKeys, uint mouseData, Point point)
    {
        try
        {
            _nativeICoreWebView2CompositionController.SendMouseInput((COREWEBVIEW2_MOUSE_EVENT_KIND)eventKind, (COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS)virtualKeys, mouseData, COMDotNetTypeConverter.PointNetToCOM(point));
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

    public void SendPointerInput(CoreWebView2PointerEventKind eventKind, CoreWebView2PointerInfo pointerInfo)
    {
        try
        {
            _nativeICoreWebView2CompositionController.SendPointerInput((COREWEBVIEW2_POINTER_EVENT_KIND)eventKind, pointerInfo._nativeICoreWebView2PointerInfo);
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

    public void DragLeave()
    {
        try
        {
            _nativeICoreWebView2CompositionController3.DragLeave();
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
