using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ProcessFailedEventArgs : EventArgs
{
    internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgsValue;

    internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2Value;

    internal object _rawNative;

    internal ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2ProcessFailedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2ProcessFailedEventArgsValue = (ICoreWebView2ProcessFailedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ProcessFailedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2ProcessFailedEventArgsValue = value;
        }
    }

    internal ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2
    {
        get
        {
            if (_nativeICoreWebView2ProcessFailedEventArgs2Value == null)
            {
                try
                {
                    _nativeICoreWebView2ProcessFailedEventArgs2Value = (ICoreWebView2ProcessFailedEventArgs2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ProcessFailedEventArgs2Value;
        }
        set
        {
            _nativeICoreWebView2ProcessFailedEventArgs2Value = value;
        }
    }

    public CoreWebView2ProcessFailedKind ProcessFailedKind
    {
        get
        {
            try
            {
                return (CoreWebView2ProcessFailedKind)_nativeICoreWebView2ProcessFailedEventArgs.ProcessFailedKind;
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

    public CoreWebView2ProcessFailedReason Reason
    {
        get
        {
            try
            {
                return (CoreWebView2ProcessFailedReason)_nativeICoreWebView2ProcessFailedEventArgs2.Reason;
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

    public int ExitCode
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ProcessFailedEventArgs2.ExitCode;
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

    public string ProcessDescription
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ProcessFailedEventArgs2.ProcessDescription;
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

    public IReadOnlyList<CoreWebView2FrameInfo> FrameInfosForFailedProcess
    {
        get
        {
            try
            {
                return COMDotNetTypeConverter.CoreWebView2FrameInfoCollectionCOMToNet(_nativeICoreWebView2ProcessFailedEventArgs2.FrameInfosForFailedProcess);
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

    internal CoreWebView2ProcessFailedEventArgs(object rawCoreWebView2ProcessFailedEventArgs)
    {
        _rawNative = rawCoreWebView2ProcessFailedEventArgs;
    }
}
