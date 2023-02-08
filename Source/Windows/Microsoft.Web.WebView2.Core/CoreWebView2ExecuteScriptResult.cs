using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2ExecuteScriptResult
{
    internal ICoreWebView2ExperimentalExecuteScriptResult _nativeICoreWebView2ExperimentalExecuteScriptResultValue;

    internal object _rawNative;

    internal ICoreWebView2ExperimentalExecuteScriptResult _nativeICoreWebView2ExperimentalExecuteScriptResult
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalExecuteScriptResultValue == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalExecuteScriptResultValue = (ICoreWebView2ExperimentalExecuteScriptResult)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalExecuteScriptResult.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalExecuteScriptResultValue;
        }
        set
        {
            _nativeICoreWebView2ExperimentalExecuteScriptResultValue = value;
        }
    }

    public bool Succeeded
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ExperimentalExecuteScriptResult.Succeeded != 0;
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

    public string ResultAsJson
    {
        get
        {
            try
            {
                return _nativeICoreWebView2ExperimentalExecuteScriptResult.ResultAsJson;
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

    public CoreWebView2ScriptException Exception
    {
        get
        {
            try
            {
                return (_nativeICoreWebView2ExperimentalExecuteScriptResult.Exception == null) ? null : new CoreWebView2ScriptException(_nativeICoreWebView2ExperimentalExecuteScriptResult.Exception);
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

    internal CoreWebView2ExecuteScriptResult(object rawCoreWebView2ExecuteScriptResult)
    {
        _rawNative = rawCoreWebView2ExecuteScriptResult;
    }

    public void TryGetResultAsString(out string stringResult, out int value)
    {
        try
        {
            _nativeICoreWebView2ExperimentalExecuteScriptResult.TryGetResultAsString(out stringResult, out value);
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
