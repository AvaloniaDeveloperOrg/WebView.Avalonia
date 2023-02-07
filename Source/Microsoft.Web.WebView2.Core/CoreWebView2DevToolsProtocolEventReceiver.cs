using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2DevToolsProtocolEventReceiver
{
    internal ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiverValue;

    internal object _rawNative;

    private EventRegistrationToken _devToolsProtocolEventReceivedToken;

    private EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> devToolsProtocolEventReceived;

    internal ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiver
    {
        get
        {
            if (_nativeICoreWebView2DevToolsProtocolEventReceiverValue == null)
            {
                try
                {
                    _nativeICoreWebView2DevToolsProtocolEventReceiverValue = (ICoreWebView2DevToolsProtocolEventReceiver)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2DevToolsProtocolEventReceiverValue;
        }
        set
        {
            _nativeICoreWebView2DevToolsProtocolEventReceiverValue = value;
        }
    }

    public event EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs> DevToolsProtocolEventReceived
    {
        add
        {
            if (devToolsProtocolEventReceived == null)
            {
                try
                {
                    _nativeICoreWebView2DevToolsProtocolEventReceiver.add_DevToolsProtocolEventReceived(new CoreWebView2DevToolsProtocolEventReceivedEventHandler(OnDevToolsProtocolEventReceived), out _devToolsProtocolEventReceivedToken);
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
            devToolsProtocolEventReceived = (EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>)Delegate.Combine(devToolsProtocolEventReceived, value);
        }
        remove
        {
            devToolsProtocolEventReceived = (EventHandler<CoreWebView2DevToolsProtocolEventReceivedEventArgs>)Delegate.Remove(devToolsProtocolEventReceived, value);
            if (devToolsProtocolEventReceived != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2DevToolsProtocolEventReceiver.remove_DevToolsProtocolEventReceived(_devToolsProtocolEventReceivedToken);
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

    internal CoreWebView2DevToolsProtocolEventReceiver(object rawCoreWebView2DevToolsProtocolEventReceiver)
    {
        _rawNative = rawCoreWebView2DevToolsProtocolEventReceiver;
    }

    internal void OnDevToolsProtocolEventReceived(CoreWebView2DevToolsProtocolEventReceivedEventArgs args)
    {
        devToolsProtocolEventReceived?.Invoke(this, args);
    }
}
