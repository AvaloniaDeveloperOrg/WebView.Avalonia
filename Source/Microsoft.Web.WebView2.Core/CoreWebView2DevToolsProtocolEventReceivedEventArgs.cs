using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2DevToolsProtocolEventReceivedEventArgs : EventArgs
{
    internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;

    internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value;

    internal object _rawNative;

    internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = (ICoreWebView2DevToolsProtocolEventReceivedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = value;
        }
    }

    internal ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2
    {
        get
        {
            if (_nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value == null)
            {
                try
                {
                    _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value = (ICoreWebView2DevToolsProtocolEventReceivedEventArgs2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value;
        }
        set
        {
            _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2Value = value;
        }
    }

    public string ParameterObjectAsJson
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs.ParameterObjectAsJson;
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

    public string SessionId
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs2.SessionId;
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

    internal CoreWebView2DevToolsProtocolEventReceivedEventArgs(object rawCoreWebView2DevToolsProtocolEventReceivedEventArgs)
    {
        _rawNative = rawCoreWebView2DevToolsProtocolEventReceivedEventArgs;
    }
}
