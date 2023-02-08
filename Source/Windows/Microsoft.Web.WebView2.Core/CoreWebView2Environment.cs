using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Environment
{
    private enum ProcessorArchitecture : ushort
    {
        x86 = 0,
        x64 = 9,
        ARM64 = 12,
        Unknown = ushort.MaxValue
    }

    private struct SYSTEM_INFO
    {
        internal ushort wProcessorArchitecture;

        private ushort wReserved;

        private int dwPageSize;

        private IntPtr lpMinimumApplicationAddress;

        private IntPtr lpMaximumApplicationAddress;

        private IntPtr dwActiveProcessorMask;

        private int dwNumberOfProcessors;

        private int dwProcessorType;

        private int dwAllocationGranularity;

        private short wProcessorLevel;

        private short wProcessorRevision;
    }

    private const char DirectorySeparatorChar = '\\';

    private const char AltDirectorySeparatorChar = '/';

    private const char VolumeSeparatorChar = ':';

    private const char SpaceSeparatorChar = ' ';

    private static bool webView2LoaderLoaded;

    private static string loaderDllFolderPath;

    internal ICoreWebView2Environment _nativeICoreWebView2EnvironmentValue;

    internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2Value;

    internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3Value;

    internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4Value;

    internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5Value;

    internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6Value;

    internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7Value;

    internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8Value;

    internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9Value;

    internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10Value;

    internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11Value;

    internal ICoreWebView2ExperimentalEnvironment10 _nativeICoreWebView2ExperimentalEnvironment10Value;

    internal ICoreWebView2ExperimentalEnvironment9 _nativeICoreWebView2ExperimentalEnvironment9Value;

    internal ICoreWebView2ExperimentalEnvironment8 _nativeICoreWebView2ExperimentalEnvironment8Value;

    internal ICoreWebView2ExperimentalEnvironment7 _nativeICoreWebView2ExperimentalEnvironment7Value;

    internal ICoreWebView2ExperimentalEnvironment6 _nativeICoreWebView2ExperimentalEnvironment6Value;

    internal ICoreWebView2ExperimentalEnvironment5 _nativeICoreWebView2ExperimentalEnvironment5Value;

    internal ICoreWebView2ExperimentalEnvironment4 _nativeICoreWebView2ExperimentalEnvironment4Value;

    internal ICoreWebView2ExperimentalEnvironment3 _nativeICoreWebView2ExperimentalEnvironment3Value;

    internal ICoreWebView2ExperimentalEnvironment2 _nativeICoreWebView2ExperimentalEnvironment2Value;

    internal ICoreWebView2ExperimentalEnvironment _nativeICoreWebView2ExperimentalEnvironmentValue;

    internal object _rawNative;

    private EventRegistrationToken _newBrowserVersionAvailableToken;

    private EventHandler<object> newBrowserVersionAvailable;

    private EventRegistrationToken _browserProcessExitedToken;

    private EventHandler<CoreWebView2BrowserProcessExitedEventArgs> browserProcessExited;

    private EventRegistrationToken _processInfosChangedToken;

    private EventHandler<object> processInfosChanged;

    internal ICoreWebView2Environment _nativeICoreWebView2Environment
    {
        get
        {
            if (_nativeICoreWebView2EnvironmentValue == null)
            {
                try
                {
                    _nativeICoreWebView2EnvironmentValue = (ICoreWebView2Environment)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2EnvironmentValue;
        }
        set
        {
            _nativeICoreWebView2EnvironmentValue = value;
        }
    }

    internal ICoreWebView2Environment2 _nativeICoreWebView2Environment2
    {
        get
        {
            if (_nativeICoreWebView2Environment2Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment2Value = (ICoreWebView2Environment2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment2Value;
        }
        set
        {
            _nativeICoreWebView2Environment2Value = value;
        }
    }

    internal ICoreWebView2Environment3 _nativeICoreWebView2Environment3
    {
        get
        {
            if (_nativeICoreWebView2Environment3Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment3Value = (ICoreWebView2Environment3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment3Value;
        }
        set
        {
            _nativeICoreWebView2Environment3Value = value;
        }
    }

    internal ICoreWebView2Environment4 _nativeICoreWebView2Environment4
    {
        get
        {
            if (_nativeICoreWebView2Environment4Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment4Value = (ICoreWebView2Environment4)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment4Value;
        }
        set
        {
            _nativeICoreWebView2Environment4Value = value;
        }
    }

    internal ICoreWebView2Environment5 _nativeICoreWebView2Environment5
    {
        get
        {
            if (_nativeICoreWebView2Environment5Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment5Value = (ICoreWebView2Environment5)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment5Value;
        }
        set
        {
            _nativeICoreWebView2Environment5Value = value;
        }
    }

    internal ICoreWebView2Environment6 _nativeICoreWebView2Environment6
    {
        get
        {
            if (_nativeICoreWebView2Environment6Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment6Value = (ICoreWebView2Environment6)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment6Value;
        }
        set
        {
            _nativeICoreWebView2Environment6Value = value;
        }
    }

    internal ICoreWebView2Environment7 _nativeICoreWebView2Environment7
    {
        get
        {
            if (_nativeICoreWebView2Environment7Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment7Value = (ICoreWebView2Environment7)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment7Value;
        }
        set
        {
            _nativeICoreWebView2Environment7Value = value;
        }
    }

    internal ICoreWebView2Environment8 _nativeICoreWebView2Environment8
    {
        get
        {
            if (_nativeICoreWebView2Environment8Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment8Value = (ICoreWebView2Environment8)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment8Value;
        }
        set
        {
            _nativeICoreWebView2Environment8Value = value;
        }
    }

    internal ICoreWebView2Environment9 _nativeICoreWebView2Environment9
    {
        get
        {
            if (_nativeICoreWebView2Environment9Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment9Value = (ICoreWebView2Environment9)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment9Value;
        }
        set
        {
            _nativeICoreWebView2Environment9Value = value;
        }
    }

    internal ICoreWebView2Environment10 _nativeICoreWebView2Environment10
    {
        get
        {
            if (_nativeICoreWebView2Environment10Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment10Value = (ICoreWebView2Environment10)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment10Value;
        }
        set
        {
            _nativeICoreWebView2Environment10Value = value;
        }
    }

    internal ICoreWebView2Environment11 _nativeICoreWebView2Environment11
    {
        get
        {
            if (_nativeICoreWebView2Environment11Value == null)
            {
                try
                {
                    _nativeICoreWebView2Environment11Value = (ICoreWebView2Environment11)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2Environment11Value;
        }
        set
        {
            _nativeICoreWebView2Environment11Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment10 _nativeICoreWebView2ExperimentalEnvironment10
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment10Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment10Value = (ICoreWebView2ExperimentalEnvironment10)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment10Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment10Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment9 _nativeICoreWebView2ExperimentalEnvironment9
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment9Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment9Value = (ICoreWebView2ExperimentalEnvironment9)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment9Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment9Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment8 _nativeICoreWebView2ExperimentalEnvironment8
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment8Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment8Value = (ICoreWebView2ExperimentalEnvironment8)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment8Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment8Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment7 _nativeICoreWebView2ExperimentalEnvironment7
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment7Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment7Value = (ICoreWebView2ExperimentalEnvironment7)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment7Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment7Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment6 _nativeICoreWebView2ExperimentalEnvironment6
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment6Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment6Value = (ICoreWebView2ExperimentalEnvironment6)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment6Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment6Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment5 _nativeICoreWebView2ExperimentalEnvironment5
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment5Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment5Value = (ICoreWebView2ExperimentalEnvironment5)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment5Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment5Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment4 _nativeICoreWebView2ExperimentalEnvironment4
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment4Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment4Value = (ICoreWebView2ExperimentalEnvironment4)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment4Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment4Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment3 _nativeICoreWebView2ExperimentalEnvironment3
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment3Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment3Value = (ICoreWebView2ExperimentalEnvironment3)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment3Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment3Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment2 _nativeICoreWebView2ExperimentalEnvironment2
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironment2Value == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironment2Value = (ICoreWebView2ExperimentalEnvironment2)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironment2Value;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironment2Value = value;
        }
    }

    internal ICoreWebView2ExperimentalEnvironment _nativeICoreWebView2ExperimentalEnvironment
    {
        get
        {
            if (_nativeICoreWebView2ExperimentalEnvironmentValue == null)
            {
                try
                {
                    _nativeICoreWebView2ExperimentalEnvironmentValue = (ICoreWebView2ExperimentalEnvironment)_rawNative;
                }
                catch (Exception inner)
                {
                    throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalEnvironment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
                }
            }
            return _nativeICoreWebView2ExperimentalEnvironmentValue;
        }
        set
        {
            _nativeICoreWebView2ExperimentalEnvironmentValue = value;
        }
    }

    public string BrowserVersionString
    {
        get
        {
            try
            {
                return _nativeICoreWebView2Environment.BrowserVersionString;
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

    public string UserDataFolder
    {
        get
        {
            try
            {
                try
                {
                    return _nativeICoreWebView2Environment7.UserDataFolder;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalEnvironment5.UserDataFolder;
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

    public string FailureReportFolderPath
    {
        get
        {
            try
            {
                try
                {
                    return _nativeICoreWebView2Environment11.FailureReportFolderPath;
                }
                catch (NotImplementedException)
                {
                    return _nativeICoreWebView2ExperimentalEnvironment.FailureReportFolderPath;
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

    public event EventHandler<object> NewBrowserVersionAvailable
    {
        add
        {
            if (newBrowserVersionAvailable == null)
            {
                try
                {
                    _nativeICoreWebView2Environment.add_NewBrowserVersionAvailable(new CoreWebView2NewBrowserVersionAvailableEventHandler(OnNewBrowserVersionAvailable), out _newBrowserVersionAvailableToken);
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
            newBrowserVersionAvailable = (EventHandler<object>)Delegate.Combine(newBrowserVersionAvailable, value);
        }
        remove
        {
            newBrowserVersionAvailable = (EventHandler<object>)Delegate.Remove(newBrowserVersionAvailable, value);
            if (newBrowserVersionAvailable != null)
            {
                return;
            }
            try
            {
                _nativeICoreWebView2Environment.remove_NewBrowserVersionAvailable(_newBrowserVersionAvailableToken);
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

    public event EventHandler<CoreWebView2BrowserProcessExitedEventArgs> BrowserProcessExited
    {
        add
        {
            if (browserProcessExited == null)
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Environment5.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler(OnBrowserProcessExited), out _browserProcessExitedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalEnvironment4.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler(OnBrowserProcessExited), out _browserProcessExitedToken);
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
            browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Combine(browserProcessExited, value);
        }
        remove
        {
            browserProcessExited = (EventHandler<CoreWebView2BrowserProcessExitedEventArgs>)Delegate.Remove(browserProcessExited, value);
            if (browserProcessExited != null)
            {
                return;
            }
            try
            {
                try
                {
                    _nativeICoreWebView2Environment5.remove_BrowserProcessExited(_browserProcessExitedToken);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalEnvironment4.remove_BrowserProcessExited(_browserProcessExitedToken);
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

    public event EventHandler<object> ProcessInfosChanged
    {
        add
        {
            if (processInfosChanged == null)
            {
                try
                {
                    try
                    {
                        _nativeICoreWebView2Environment8.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler(OnProcessInfosChanged), out _processInfosChangedToken);
                    }
                    catch (NotImplementedException)
                    {
                        _nativeICoreWebView2ExperimentalEnvironment9.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler(OnProcessInfosChanged), out _processInfosChangedToken);
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
            processInfosChanged = (EventHandler<object>)Delegate.Combine(processInfosChanged, value);
        }
        remove
        {
            processInfosChanged = (EventHandler<object>)Delegate.Remove(processInfosChanged, value);
            if (processInfosChanged != null)
            {
                return;
            }
            try
            {
                try
                {
                    _nativeICoreWebView2Environment8.remove_ProcessInfosChanged(_processInfosChangedToken);
                }
                catch (NotImplementedException)
                {
                    _nativeICoreWebView2ExperimentalEnvironment9.remove_ProcessInfosChanged(_processInfosChangedToken);
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

    [DllImport("WebView2Loader.dll")]
    internal static extern int CreateCoreWebView2EnvironmentWithOptions([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [In][MarshalAs(UnmanagedType.LPWStr)] string userDataFolder, ICoreWebView2EnvironmentOptions options, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environment_created_handler);

    [DllImport("WebView2Loader.dll")]
    internal static extern int GetAvailableCoreWebView2BrowserVersionString([In][MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder, [MarshalAs(UnmanagedType.LPWStr)] ref string versionInfo);

    [DllImport("WebView2Loader.dll")]
    internal static extern int CompareBrowserVersions([In][MarshalAs(UnmanagedType.LPWStr)] string version1, [In][MarshalAs(UnmanagedType.LPWStr)] string version2, ref int result);

    public static async Task<CoreWebView2Environment> CreateAsync(string browserExecutableFolder = null, string userDataFolder = null, CoreWebView2EnvironmentOptions options = null)
    {
        LoadWebView2LoaderDll();
        CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler handler = new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler();
        CoreWebView2EnvironmentOptions coreWebView2EnvironmentOptions = options ?? new CoreWebView2EnvironmentOptions();
        int num = CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder, coreWebView2EnvironmentOptions._nativeICoreWebView2EnvironmentOptions, handler);
        if (num == -2147024894)
        {
            throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(num));
        }
        Marshal.ThrowExceptionForHR(num);
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.createdEnvironment;
    }

    public static string GetAvailableBrowserVersionString(string browserExecutableFolder = null)
    {
        LoadWebView2LoaderDll();
        string versionInfo = null;
        int availableCoreWebView2BrowserVersionString = GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, ref versionInfo);
        if (availableCoreWebView2BrowserVersionString == -2147024894)
        {
            throw new WebView2RuntimeNotFoundException(Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionString));
        }
        Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionString);
        return versionInfo;
    }

    public static int CompareBrowserVersions(string version1, string version2)
    {
        LoadWebView2LoaderDll();
        int result = 0;
        Marshal.ThrowExceptionForHR(CompareBrowserVersions(version1, version2, ref result));
        return result;
    }

    public CoreWebView2WebResourceRequest CreateWebResourceRequest(string uri, string Method, Stream postData, string Headers)
    {
        return new CoreWebView2WebResourceRequest(_nativeICoreWebView2Environment2.CreateWebResourceRequest(uri, Method, (postData == null) ? null : new ManagedIStream(postData), Headers));
    }

    public CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
    {
        try
        {
            return new CoreWebView2ControllerOptions(_nativeICoreWebView2Environment10.CreateCoreWebView2ControllerOptions());
        }
        catch (NotImplementedException)
        {
            return new CoreWebView2ControllerOptions(_nativeICoreWebView2ExperimentalEnvironment8.CreateCoreWebView2ControllerOptions("", 0));
        }
        catch (InvalidCastException ex2)
        {
            if (ex2.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex2);
            }
            throw ex2;
        }
        catch (COMException ex3)
        {
            if (ex3.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2ControllerOptions members cannot be accessed after the WebView2 control is disposed.", ex3);
            }
            throw ex3;
        }
    }

    public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
    {
        CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
            _nativeICoreWebView2Environment10.CreateCoreWebView2ControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
            }
            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2ControllerAsync failed to create the controller due to incompatible options.", ex2);
            }
            throw ex2;
        }
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.createdController;
    }

    public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow, CoreWebView2ControllerOptions options)
    {
        CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
            _nativeICoreWebView2Environment10.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options._nativeICoreWebView2ControllerOptions, handler);
        }
        catch (InvalidCastException ex)
        {
            if (ex.HResult == -2147467262)
            {
                throw new InvalidOperationException("CoreWebView2Environment members can only be accessed from the UI thread.", ex);
            }
            throw ex;
        }
        catch (COMException ex2)
        {
            if (ex2.HResult == -2147019873)
            {
                throw new InvalidOperationException("CreateCoreWebView2CompositionControllerAsync failed to create the composition controller due to incompatible options.", ex2);
            }
            throw ex2;
        }
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.webView;
    }

    private static ProcessorArchitecture GetArchitecture()
    {
        GetSystemInfo(out var lpSystemInfo);
        return (ProcessorArchitecture)lpSystemInfo.wProcessorArchitecture;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string dllToLoad);

    private static bool IsDirectorySeparator(char c)
    {
        if (c != DirectorySeparatorChar)
            return c == AltDirectorySeparatorChar;

        return true;
    }

    internal static bool IsValidDriveChar(char value)
    {
        if (value < 'A' || value > 'Z')
        {
            if (value >= 'a')
                return value <= 'z';

            return false;
        }
        return true;
    }

    private static bool IsPathPartiallyQualified(string path)
    {
        if (path == null || path.Length < 2)
        {
            return true;
        }
        if (IsDirectorySeparator(path[0]))
        {
            if (path[1] != '?')
            {
                return !IsDirectorySeparator(path[1]);
            }
            return false;
        }
        if (path.Length >= 3 && path[1] == VolumeSeparatorChar && IsDirectorySeparator(path[2]))
        {
            return !IsValidDriveChar(path[0]);
        }
        return true;
    }

    private static bool IsDotNetFramework()
    {
        return typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Framework");
    }

    private static bool IsDotNetCore()
    {
        return typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Core");
    }

    private static bool IsDotNet()
    {
        return typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET");
    }

    private static string GetAssemblyLocationDirectory()
    {
        return Path.GetDirectoryName(typeof(CoreWebView2Environment).Assembly.Location);
    }

    private static string GetAssemblyCodeBaseDirectory()
    {
        string text = typeof(CoreWebView2Environment).Assembly.CodeBase;
        if (text.StartsWith("file:///"))
        {
            text = Path.GetDirectoryName(text.Substring("file:///".Length));
        }
        return text;
    }

    private static string GetProcessArchSubFolder()
    {
        string text = $"runtimes{DirectorySeparatorChar}win-";
        return Path.Combine(GetArchitecture() switch
        {
            ProcessorArchitecture.x86 => text + "x86",
            ProcessorArchitecture.x64 => text + "x64",
            ProcessorArchitecture.ARM64 => text + "arm64",
            _ => throw new NotSupportedException("Unknown Processor Architecture of WebView2Loader.dll is not supported"),
        }, "native");
    }

    public static void SetLoaderDllFolderPath(string folderPath)
    {
        if (!webView2LoaderLoaded)
        {
            loaderDllFolderPath = folderPath;
            return;
        }
        throw new InvalidOperationException("The function should be called before before any other API is called in `CoreWebView2Environment` class.");
    }

    private static void LoadWebView2LoaderDll()
    {
        if (webView2LoaderLoaded)
            return;

        char[] trimChars = new char[3] { DirectorySeparatorChar, AltDirectorySeparatorChar, SpaceSeparatorChar };
        string text = "";
        if (!string.IsNullOrEmpty(loaderDllFolderPath))
            text = loaderDllFolderPath.Trim(trimChars);
        else if (IsDotNetFramework())
            text = GetProcessArchSubFolder().Trim(trimChars);
        else if (IsDotNetCore())
            text = GetProcessArchSubFolder().Trim(trimChars);
        else if (IsDotNet())
            text = GetProcessArchSubFolder().Trim(trimChars);

        if (!string.IsNullOrEmpty(text))
        {
            ArrayList arrayList = new ArrayList();
            if (!IsPathPartiallyQualified(text))
            {
                arrayList.Add(text);
            }
            else
            {
                arrayList.Add(Path.Combine(GetAssemblyLocationDirectory(), text));
                arrayList.Add(Path.Combine(GetAssemblyCodeBaseDirectory(), text));
            }
            arrayList.Add("");
            string text2 = "";
            foreach (string item in arrayList)
            {
                text2 = Path.Combine(item, "WebView2Loader.dll");
                if (LoadLibrary(text2) != IntPtr.Zero)
                {
                    webView2LoaderLoaded = true;
                    break;
                }
            }
            if (!webView2LoaderLoaded && !string.IsNullOrEmpty(loaderDllFolderPath))
            {
                int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
                throw new DllNotFoundException($"Unable to load DLL '{text2}' or one of its dependencies: {new Win32Exception(hRForLastWin32Error).Message} (0x{hRForLastWin32Error:X})");
            }
        }
        webView2LoaderLoaded = true;
    }

    internal CoreWebView2Environment(object rawCoreWebView2Environment)
    {
        _rawNative = rawCoreWebView2Environment;
    }

    internal void OnNewBrowserVersionAvailable(object args)
    {
        newBrowserVersionAvailable?.Invoke(this, args);
    }

    public async Task<CoreWebView2Controller> CreateCoreWebView2ControllerAsync(IntPtr ParentWindow)
    {
        CoreWebView2CreateCoreWebView2ControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2ControllerCompletedHandler();
            _nativeICoreWebView2Environment.CreateCoreWebView2Controller(ParentWindow, handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.createdController;
    }

    public CoreWebView2WebResourceResponse CreateWebResourceResponse(Stream Content, int StatusCode, string ReasonPhrase, string Headers)
    {
        try
        {
            return new CoreWebView2WebResourceResponse(_nativeICoreWebView2Environment.CreateWebResourceResponse((Content == null) ? null : new ManagedIStream(Content), StatusCode, ReasonPhrase, Headers));
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

    public async Task<CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(IntPtr ParentWindow)
    {
        CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler;
        try
        {
            handler = new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler();
            _nativeICoreWebView2Environment3.CreateCoreWebView2CompositionController(ParentWindow, handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.webView;
    }

    public CoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
    {
        try
        {
            return new CoreWebView2PointerInfo(_nativeICoreWebView2Environment3.CreateCoreWebView2PointerInfo());
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

    internal void OnBrowserProcessExited(CoreWebView2BrowserProcessExitedEventArgs args)
    {
        browserProcessExited?.Invoke(this, args);
    }

    public CoreWebView2PrintSettings CreatePrintSettings()
    {
        try
        {
            try
            {
                return new CoreWebView2PrintSettings(_nativeICoreWebView2Environment6.CreatePrintSettings());
            }
            catch (NotImplementedException)
            {
                return new CoreWebView2PrintSettings(_nativeICoreWebView2ExperimentalEnvironment7.CreatePrintSettings());
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

    internal void OnProcessInfosChanged(object args)
    {
        processInfosChanged?.Invoke(this, args);
    }

    public IReadOnlyList<CoreWebView2ProcessInfo> GetProcessInfos()
    {
        try
        {
            try
            {
                return COMDotNetTypeConverter.ProcessInfoCollectionCOMToNet(_nativeICoreWebView2Environment8.GetProcessInfos());
            }
            catch (NotImplementedException)
            {
                return COMDotNetTypeConverter.ProcessInfoCollectionCOMToNet(_nativeICoreWebView2ExperimentalEnvironment9.GetProcessInfos());
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

    public CoreWebView2ContextMenuItem CreateContextMenuItem(string Label, Stream iconStream, CoreWebView2ContextMenuItemKind Kind)
    {
        try
        {
            try
            {
                return new CoreWebView2ContextMenuItem(_nativeICoreWebView2Environment9.CreateContextMenuItem(Label, (iconStream == null) ? null : new ManagedIStream(iconStream), (COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND)Kind));
            }
            catch (NotImplementedException)
            {
                return new CoreWebView2ContextMenuItem(_nativeICoreWebView2ExperimentalEnvironment6.CreateContextMenuItem(Label, (iconStream == null) ? null : new ManagedIStream(iconStream), (COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND)Kind));
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

    public CoreWebView2SharedBuffer CreateSharedBuffer(ulong Size)
    {
        try
        {
            return new CoreWebView2SharedBuffer(_nativeICoreWebView2ExperimentalEnvironment10.CreateSharedBuffer(Size));
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

    public async Task<CoreWebView2UpdateRuntimeResult> UpdateRuntimeAsync()
    {
        CoreWebView2UpdateRuntimeCompletedHandler handler;
        try
        {
            handler = new CoreWebView2UpdateRuntimeCompletedHandler();
            _nativeICoreWebView2ExperimentalEnvironment3.UpdateRuntime(handler);
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
        await handler;
        Marshal.ThrowExceptionForHR(handler.errCode);
        return handler.result;
    }
}
