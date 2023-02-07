using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Controller
{
    private const string HostObjectHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";

    private CoreWebView2 _coreWebView2;

    internal ICoreWebView2Controller _nativeICoreWebView2ControllerValue;

    internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2Value;

    internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3Value;

    internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4Value;

    internal object _rawNative;

    private EventRegistrationToken _zoomFactorChangedToken;

    private EventHandler<object> zoomFactorChanged;

    private EventRegistrationToken _moveFocusRequestedToken;

    private EventHandler<CoreWebView2MoveFocusRequestedEventArgs> moveFocusRequested;

    private EventRegistrationToken _gotFocusToken;

    private EventHandler<object> gotFocus;

    private EventRegistrationToken _lostFocusToken;

    private EventHandler<object> lostFocus;

    private EventRegistrationToken _acceleratorKeyPressedToken;

    private EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> acceleratorKeyPressed;

    private EventRegistrationToken _rasterizationScaleChangedToken;

    private EventHandler<object> rasterizationScaleChanged;

    public CoreWebView2 CoreWebView2
    {
        get
        {
            if (_nativeICoreWebView2Controller.CoreWebView2 == null)
            {
                return null;
            }
            if (_coreWebView2 == null)
            {
                _coreWebView2 = new CoreWebView2(_nativeICoreWebView2Controller.CoreWebView2);
            }
            return _coreWebView2;
        }
    }

    internal ICoreWebView2Controller _nativeICoreWebView2Controller
    {
        get
        {
            if (_nativeICoreWebView2ControllerValue == null)
            {
                try
                {
                    _nativeICoreWebView2ControllerValue = (ICoreWebView2Controller)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ControllerValue;
        }
        set
        {
            _nativeICoreWebView2ControllerValue = value;
        }
    }

    internal ICoreWebView2Controller2 _nativeICoreWebView2Controller2
    {
        get
        {
            if (_nativeICoreWebView2Controller2Value == null)
            {
                try
                {
                    _nativeICoreWebView2Controller2Value = (ICoreWebView2Controller2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Controller2Value;
        }
        set
        {
            _nativeICoreWebView2Controller2Value = value;
        }
    }

    internal ICoreWebView2Controller3 _nativeICoreWebView2Controller3
    {
        get
        {
            if (_nativeICoreWebView2Controller3Value == null)
            {
                try
                {
                    _nativeICoreWebView2Controller3Value = (ICoreWebView2Controller3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Controller3Value;
        }
        set
        {
            _nativeICoreWebView2Controller3Value = value;
        }
    }

    internal ICoreWebView2Controller4 _nativeICoreWebView2Controller4
    {
        get
        {
            if (_nativeICoreWebView2Controller4Value == null)
            {
                try
                {
                    _nativeICoreWebView2Controller4Value = (ICoreWebView2Controller4)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Controller4Value;
        }
        set
        {
            _nativeICoreWebView2Controller4Value = value;
        }
    }

    public bool IsVisible
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller.IsVisible != 0;
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
                _nativeICoreWebView2Controller.IsVisible = (value ? 1 : 0);
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

    public Rectangle Bounds
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.RectangleCOMToNet(_nativeICoreWebView2Controller.Bounds);
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
                _nativeICoreWebView2Controller.Bounds = COMDotNetTypeConverter.RectangleNetToCOM(value);
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

    public double ZoomFactor
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller.ZoomFactor;
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
                _nativeICoreWebView2Controller.ZoomFactor = value;
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

    public IntPtr ParentWindow
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller.ParentWindow;
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
                _nativeICoreWebView2Controller.ParentWindow = value;
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

    public Color DefaultBackgroundColor
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.ColorCOMToNet(_nativeICoreWebView2Controller2.DefaultBackgroundColor);
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
                _nativeICoreWebView2Controller2.DefaultBackgroundColor = COMDotNetTypeConverter.ColorNetToCOM(value);
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

    public double RasterizationScale
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller3.RasterizationScale;
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
                _nativeICoreWebView2Controller3.RasterizationScale = value;
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

    public bool ShouldDetectMonitorScaleChanges
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0;
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
                _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
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

    public CoreWebView2BoundsMode BoundsMode
    {
        get
        {
            try
            {
                return (CoreWebView2BoundsMode)_nativeICoreWebView2Controller3.BoundsMode;
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
                _nativeICoreWebView2Controller3.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
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

    public bool AllowExternalDrop
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Controller4.AllowExternalDrop != 0;
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
                _nativeICoreWebView2Controller4.AllowExternalDrop = (value ? 1 : 0);
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

    public event EventHandler<object> ZoomFactorChanged
    {
        add
        {
            if (zoomFactorChanged == null)
            {
                try
                {
                    _nativeICoreWebView2Controller.add_ZoomFactorChanged(new CoreWebView2ZoomFactorChangedEventHandler(OnZoomFactorChanged), out _zoomFactorChangedToken);
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
            zoomFactorChanged = (EventHandler<object>)Delegate.Combine(zoomFactorChanged, value);
        }
        remove
        {
            zoomFactorChanged = (EventHandler<object>)Delegate.Remove(zoomFactorChanged, value);
            if (zoomFactorChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller.remove_ZoomFactorChanged(_zoomFactorChangedToken);
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

    public event EventHandler<CoreWebView2MoveFocusRequestedEventArgs> MoveFocusRequested
    {
        add
        {
            if (moveFocusRequested == null)
            {
                try
                {
                    _nativeICoreWebView2Controller.add_MoveFocusRequested(new CoreWebView2MoveFocusRequestedEventHandler(OnMoveFocusRequested), out _moveFocusRequestedToken);
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
            moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Combine(moveFocusRequested, value);
        }
        remove
        {
            moveFocusRequested = (EventHandler<CoreWebView2MoveFocusRequestedEventArgs>)Delegate.Remove(moveFocusRequested, value);
            if (moveFocusRequested != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller.remove_MoveFocusRequested(_moveFocusRequestedToken);
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

    public event EventHandler<object> GotFocus
    {
        add
        {
            if (gotFocus == null)
            {
                try
                {
                    _nativeICoreWebView2Controller.add_GotFocus(new CoreWebView2FocusChangedEventHandler(OnGotFocus), out _gotFocusToken);
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
            gotFocus = (EventHandler<object>)Delegate.Combine(gotFocus, value);
        }
        remove
        {
            gotFocus = (EventHandler<object>)Delegate.Remove(gotFocus, value);
            if (gotFocus != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller.remove_GotFocus(_gotFocusToken);
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

    public event EventHandler<object> LostFocus
    {
        add
        {
            if (lostFocus == null)
            {
                try
                {
                    _nativeICoreWebView2Controller.add_LostFocus(new CoreWebView2FocusChangedEventHandler(OnLostFocus), out _lostFocusToken);
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
            lostFocus = (EventHandler<object>)Delegate.Combine(lostFocus, value);
        }
        remove
        {
            lostFocus = (EventHandler<object>)Delegate.Remove(lostFocus, value);
            if (lostFocus != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller.remove_LostFocus(_lostFocusToken);
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

    public event EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed
    {
        add
        {
            if (acceleratorKeyPressed == null)
            {
                try
                {
                    _nativeICoreWebView2Controller.add_AcceleratorKeyPressed(new CoreWebView2AcceleratorKeyPressedEventHandler(OnAcceleratorKeyPressed), out _acceleratorKeyPressedToken);
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
            acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Combine(acceleratorKeyPressed, value);
        }
        remove
        {
            acceleratorKeyPressed = (EventHandler<CoreWebView2AcceleratorKeyPressedEventArgs>)Delegate.Remove(acceleratorKeyPressed, value);
            if (acceleratorKeyPressed != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller.remove_AcceleratorKeyPressed(_acceleratorKeyPressedToken);
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

    public event EventHandler<object> RasterizationScaleChanged
    {
        add
        {
            if (rasterizationScaleChanged == null)
            {
                try
                {
                    _nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _rasterizationScaleChangedToken);
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
            rasterizationScaleChanged = (EventHandler<object>)Delegate.Combine(rasterizationScaleChanged, value);
        }
        remove
        {
            rasterizationScaleChanged = (EventHandler<object>)Delegate.Remove(rasterizationScaleChanged, value);
            if (rasterizationScaleChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
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

    private void Initialize()
    {
        if (_nativeICoreWebView2Controller != null)
        {
            ICoreWebView2 coreWebView = _nativeICoreWebView2Controller.CoreWebView2;
            if (coreWebView is ICoreWebView2Private)
            {
                CoreWebView2PrivateHostObjectHelper coreWebView2PrivateHostObjectHelper = new CoreWebView2PrivateHostObjectHelper();
                (coreWebView as ICoreWebView2Private).AddHostObjectHelper(coreWebView2PrivateHostObjectHelper._nativeICoreWebView2PrivateHostObjectHelper);
            }
            else
            {
                object @object = new HostObjectHelper();
                coreWebView.AddHostObjectToScript("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper", ref @object);
            }
        }
    }

    internal CoreWebView2Controller(object rawCoreWebView2Controller)
    {
        _rawNative = rawCoreWebView2Controller;
        Initialize();
    }

    internal void OnZoomFactorChanged(object args)
    {
        zoomFactorChanged?.Invoke(this, args);
    }

    internal void OnMoveFocusRequested(CoreWebView2MoveFocusRequestedEventArgs args)
    {
        moveFocusRequested?.Invoke(this, args);
    }

    internal void OnGotFocus(object args)
    {
        gotFocus?.Invoke(this, args);
    }

    internal void OnLostFocus(object args)
    {
        lostFocus?.Invoke(this, args);
    }

    internal void OnAcceleratorKeyPressed(CoreWebView2AcceleratorKeyPressedEventArgs args)
    {
        acceleratorKeyPressed?.Invoke(this, args);
    }

    public void SetBoundsAndZoomFactor(Rectangle Bounds, double ZoomFactor)
    {
        try
        {
            _nativeICoreWebView2Controller.SetBoundsAndZoomFactor(COMDotNetTypeConverter.RectangleNetToCOM(Bounds), ZoomFactor);
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

    public void MoveFocus(CoreWebView2MoveFocusReason reason)
    {
        try
        {
            _nativeICoreWebView2Controller.MoveFocus((COREWEBVIEW2_MOVE_FOCUS_REASON)reason);
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

    public void NotifyParentWindowPositionChanged()
    {
        try
        {
            _nativeICoreWebView2Controller.NotifyParentWindowPositionChanged();
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

    public void Close()
    {
        try
        {
            _nativeICoreWebView2Controller.Close();
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

    internal void OnRasterizationScaleChanged(object args)
    {
        rasterizationScaleChanged?.Invoke(this, args);
    }
}
