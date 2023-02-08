using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2DownloadOperation
{
    internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperationValue;

    internal object _rawNative;

    private EventRegistrationToken _bytesReceivedChangedToken;

    private EventHandler<object> bytesReceivedChanged;

    private EventRegistrationToken _estimatedEndTimeChangedToken;

    private EventHandler<object> estimatedEndTimeChanged;

    private EventRegistrationToken _stateChangedToken;

    private EventHandler<object> stateChanged;

    public DateTime EstimatedEndTime => DateTime.Parse(_nativeICoreWebView2DownloadOperation.EstimatedEndTime);

    public ulong? TotalBytesToReceive
    {
        get
        {
            if (_nativeICoreWebView2DownloadOperation.TotalBytesToReceive < 0)
            {
                return null;
            }
            return (ulong)_nativeICoreWebView2DownloadOperation.TotalBytesToReceive;
        }
    }

    internal ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperation
    {
        get
        {
            if (_nativeICoreWebView2DownloadOperationValue == null)
            {
                try
                {
                    _nativeICoreWebView2DownloadOperationValue = (ICoreWebView2DownloadOperation)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2DownloadOperationValue;
        }
        set
        {
            _nativeICoreWebView2DownloadOperationValue = value;
        }
    }

    public string Uri
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.Uri;
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

    public string ContentDisposition
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.ContentDisposition;
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

    public string MimeType
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.MimeType;
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

    public long BytesReceived
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.BytesReceived;
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

    public string ResultFilePath
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.ResultFilePath;
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

    public CoreWebView2DownloadState State
    {
        get
        {
            try
            {
                return (CoreWebView2DownloadState)_nativeICoreWebView2DownloadOperation.State;
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

    public CoreWebView2DownloadInterruptReason InterruptReason
    {
        get
        {
            try
            {
                return (CoreWebView2DownloadInterruptReason)_nativeICoreWebView2DownloadOperation.InterruptReason;
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

    public bool CanResume
    {
        get
        {
            try
            {
                return _nativeICoreWebView2DownloadOperation.CanResume != 0;
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

    public event EventHandler<object> BytesReceivedChanged
    {
        add
        {
            if (bytesReceivedChanged == null)
            {
                try
                {
                    _nativeICoreWebView2DownloadOperation.add_BytesReceivedChanged(new CoreWebView2BytesReceivedChangedEventHandler(OnBytesReceivedChanged), out _bytesReceivedChangedToken);
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
            bytesReceivedChanged = (EventHandler<object>)Delegate.Combine(bytesReceivedChanged, value);
        }
        remove
        {
            bytesReceivedChanged = (EventHandler<object>)Delegate.Remove(bytesReceivedChanged, value);
            if (bytesReceivedChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2DownloadOperation.remove_BytesReceivedChanged(_bytesReceivedChangedToken);
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

    public event EventHandler<object> EstimatedEndTimeChanged
    {
        add
        {
            if (estimatedEndTimeChanged == null)
            {
                try
                {
                    _nativeICoreWebView2DownloadOperation.add_EstimatedEndTimeChanged(new CoreWebView2EstimatedEndTimeChangedEventHandler(OnEstimatedEndTimeChanged), out _estimatedEndTimeChangedToken);
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
            estimatedEndTimeChanged = (EventHandler<object>)Delegate.Combine(estimatedEndTimeChanged, value);
        }
        remove
        {
            estimatedEndTimeChanged = (EventHandler<object>)Delegate.Remove(estimatedEndTimeChanged, value);
            if (estimatedEndTimeChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2DownloadOperation.remove_EstimatedEndTimeChanged(_estimatedEndTimeChangedToken);
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

    public event EventHandler<object> StateChanged
    {
        add
        {
            if (stateChanged == null)
            {
                try
                {
                    _nativeICoreWebView2DownloadOperation.add_StateChanged(new CoreWebView2StateChangedEventHandler(OnStateChanged), out _stateChangedToken);
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
            stateChanged = (EventHandler<object>)Delegate.Combine(stateChanged, value);
        }
        remove
        {
            stateChanged = (EventHandler<object>)Delegate.Remove(stateChanged, value);
            if (stateChanged != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2DownloadOperation.remove_StateChanged(_stateChangedToken);
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

    internal CoreWebView2DownloadOperation(object rawCoreWebView2DownloadOperation)
    {
        _rawNative = rawCoreWebView2DownloadOperation;
    }

    internal void OnBytesReceivedChanged(object args)
    {
        bytesReceivedChanged?.Invoke(this, args);
    }

    internal void OnEstimatedEndTimeChanged(object args)
    {
        estimatedEndTimeChanged?.Invoke(this, args);
    }

    internal void OnStateChanged(object args)
    {
        stateChanged?.Invoke(this, args);
    }

    public void Cancel()
    {
        try
        {
            _nativeICoreWebView2DownloadOperation.Cancel();
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

    public void Pause()
    {
        try
        {
            _nativeICoreWebView2DownloadOperation.Pause();
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

    public void Resume()
    {
        try
        {
            _nativeICoreWebView2DownloadOperation.Resume();
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
