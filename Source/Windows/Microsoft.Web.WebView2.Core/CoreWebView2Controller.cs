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

    internal ICoreWebView2ExperimentalController2 _nativeICoreWebView2ExperimentalController2Value;

    internal ICoreWebView2ExperimentalController _nativeICoreWebView2ExperimentalControllerValue;

    internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialControllerValue;

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

    private EventRegistrationToken _keyPressedToken;

    private EventHandler<CoreWebView2PrivateKeyPressedEventArgs> keyPressed;

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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
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
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Controller4Value;
        }
        set
        {
            _nativeICoreWebView2Controller4Value = value;
        }
    }

    internal ICoreWebView2ExperimentalController2 _nativeICoreWebView2ExperimentalController2
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalController2Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalController2Value = (ICoreWebView2ExperimentalController2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalController2Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalController2Value = value;
        }
    }

    internal ICoreWebView2ExperimentalController _nativeICoreWebView2ExperimentalController
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalControllerValue == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalControllerValue = (ICoreWebView2ExperimentalController)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalControllerValue;
        }
        set
        {
            _nativeICoreWebView2ExperimentalControllerValue = value;
        }
    }

    internal ICoreWebView2PrivatePartialController _nativeICoreWebView2PrivatePartialController
    {
        get
        {
            if (_nativeICoreWebView2PrivatePartialControllerValue == null)
            {
                try
                {
                    _nativeICoreWebView2PrivatePartialControllerValue = (ICoreWebView2PrivatePartialController)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartialController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2PrivatePartialControllerValue;
        }
        set
        {
            _nativeICoreWebView2PrivatePartialControllerValue = value;
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
                try
                {
                    return _nativeICoreWebView2Controller3.RasterizationScale;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalController.RasterizationScale;
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
        set
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Controller3.RasterizationScale = value;
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalController.RasterizationScale = value;
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

    public bool ShouldDetectMonitorScaleChanges
    {
        get
        {
            try
            {
                try
                {
                    return _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalController.ShouldDetectMonitorScaleChanges != 0;
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
        set
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalController.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
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

    public CoreWebView2BoundsMode BoundsMode
    {
        get
        {
            try
            {
                try
                {
                    return (CoreWebView2BoundsMode)_nativeICoreWebView2Controller3.BoundsMode;
                }
                catch (NotImplementedException)
                {
                    return (CoreWebView2BoundsMode)_nativeICoreWebView2ExperimentalController.BoundsMode;
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
        set
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Controller3.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalController.BoundsMode = (COREWEBVIEW2_BOUNDS_MODE)value;
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

    public bool AllowExternalDrop
    {
        get
        {
            try
            {
                try
                {
                    return _nativeICoreWebView2Controller4.AllowExternalDrop != 0;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalController2.AllowExternalDrop != 0;
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
        set
        {
            try
            {
                try
                {
                    _nativeICoreWebView2Controller4.AllowExternalDrop = (value ? 1 : 0);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalController2.AllowExternalDrop = (value ? 1 : 0);
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

    internal bool IsBrowserHitTransparent
    {
        get
        {
            try
            {
                return _nativeICoreWebView2PrivatePartialController.IsBrowserHitTransparent != 0;
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
                    try
                    {
                        _nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _rasterizationScaleChangedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalController.add_RasterizationScaleChanged(new CoreWebView2ExperimentalRasterizationScaleChangedEventHandler(OnRasterizationScaleChanged), out _rasterizationScaleChangedToken);
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
                try
                {
                    _nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalController.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
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

    internal event EventHandler<CoreWebView2PrivateKeyPressedEventArgs> KeyPressed
    {
        add
        {
            if (keyPressed == null)
            {
                try
                {
                    _nativeICoreWebView2PrivatePartialController.add_KeyPressed(new CoreWebView2PrivateKeyPressedEventHandler(OnKeyPressed), out _keyPressedToken);
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
            keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Combine(keyPressed, value);
        }
        remove
        {
            keyPressed = (EventHandler<CoreWebView2PrivateKeyPressedEventArgs>)Delegate.Remove(keyPressed, value);
            if (keyPressed != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2PrivatePartialController.remove_KeyPressed(_keyPressedToken);
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
        catch (ArgumentException ex3)
        {
            if (ex3.HResult == -2147024809)
            {
                return;
            }
            throw ex3;
        }
    }

    private void Initialize()
    {
        if (_nativeICoreWebView2Controller != null)
        {
            try
            {
                CoreWebView2PrivateHostObjectHelper helper = new CoreWebView2PrivateHostObjectHelper();
                CoreWebView2.AddHostObjectHelper(helper);
            }
            catch (NotImplementedException)
            {
                ICoreWebView2 coreWebView = _nativeICoreWebView2Controller.CoreWebView2;
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

    internal void OnKeyPressed(CoreWebView2PrivateKeyPressedEventArgs args)
    {
        keyPressed?.Invoke(this, args);
    }
}
