using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2SourceChangedEventArgs : EventArgs
{
    internal ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgsValue;

    internal object _rawNative;

    internal ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgs
    {
        get
        {
            if (_nativeICoreWebView2SourceChangedEventArgsValue == null)
            {
                try
                {
                    _nativeICoreWebView2SourceChangedEventArgsValue = (ICoreWebView2SourceChangedEventArgs)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2SourceChangedEventArgsValue;
        }
        set
        {
            _nativeICoreWebView2SourceChangedEventArgsValue = value;
        }
    }

    public bool IsNewDocument
    {
        get
        {
            try
            {
                return _nativeICoreWebView2SourceChangedEventArgs.IsNewDocument != 0;
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

    internal CoreWebView2SourceChangedEventArgs(object rawCoreWebView2SourceChangedEventArgs)
    {
        _rawNative = rawCoreWebView2SourceChangedEventArgs;
    }
}
