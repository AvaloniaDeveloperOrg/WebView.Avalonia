using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2
{
	internal ICoreWebView2 _nativeICoreWebView2Value;

	internal ICoreWebView2_2 _nativeICoreWebView2_2Value;

	internal ICoreWebView2_3 _nativeICoreWebView2_3Value;

	internal ICoreWebView2_4 _nativeICoreWebView2_4Value;

	internal ICoreWebView2_5 _nativeICoreWebView2_5Value;

	internal ICoreWebView2_6 _nativeICoreWebView2_6Value;

	internal ICoreWebView2_7 _nativeICoreWebView2_7Value;

	internal ICoreWebView2_8 _nativeICoreWebView2_8Value;

	internal ICoreWebView2_9 _nativeICoreWebView2_9Value;

	internal ICoreWebView2_10 _nativeICoreWebView2_10Value;

	internal ICoreWebView2_11 _nativeICoreWebView2_11Value;

	internal ICoreWebView2_12 _nativeICoreWebView2_12Value;

	internal ICoreWebView2_13 _nativeICoreWebView2_13Value;

	internal ICoreWebView2_14 _nativeICoreWebView2_14Value;

	internal ICoreWebView2_15 _nativeICoreWebView2_15Value;

	internal ICoreWebView2_16 _nativeICoreWebView2_16Value;

	internal ICoreWebView2Experimental19 _nativeICoreWebView2Experimental19Value;

	internal ICoreWebView2Experimental9 _nativeICoreWebView2Experimental9Value;

	internal ICoreWebView2Experimental18 _nativeICoreWebView2Experimental18Value;

	internal ICoreWebView2Experimental8 _nativeICoreWebView2Experimental8Value;

	internal ICoreWebView2Experimental17 _nativeICoreWebView2Experimental17Value;

	internal ICoreWebView2Experimental16 _nativeICoreWebView2Experimental16Value;

	internal ICoreWebView2Experimental15 _nativeICoreWebView2Experimental15Value;

	internal ICoreWebView2Experimental14 _nativeICoreWebView2Experimental14Value;

	internal ICoreWebView2Experimental13 _nativeICoreWebView2Experimental13Value;

	internal ICoreWebView2Experimental12 _nativeICoreWebView2Experimental12Value;

	internal ICoreWebView2Experimental11 _nativeICoreWebView2Experimental11Value;

	internal ICoreWebView2Experimental10 _nativeICoreWebView2Experimental10Value;

	internal ICoreWebView2Experimental7 _nativeICoreWebView2Experimental7Value;

	internal ICoreWebView2Experimental6 _nativeICoreWebView2Experimental6Value;

	internal ICoreWebView2Experimental5 _nativeICoreWebView2Experimental5Value;

	internal ICoreWebView2Experimental4 _nativeICoreWebView2Experimental4Value;

	internal ICoreWebView2Experimental3 _nativeICoreWebView2Experimental3Value;

	internal ICoreWebView2Experimental2 _nativeICoreWebView2Experimental2Value;

	internal ICoreWebView2Experimental _nativeICoreWebView2ExperimentalValue;

	internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartialValue;

	internal object _rawNative;

	private EventRegistrationToken _navigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

	private EventRegistrationToken _contentLoadingToken;

	private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

	private EventRegistrationToken _sourceChangedToken;

	private EventHandler<CoreWebView2SourceChangedEventArgs> sourceChanged;

	private EventRegistrationToken _historyChangedToken;

	private EventHandler<object> historyChanged;

	private EventRegistrationToken _navigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

	private EventRegistrationToken _frameNavigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> frameNavigationStarting;

	private EventRegistrationToken _frameNavigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> frameNavigationCompleted;

	private EventRegistrationToken _scriptDialogOpeningToken;

	private EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> scriptDialogOpening;

	private EventRegistrationToken _permissionRequestedToken;

	private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

	private EventRegistrationToken _processFailedToken;

	private EventHandler<CoreWebView2ProcessFailedEventArgs> processFailed;

	private EventRegistrationToken _webMessageReceivedToken;

	private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

	private EventRegistrationToken _newWindowRequestedToken;

	private EventHandler<CoreWebView2NewWindowRequestedEventArgs> newWindowRequested;

	private EventRegistrationToken _documentTitleChangedToken;

	private EventHandler<object> documentTitleChanged;

	private EventRegistrationToken _containsFullScreenElementChangedToken;

	private EventHandler<object> containsFullScreenElementChanged;

	private EventRegistrationToken _webResourceRequestedToken;

	private EventHandler<CoreWebView2WebResourceRequestedEventArgs> webResourceRequested;

	private EventRegistrationToken _windowCloseRequestedToken;

	private EventHandler<object> windowCloseRequested;

	private EventRegistrationToken _webResourceResponseReceivedToken;

	private EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> webResourceResponseReceived;

	private EventRegistrationToken _dOMContentLoadedToken;

	private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

	private EventRegistrationToken _frameCreatedToken;

	private EventHandler<CoreWebView2FrameCreatedEventArgs> frameCreated;

	private EventRegistrationToken _downloadStartingToken;

	private EventHandler<CoreWebView2DownloadStartingEventArgs> downloadStarting;

	private EventRegistrationToken _clientCertificateRequestedToken;

	private EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> clientCertificateRequested;

	private EventRegistrationToken _isMutedChangedToken;

	private EventHandler<object> isMutedChanged;

	private EventRegistrationToken _isDocumentPlayingAudioChangedToken;

	private EventHandler<object> isDocumentPlayingAudioChanged;

	private EventRegistrationToken _isDefaultDownloadDialogOpenChangedToken;

	private EventHandler<object> isDefaultDownloadDialogOpenChanged;

	private EventRegistrationToken _basicAuthenticationRequestedToken;

	private EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> basicAuthenticationRequested;

	private EventRegistrationToken _contextMenuRequestedToken;

	private EventHandler<CoreWebView2ContextMenuRequestedEventArgs> contextMenuRequested;

	private EventRegistrationToken _statusBarTextChangedToken;

	private EventHandler<object> statusBarTextChanged;

	private EventRegistrationToken _serverCertificateErrorDetectedToken;

	private EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> serverCertificateErrorDetected;

	private EventRegistrationToken _faviconChangedToken;

	private EventHandler<object> faviconChanged;

	internal ICoreWebView2 _nativeICoreWebView2
	{
		get
		{
			if (_nativeICoreWebView2Value == null)
			{
				try
				{
					_nativeICoreWebView2Value = (ICoreWebView2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Value;
		}
		set
		{
			_nativeICoreWebView2Value = value;
		}
	}

	internal ICoreWebView2_2 _nativeICoreWebView2_2
	{
		get
		{
			if (_nativeICoreWebView2_2Value == null)
			{
				try
				{
					_nativeICoreWebView2_2Value = (ICoreWebView2_2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_2Value;
		}
		set
		{
			_nativeICoreWebView2_2Value = value;
		}
	}

	internal ICoreWebView2_3 _nativeICoreWebView2_3
	{
		get
		{
			if (_nativeICoreWebView2_3Value == null)
			{
				try
				{
					_nativeICoreWebView2_3Value = (ICoreWebView2_3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_3Value;
		}
		set
		{
			_nativeICoreWebView2_3Value = value;
		}
	}

	internal ICoreWebView2_4 _nativeICoreWebView2_4
	{
		get
		{
			if (_nativeICoreWebView2_4Value == null)
			{
				try
				{
					_nativeICoreWebView2_4Value = (ICoreWebView2_4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_4Value;
		}
		set
		{
			_nativeICoreWebView2_4Value = value;
		}
	}

	internal ICoreWebView2_5 _nativeICoreWebView2_5
	{
		get
		{
			if (_nativeICoreWebView2_5Value == null)
			{
				try
				{
					_nativeICoreWebView2_5Value = (ICoreWebView2_5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_5Value;
		}
		set
		{
			_nativeICoreWebView2_5Value = value;
		}
	}

	internal ICoreWebView2_6 _nativeICoreWebView2_6
	{
		get
		{
			if (_nativeICoreWebView2_6Value == null)
			{
				try
				{
					_nativeICoreWebView2_6Value = (ICoreWebView2_6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_6Value;
		}
		set
		{
			_nativeICoreWebView2_6Value = value;
		}
	}

	internal ICoreWebView2_7 _nativeICoreWebView2_7
	{
		get
		{
			if (_nativeICoreWebView2_7Value == null)
			{
				try
				{
					_nativeICoreWebView2_7Value = (ICoreWebView2_7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_7Value;
		}
		set
		{
			_nativeICoreWebView2_7Value = value;
		}
	}

	internal ICoreWebView2_8 _nativeICoreWebView2_8
	{
		get
		{
			if (_nativeICoreWebView2_8Value == null)
			{
				try
				{
					_nativeICoreWebView2_8Value = (ICoreWebView2_8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_8Value;
		}
		set
		{
			_nativeICoreWebView2_8Value = value;
		}
	}

	internal ICoreWebView2_9 _nativeICoreWebView2_9
	{
		get
		{
			if (_nativeICoreWebView2_9Value == null)
			{
				try
				{
					_nativeICoreWebView2_9Value = (ICoreWebView2_9)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_9Value;
		}
		set
		{
			_nativeICoreWebView2_9Value = value;
		}
	}

	internal ICoreWebView2_10 _nativeICoreWebView2_10
	{
		get
		{
			if (_nativeICoreWebView2_10Value == null)
			{
				try
				{
					_nativeICoreWebView2_10Value = (ICoreWebView2_10)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_10Value;
		}
		set
		{
			_nativeICoreWebView2_10Value = value;
		}
	}

	internal ICoreWebView2_11 _nativeICoreWebView2_11
	{
		get
		{
			if (_nativeICoreWebView2_11Value == null)
			{
				try
				{
					_nativeICoreWebView2_11Value = (ICoreWebView2_11)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_11Value;
		}
		set
		{
			_nativeICoreWebView2_11Value = value;
		}
	}

	internal ICoreWebView2_12 _nativeICoreWebView2_12
	{
		get
		{
			if (_nativeICoreWebView2_12Value == null)
			{
				try
				{
					_nativeICoreWebView2_12Value = (ICoreWebView2_12)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_12Value;
		}
		set
		{
			_nativeICoreWebView2_12Value = value;
		}
	}

	internal ICoreWebView2_13 _nativeICoreWebView2_13
	{
		get
		{
			if (_nativeICoreWebView2_13Value == null)
			{
				try
				{
					_nativeICoreWebView2_13Value = (ICoreWebView2_13)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_13Value;
		}
		set
		{
			_nativeICoreWebView2_13Value = value;
		}
	}

	internal ICoreWebView2_14 _nativeICoreWebView2_14
	{
		get
		{
			if (_nativeICoreWebView2_14Value == null)
			{
				try
				{
					_nativeICoreWebView2_14Value = (ICoreWebView2_14)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_14Value;
		}
		set
		{
			_nativeICoreWebView2_14Value = value;
		}
	}

	internal ICoreWebView2_15 _nativeICoreWebView2_15
	{
		get
		{
			if (_nativeICoreWebView2_15Value == null)
			{
				try
				{
					_nativeICoreWebView2_15Value = (ICoreWebView2_15)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_15Value;
		}
		set
		{
			_nativeICoreWebView2_15Value = value;
		}
	}

	internal ICoreWebView2_16 _nativeICoreWebView2_16
	{
		get
		{
			if (_nativeICoreWebView2_16Value == null)
			{
				try
				{
					_nativeICoreWebView2_16Value = (ICoreWebView2_16)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_16.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2_16Value;
		}
		set
		{
			_nativeICoreWebView2_16Value = value;
		}
	}

	internal ICoreWebView2Experimental19 _nativeICoreWebView2Experimental19
	{
		get
		{
			if (_nativeICoreWebView2Experimental19Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental19Value = (ICoreWebView2Experimental19)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental19.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental19Value;
		}
		set
		{
			_nativeICoreWebView2Experimental19Value = value;
		}
	}

	internal ICoreWebView2Experimental9 _nativeICoreWebView2Experimental9
	{
		get
		{
			if (_nativeICoreWebView2Experimental9Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental9Value = (ICoreWebView2Experimental9)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental9.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental9Value;
		}
		set
		{
			_nativeICoreWebView2Experimental9Value = value;
		}
	}

	internal ICoreWebView2Experimental18 _nativeICoreWebView2Experimental18
	{
		get
		{
			if (_nativeICoreWebView2Experimental18Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental18Value = (ICoreWebView2Experimental18)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental18.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental18Value;
		}
		set
		{
			_nativeICoreWebView2Experimental18Value = value;
		}
	}

	internal ICoreWebView2Experimental8 _nativeICoreWebView2Experimental8
	{
		get
		{
			if (_nativeICoreWebView2Experimental8Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental8Value = (ICoreWebView2Experimental8)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental8.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental8Value;
		}
		set
		{
			_nativeICoreWebView2Experimental8Value = value;
		}
	}

	internal ICoreWebView2Experimental17 _nativeICoreWebView2Experimental17
	{
		get
		{
			if (_nativeICoreWebView2Experimental17Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental17Value = (ICoreWebView2Experimental17)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental17.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental17Value;
		}
		set
		{
			_nativeICoreWebView2Experimental17Value = value;
		}
	}

	internal ICoreWebView2Experimental16 _nativeICoreWebView2Experimental16
	{
		get
		{
			if (_nativeICoreWebView2Experimental16Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental16Value = (ICoreWebView2Experimental16)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental16.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental16Value;
		}
		set
		{
			_nativeICoreWebView2Experimental16Value = value;
		}
	}

	internal ICoreWebView2Experimental15 _nativeICoreWebView2Experimental15
	{
		get
		{
			if (_nativeICoreWebView2Experimental15Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental15Value = (ICoreWebView2Experimental15)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental15.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental15Value;
		}
		set
		{
			_nativeICoreWebView2Experimental15Value = value;
		}
	}

	internal ICoreWebView2Experimental14 _nativeICoreWebView2Experimental14
	{
		get
		{
			if (_nativeICoreWebView2Experimental14Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental14Value = (ICoreWebView2Experimental14)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental14.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental14Value;
		}
		set
		{
			_nativeICoreWebView2Experimental14Value = value;
		}
	}

	internal ICoreWebView2Experimental13 _nativeICoreWebView2Experimental13
	{
		get
		{
			if (_nativeICoreWebView2Experimental13Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental13Value = (ICoreWebView2Experimental13)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental13.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental13Value;
		}
		set
		{
			_nativeICoreWebView2Experimental13Value = value;
		}
	}

	internal ICoreWebView2Experimental12 _nativeICoreWebView2Experimental12
	{
		get
		{
			if (_nativeICoreWebView2Experimental12Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental12Value = (ICoreWebView2Experimental12)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental12.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental12Value;
		}
		set
		{
			_nativeICoreWebView2Experimental12Value = value;
		}
	}

	internal ICoreWebView2Experimental11 _nativeICoreWebView2Experimental11
	{
		get
		{
			if (_nativeICoreWebView2Experimental11Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental11Value = (ICoreWebView2Experimental11)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental11.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental11Value;
		}
		set
		{
			_nativeICoreWebView2Experimental11Value = value;
		}
	}

	internal ICoreWebView2Experimental10 _nativeICoreWebView2Experimental10
	{
		get
		{
			if (_nativeICoreWebView2Experimental10Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental10Value = (ICoreWebView2Experimental10)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental10.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental10Value;
		}
		set
		{
			_nativeICoreWebView2Experimental10Value = value;
		}
	}

	internal ICoreWebView2Experimental7 _nativeICoreWebView2Experimental7
	{
		get
		{
			if (_nativeICoreWebView2Experimental7Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental7Value = (ICoreWebView2Experimental7)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental7.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental7Value;
		}
		set
		{
			_nativeICoreWebView2Experimental7Value = value;
		}
	}

	internal ICoreWebView2Experimental6 _nativeICoreWebView2Experimental6
	{
		get
		{
			if (_nativeICoreWebView2Experimental6Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental6Value = (ICoreWebView2Experimental6)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental6.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental6Value;
		}
		set
		{
			_nativeICoreWebView2Experimental6Value = value;
		}
	}

	internal ICoreWebView2Experimental5 _nativeICoreWebView2Experimental5
	{
		get
		{
			if (_nativeICoreWebView2Experimental5Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental5Value = (ICoreWebView2Experimental5)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental5.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental5Value;
		}
		set
		{
			_nativeICoreWebView2Experimental5Value = value;
		}
	}

	internal ICoreWebView2Experimental4 _nativeICoreWebView2Experimental4
	{
		get
		{
			if (_nativeICoreWebView2Experimental4Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental4Value = (ICoreWebView2Experimental4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental4Value;
		}
		set
		{
			_nativeICoreWebView2Experimental4Value = value;
		}
	}

	internal ICoreWebView2Experimental3 _nativeICoreWebView2Experimental3
	{
		get
		{
			if (_nativeICoreWebView2Experimental3Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental3Value = (ICoreWebView2Experimental3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental3Value;
		}
		set
		{
			_nativeICoreWebView2Experimental3Value = value;
		}
	}

	internal ICoreWebView2Experimental2 _nativeICoreWebView2Experimental2
	{
		get
		{
			if (_nativeICoreWebView2Experimental2Value == null)
			{
				try
				{
					_nativeICoreWebView2Experimental2Value = (ICoreWebView2Experimental2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Experimental2Value;
		}
		set
		{
			_nativeICoreWebView2Experimental2Value = value;
		}
	}

	internal ICoreWebView2Experimental _nativeICoreWebView2Experimental
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalValue = (ICoreWebView2Experimental)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Experimental.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalValue = value;
		}
	}

	internal ICoreWebView2PrivatePartial _nativeICoreWebView2PrivatePartial
	{
		get
		{
			if (_nativeICoreWebView2PrivatePartialValue == null)
			{
				try
				{
					_nativeICoreWebView2PrivatePartialValue = (ICoreWebView2PrivatePartial)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivatePartial.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrivatePartialValue;
		}
		set
		{
			_nativeICoreWebView2PrivatePartialValue = value;
		}
	}

	public CoreWebView2Settings Settings
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2.Settings == null) ? null : new CoreWebView2Settings(_nativeICoreWebView2.Settings);
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

	public string Source
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.Source;
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

	public uint BrowserProcessId
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.BrowserProcessId;
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

	public bool CanGoBack
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.CanGoBack != 0;
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

	public bool CanGoForward
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.CanGoForward != 0;
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

	public string DocumentTitle
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.DocumentTitle;
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

	public bool ContainsFullScreenElement
	{
		get
		{
			try
			{
				return _nativeICoreWebView2.ContainsFullScreenElement != 0;
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

	public CoreWebView2CookieManager CookieManager
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_2.CookieManager == null) ? null : new CoreWebView2CookieManager(_nativeICoreWebView2_2.CookieManager);
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

	public CoreWebView2Environment Environment
	{
		get
		{
			try
			{
				return (_nativeICoreWebView2_2.Environment == null) ? null : new CoreWebView2Environment(_nativeICoreWebView2_2.Environment);
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

	public bool IsSuspended
	{
		get
		{
			try
			{
				return _nativeICoreWebView2_3.IsSuspended != 0;
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

	public bool IsMuted
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2_8.IsMuted != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2Experimental9.IsMuted != 0;
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
					_nativeICoreWebView2_8.IsMuted = (value ? 1 : 0);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental9.IsMuted = (value ? 1 : 0);
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

	public bool IsDocumentPlayingAudio
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2_8.IsDocumentPlayingAudio != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2Experimental9.IsDocumentPlayingAudio != 0;
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

	public bool IsDefaultDownloadDialogOpen
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2_9.IsDefaultDownloadDialogOpen != 0;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2Experimental11.IsDefaultDownloadDialogOpen != 0;
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

	public CoreWebView2DefaultDownloadDialogCornerAlignment DefaultDownloadDialogCornerAlignment
	{
		get
		{
			try
			{
				try
				{
					return (CoreWebView2DefaultDownloadDialogCornerAlignment)_nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment;
				}
				catch (NotImplementedException)
				{
					return (CoreWebView2DefaultDownloadDialogCornerAlignment)_nativeICoreWebView2Experimental11.DefaultDownloadDialogCornerAlignment;
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
					_nativeICoreWebView2_9.DefaultDownloadDialogCornerAlignment = (COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT)value;
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental11.DefaultDownloadDialogCornerAlignment = (COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT)value;
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

	public Point DefaultDownloadDialogMargin
	{
		get
		{
			try
			{
				try
				{
					return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2_9.DefaultDownloadDialogMargin);
				}
				catch (NotImplementedException)
				{
					return COMDotNetTypeConverter.PointCOMToNet(_nativeICoreWebView2Experimental11.DefaultDownloadDialogMargin);
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
					_nativeICoreWebView2_9.DefaultDownloadDialogMargin = COMDotNetTypeConverter.PointNetToCOM(value);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental11.DefaultDownloadDialogMargin = COMDotNetTypeConverter.PointNetToCOM(value);
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

	public string StatusBarText
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2_12.StatusBarText;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2Experimental13.StatusBarText;
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

	public CoreWebView2Profile Profile
	{
		get
		{
			try
			{
				try
				{
					return (_nativeICoreWebView2_13.Profile == null) ? null : new CoreWebView2Profile(_nativeICoreWebView2_13.Profile);
				}
				catch (NotImplementedException)
				{
					return (_nativeICoreWebView2Experimental8.Profile == null) ? null : new CoreWebView2Profile(_nativeICoreWebView2Experimental8.Profile);
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

	public string FaviconUri
	{
		get
		{
			try
			{
				try
				{
					return _nativeICoreWebView2_15.FaviconUri;
				}
				catch (NotImplementedException)
				{
					return _nativeICoreWebView2Experimental12.FaviconUri;
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

	public CoreWebView2MemoryUsageTargetLevel MemoryUsageTargetLevel
	{
		get
		{
			try
			{
				return (CoreWebView2MemoryUsageTargetLevel)_nativeICoreWebView2Experimental5.MemoryUsageTargetLevel;
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
				_nativeICoreWebView2Experimental5.MemoryUsageTargetLevel = (COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL)value;
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

	public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting
	{
		add
		{
			if (navigationStarting == null)
			{
				try
				{
					_nativeICoreWebView2.add_NavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
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
			navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(navigationStarting, value);
		}
		remove
		{
			navigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(navigationStarting, value);
			if (navigationStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NavigationStarting(_navigationStartingToken);
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

	public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
	{
		add
		{
			if (contentLoading == null)
			{
				try
				{
					_nativeICoreWebView2.add_ContentLoading(new CoreWebView2ContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
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
			contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Combine(contentLoading, value);
		}
		remove
		{
			contentLoading = (EventHandler<CoreWebView2ContentLoadingEventArgs>)Delegate.Remove(contentLoading, value);
			if (contentLoading != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ContentLoading(_contentLoadingToken);
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

	public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
	{
		add
		{
			if (sourceChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_SourceChanged(new CoreWebView2SourceChangedEventHandler(OnSourceChanged), out _sourceChangedToken);
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
			sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Combine(sourceChanged, value);
		}
		remove
		{
			sourceChanged = (EventHandler<CoreWebView2SourceChangedEventArgs>)Delegate.Remove(sourceChanged, value);
			if (sourceChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_SourceChanged(_sourceChangedToken);
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

	public event EventHandler<object> HistoryChanged
	{
		add
		{
			if (historyChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_HistoryChanged(new CoreWebView2HistoryChangedEventHandler(OnHistoryChanged), out _historyChangedToken);
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
			historyChanged = (EventHandler<object>)Delegate.Combine(historyChanged, value);
		}
		remove
		{
			historyChanged = (EventHandler<object>)Delegate.Remove(historyChanged, value);
			if (historyChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_HistoryChanged(_historyChangedToken);
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

	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
	{
		add
		{
			if (navigationCompleted == null)
			{
				try
				{
					_nativeICoreWebView2.add_NavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
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
			navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(navigationCompleted, value);
		}
		remove
		{
			navigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(navigationCompleted, value);
			if (navigationCompleted != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NavigationCompleted(_navigationCompletedToken);
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

	public event EventHandler<CoreWebView2NavigationStartingEventArgs> FrameNavigationStarting
	{
		add
		{
			if (frameNavigationStarting == null)
			{
				try
				{
					_nativeICoreWebView2.add_FrameNavigationStarting(new CoreWebView2NavigationStartingEventHandler(OnFrameNavigationStarting), out _frameNavigationStartingToken);
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
			frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Combine(frameNavigationStarting, value);
		}
		remove
		{
			frameNavigationStarting = (EventHandler<CoreWebView2NavigationStartingEventArgs>)Delegate.Remove(frameNavigationStarting, value);
			if (frameNavigationStarting != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_FrameNavigationStarting(_frameNavigationStartingToken);
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

	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> FrameNavigationCompleted
	{
		add
		{
			if (frameNavigationCompleted == null)
			{
				try
				{
					_nativeICoreWebView2.add_FrameNavigationCompleted(new CoreWebView2NavigationCompletedEventHandler(OnFrameNavigationCompleted), out _frameNavigationCompletedToken);
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
			frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Combine(frameNavigationCompleted, value);
		}
		remove
		{
			frameNavigationCompleted = (EventHandler<CoreWebView2NavigationCompletedEventArgs>)Delegate.Remove(frameNavigationCompleted, value);
			if (frameNavigationCompleted != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_FrameNavigationCompleted(_frameNavigationCompletedToken);
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

	public event EventHandler<CoreWebView2ScriptDialogOpeningEventArgs> ScriptDialogOpening
	{
		add
		{
			if (scriptDialogOpening == null)
			{
				try
				{
					_nativeICoreWebView2.add_ScriptDialogOpening(new CoreWebView2ScriptDialogOpeningEventHandler(OnScriptDialogOpening), out _scriptDialogOpeningToken);
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
			scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Combine(scriptDialogOpening, value);
		}
		remove
		{
			scriptDialogOpening = (EventHandler<CoreWebView2ScriptDialogOpeningEventArgs>)Delegate.Remove(scriptDialogOpening, value);
			if (scriptDialogOpening != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ScriptDialogOpening(_scriptDialogOpeningToken);
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

	public event EventHandler<CoreWebView2PermissionRequestedEventArgs> PermissionRequested
	{
		add
		{
			if (permissionRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_PermissionRequested(new CoreWebView2PermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
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
			permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Combine(permissionRequested, value);
		}
		remove
		{
			permissionRequested = (EventHandler<CoreWebView2PermissionRequestedEventArgs>)Delegate.Remove(permissionRequested, value);
			if (permissionRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_PermissionRequested(_permissionRequestedToken);
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

	public event EventHandler<CoreWebView2ProcessFailedEventArgs> ProcessFailed
	{
		add
		{
			if (processFailed == null)
			{
				try
				{
					_nativeICoreWebView2.add_ProcessFailed(new CoreWebView2ProcessFailedEventHandler(OnProcessFailed), out _processFailedToken);
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
			processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Combine(processFailed, value);
		}
		remove
		{
			processFailed = (EventHandler<CoreWebView2ProcessFailedEventArgs>)Delegate.Remove(processFailed, value);
			if (processFailed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ProcessFailed(_processFailedToken);
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

	public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
	{
		add
		{
			if (webMessageReceived == null)
			{
				try
				{
					_nativeICoreWebView2.add_WebMessageReceived(new CoreWebView2WebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
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
			webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Combine(webMessageReceived, value);
		}
		remove
		{
			webMessageReceived = (EventHandler<CoreWebView2WebMessageReceivedEventArgs>)Delegate.Remove(webMessageReceived, value);
			if (webMessageReceived != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WebMessageReceived(_webMessageReceivedToken);
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

	public event EventHandler<CoreWebView2NewWindowRequestedEventArgs> NewWindowRequested
	{
		add
		{
			if (newWindowRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_NewWindowRequested(new CoreWebView2NewWindowRequestedEventHandler(OnNewWindowRequested), out _newWindowRequestedToken);
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
			newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Combine(newWindowRequested, value);
		}
		remove
		{
			newWindowRequested = (EventHandler<CoreWebView2NewWindowRequestedEventArgs>)Delegate.Remove(newWindowRequested, value);
			if (newWindowRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_NewWindowRequested(_newWindowRequestedToken);
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

	public event EventHandler<object> DocumentTitleChanged
	{
		add
		{
			if (documentTitleChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_DocumentTitleChanged(new CoreWebView2DocumentTitleChangedEventHandler(OnDocumentTitleChanged), out _documentTitleChangedToken);
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
			documentTitleChanged = (EventHandler<object>)Delegate.Combine(documentTitleChanged, value);
		}
		remove
		{
			documentTitleChanged = (EventHandler<object>)Delegate.Remove(documentTitleChanged, value);
			if (documentTitleChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_DocumentTitleChanged(_documentTitleChangedToken);
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

	public event EventHandler<object> ContainsFullScreenElementChanged
	{
		add
		{
			if (containsFullScreenElementChanged == null)
			{
				try
				{
					_nativeICoreWebView2.add_ContainsFullScreenElementChanged(new CoreWebView2ContainsFullScreenElementChangedEventHandler(OnContainsFullScreenElementChanged), out _containsFullScreenElementChangedToken);
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
			containsFullScreenElementChanged = (EventHandler<object>)Delegate.Combine(containsFullScreenElementChanged, value);
		}
		remove
		{
			containsFullScreenElementChanged = (EventHandler<object>)Delegate.Remove(containsFullScreenElementChanged, value);
			if (containsFullScreenElementChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_ContainsFullScreenElementChanged(_containsFullScreenElementChangedToken);
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

	public event EventHandler<CoreWebView2WebResourceRequestedEventArgs> WebResourceRequested
	{
		add
		{
			if (webResourceRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_WebResourceRequested(new CoreWebView2WebResourceRequestedEventHandler(OnWebResourceRequested), out _webResourceRequestedToken);
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
			webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Combine(webResourceRequested, value);
		}
		remove
		{
			webResourceRequested = (EventHandler<CoreWebView2WebResourceRequestedEventArgs>)Delegate.Remove(webResourceRequested, value);
			if (webResourceRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WebResourceRequested(_webResourceRequestedToken);
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

	public event EventHandler<object> WindowCloseRequested
	{
		add
		{
			if (windowCloseRequested == null)
			{
				try
				{
					_nativeICoreWebView2.add_WindowCloseRequested(new CoreWebView2WindowCloseRequestedEventHandler(OnWindowCloseRequested), out _windowCloseRequestedToken);
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
			windowCloseRequested = (EventHandler<object>)Delegate.Combine(windowCloseRequested, value);
		}
		remove
		{
			windowCloseRequested = (EventHandler<object>)Delegate.Remove(windowCloseRequested, value);
			if (windowCloseRequested != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2.remove_WindowCloseRequested(_windowCloseRequestedToken);
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

	public event EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs> WebResourceResponseReceived
	{
		add
		{
			if (webResourceResponseReceived == null)
			{
				try
				{
					_nativeICoreWebView2_2.add_WebResourceResponseReceived(new CoreWebView2WebResourceResponseReceivedEventHandler(OnWebResourceResponseReceived), out _webResourceResponseReceivedToken);
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
			webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Combine(webResourceResponseReceived, value);
		}
		remove
		{
			webResourceResponseReceived = (EventHandler<CoreWebView2WebResourceResponseReceivedEventArgs>)Delegate.Remove(webResourceResponseReceived, value);
			if (webResourceResponseReceived != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_2.remove_WebResourceResponseReceived(_webResourceResponseReceivedToken);
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

	public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
	{
		add
		{
			if (dOMContentLoaded == null)
			{
				try
				{
					_nativeICoreWebView2_2.add_DOMContentLoaded(new CoreWebView2DOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
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
			dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Combine(dOMContentLoaded, value);
		}
		remove
		{
			dOMContentLoaded = (EventHandler<CoreWebView2DOMContentLoadedEventArgs>)Delegate.Remove(dOMContentLoaded, value);
			if (dOMContentLoaded != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2_2.remove_DOMContentLoaded(_dOMContentLoadedToken);
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

	public event EventHandler<CoreWebView2FrameCreatedEventArgs> FrameCreated
	{
		add
		{
			if (frameCreated == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_4.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler(OnFrameCreated), out _frameCreatedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler(OnFrameCreated), out _frameCreatedToken);
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
			frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Combine(frameCreated, value);
		}
		remove
		{
			frameCreated = (EventHandler<CoreWebView2FrameCreatedEventArgs>)Delegate.Remove(frameCreated, value);
			if (frameCreated != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_4.remove_FrameCreated(_frameCreatedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental.remove_FrameCreated(_frameCreatedToken);
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

	public event EventHandler<CoreWebView2DownloadStartingEventArgs> DownloadStarting
	{
		add
		{
			if (downloadStarting == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_4.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler(OnDownloadStarting), out _downloadStartingToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental2.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler(OnDownloadStarting), out _downloadStartingToken);
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
			downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Combine(downloadStarting, value);
		}
		remove
		{
			downloadStarting = (EventHandler<CoreWebView2DownloadStartingEventArgs>)Delegate.Remove(downloadStarting, value);
			if (downloadStarting != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_4.remove_DownloadStarting(_downloadStartingToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental2.remove_DownloadStarting(_downloadStartingToken);
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

	public event EventHandler<CoreWebView2ClientCertificateRequestedEventArgs> ClientCertificateRequested
	{
		add
		{
			if (clientCertificateRequested == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_5.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler(OnClientCertificateRequested), out _clientCertificateRequestedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental3.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler(OnClientCertificateRequested), out _clientCertificateRequestedToken);
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
			clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Combine(clientCertificateRequested, value);
		}
		remove
		{
			clientCertificateRequested = (EventHandler<CoreWebView2ClientCertificateRequestedEventArgs>)Delegate.Remove(clientCertificateRequested, value);
			if (clientCertificateRequested != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_5.remove_ClientCertificateRequested(_clientCertificateRequestedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental3.remove_ClientCertificateRequested(_clientCertificateRequestedToken);
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

	public event EventHandler<object> IsMutedChanged
	{
		add
		{
			if (isMutedChanged == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_8.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler(OnIsMutedChanged), out _isMutedChangedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental9.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler(OnIsMutedChanged), out _isMutedChangedToken);
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
			isMutedChanged = (EventHandler<object>)Delegate.Combine(isMutedChanged, value);
		}
		remove
		{
			isMutedChanged = (EventHandler<object>)Delegate.Remove(isMutedChanged, value);
			if (isMutedChanged != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_8.remove_IsMutedChanged(_isMutedChangedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental9.remove_IsMutedChanged(_isMutedChangedToken);
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

	public event EventHandler<object> IsDocumentPlayingAudioChanged
	{
		add
		{
			if (isDocumentPlayingAudioChanged == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_8.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler(OnIsDocumentPlayingAudioChanged), out _isDocumentPlayingAudioChangedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental9.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler(OnIsDocumentPlayingAudioChanged), out _isDocumentPlayingAudioChangedToken);
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
			isDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Combine(isDocumentPlayingAudioChanged, value);
		}
		remove
		{
			isDocumentPlayingAudioChanged = (EventHandler<object>)Delegate.Remove(isDocumentPlayingAudioChanged, value);
			if (isDocumentPlayingAudioChanged != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_8.remove_IsDocumentPlayingAudioChanged(_isDocumentPlayingAudioChangedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental9.remove_IsDocumentPlayingAudioChanged(_isDocumentPlayingAudioChangedToken);
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

	public event EventHandler<object> IsDefaultDownloadDialogOpenChanged
	{
		add
		{
			if (isDefaultDownloadDialogOpenChanged == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_9.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(OnIsDefaultDownloadDialogOpenChanged), out _isDefaultDownloadDialogOpenChangedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental11.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(OnIsDefaultDownloadDialogOpenChanged), out _isDefaultDownloadDialogOpenChangedToken);
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
			isDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Combine(isDefaultDownloadDialogOpenChanged, value);
		}
		remove
		{
			isDefaultDownloadDialogOpenChanged = (EventHandler<object>)Delegate.Remove(isDefaultDownloadDialogOpenChanged, value);
			if (isDefaultDownloadDialogOpenChanged != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_9.remove_IsDefaultDownloadDialogOpenChanged(_isDefaultDownloadDialogOpenChangedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental11.remove_IsDefaultDownloadDialogOpenChanged(_isDefaultDownloadDialogOpenChangedToken);
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

	public event EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs> BasicAuthenticationRequested
	{
		add
		{
			if (basicAuthenticationRequested == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_10.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler(OnBasicAuthenticationRequested), out _basicAuthenticationRequestedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental10.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler(OnBasicAuthenticationRequested), out _basicAuthenticationRequestedToken);
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
			basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Combine(basicAuthenticationRequested, value);
		}
		remove
		{
			basicAuthenticationRequested = (EventHandler<CoreWebView2BasicAuthenticationRequestedEventArgs>)Delegate.Remove(basicAuthenticationRequested, value);
			if (basicAuthenticationRequested != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_10.remove_BasicAuthenticationRequested(_basicAuthenticationRequestedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental10.remove_BasicAuthenticationRequested(_basicAuthenticationRequestedToken);
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

	public event EventHandler<CoreWebView2ContextMenuRequestedEventArgs> ContextMenuRequested
	{
		add
		{
			if (contextMenuRequested == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_11.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler(OnContextMenuRequested), out _contextMenuRequestedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental6.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler(OnContextMenuRequested), out _contextMenuRequestedToken);
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
			contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Combine(contextMenuRequested, value);
		}
		remove
		{
			contextMenuRequested = (EventHandler<CoreWebView2ContextMenuRequestedEventArgs>)Delegate.Remove(contextMenuRequested, value);
			if (contextMenuRequested != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_11.remove_ContextMenuRequested(_contextMenuRequestedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental6.remove_ContextMenuRequested(_contextMenuRequestedToken);
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

	public event EventHandler<object> StatusBarTextChanged
	{
		add
		{
			if (statusBarTextChanged == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_12.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler(OnStatusBarTextChanged), out _statusBarTextChangedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental13.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler(OnStatusBarTextChanged), out _statusBarTextChangedToken);
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
			statusBarTextChanged = (EventHandler<object>)Delegate.Combine(statusBarTextChanged, value);
		}
		remove
		{
			statusBarTextChanged = (EventHandler<object>)Delegate.Remove(statusBarTextChanged, value);
			if (statusBarTextChanged != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_12.remove_StatusBarTextChanged(_statusBarTextChangedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental13.remove_StatusBarTextChanged(_statusBarTextChangedToken);
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

	public event EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs> ServerCertificateErrorDetected
	{
		add
		{
			if (serverCertificateErrorDetected == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_14.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler(OnServerCertificateErrorDetected), out _serverCertificateErrorDetectedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental15.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler(OnServerCertificateErrorDetected), out _serverCertificateErrorDetectedToken);
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
			serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Combine(serverCertificateErrorDetected, value);
		}
		remove
		{
			serverCertificateErrorDetected = (EventHandler<CoreWebView2ServerCertificateErrorDetectedEventArgs>)Delegate.Remove(serverCertificateErrorDetected, value);
			if (serverCertificateErrorDetected != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_14.remove_ServerCertificateErrorDetected(_serverCertificateErrorDetectedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental15.remove_ServerCertificateErrorDetected(_serverCertificateErrorDetectedToken);
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

	public event EventHandler<object> FaviconChanged
	{
		add
		{
			if (faviconChanged == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2_15.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler(OnFaviconChanged), out _faviconChangedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2Experimental12.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler(OnFaviconChanged), out _faviconChangedToken);
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
			faviconChanged = (EventHandler<object>)Delegate.Combine(faviconChanged, value);
		}
		remove
		{
			faviconChanged = (EventHandler<object>)Delegate.Remove(faviconChanged, value);
			if (faviconChanged != null)
			{
				return;
			}
			try
			{
				try
				{
					_nativeICoreWebView2_15.remove_FaviconChanged(_faviconChangedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2Experimental12.remove_FaviconChanged(_faviconChangedToken);
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

	public async Task<bool> PrintToPdfAsync(string ResultFilePath, CoreWebView2PrintSettings printSettings = null)
	{
		CoreWebView2PrintToPdfCompletedHandler handler;
		try
		{
			handler = new CoreWebView2PrintToPdfCompletedHandler();
			ICoreWebView2PrintSettings printSettings2 = printSettings?._nativeICoreWebView2PrintSettings;
			try
			{
				_nativeICoreWebView2_7.PrintToPdf(ResultFilePath, printSettings2, handler);
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2Experimental7.PrintToPdf(ResultFilePath, printSettings2, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.isSuccessful;
	}

	public void AddWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext, CoreWebView2WebResourceRequestSourceKinds RequestSourceKinds)
	{
		try
		{
			_nativeICoreWebView2Experimental16.AddWebResourceRequestedFilterWithRequestSourceKinds(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext, (COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS)RequestSourceKinds);
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

	public void RemoveWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext, CoreWebView2WebResourceRequestSourceKinds RequestSourceKinds)
	{
		try
		{
			_nativeICoreWebView2Experimental16.RemoveWebResourceRequestedFilterWithRequestSourceKinds(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext, (COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS)RequestSourceKinds);
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

	public void ShowPrintUI()
	{
		try
		{
			CoreWebView2PrintDialogKind printDialogKind = CoreWebView2PrintDialogKind.Browser;
			_nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
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

	internal CoreWebView2(object rawCoreWebView2)
	{
		_rawNative = rawCoreWebView2;
	}

	internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		navigationStarting?.Invoke(this, args);
	}

	internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
	{
		contentLoading?.Invoke(this, args);
	}

	internal void OnSourceChanged(CoreWebView2SourceChangedEventArgs args)
	{
		sourceChanged?.Invoke(this, args);
	}

	internal void OnHistoryChanged(object args)
	{
		historyChanged?.Invoke(this, args);
	}

	internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		navigationCompleted?.Invoke(this, args);
	}

	internal void OnFrameNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		frameNavigationStarting?.Invoke(this, args);
	}

	internal void OnFrameNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		frameNavigationCompleted?.Invoke(this, args);
	}

	internal void OnScriptDialogOpening(CoreWebView2ScriptDialogOpeningEventArgs args)
	{
		scriptDialogOpening?.Invoke(this, args);
	}

	internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
	{
		permissionRequested?.Invoke(this, args);
	}

	internal void OnProcessFailed(CoreWebView2ProcessFailedEventArgs args)
	{
		processFailed?.Invoke(this, args);
	}

	internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
	{
		webMessageReceived?.Invoke(this, args);
	}

	internal void OnNewWindowRequested(CoreWebView2NewWindowRequestedEventArgs args)
	{
		newWindowRequested?.Invoke(this, args);
	}

	internal void OnDocumentTitleChanged(object args)
	{
		documentTitleChanged?.Invoke(this, args);
	}

	internal void OnContainsFullScreenElementChanged(object args)
	{
		containsFullScreenElementChanged?.Invoke(this, args);
	}

	internal void OnWebResourceRequested(CoreWebView2WebResourceRequestedEventArgs args)
	{
		webResourceRequested?.Invoke(this, args);
	}

	internal void OnWindowCloseRequested(object args)
	{
		windowCloseRequested?.Invoke(this, args);
	}

	public void Navigate(string uri)
	{
		try
		{
			_nativeICoreWebView2.Navigate(uri);
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

	public void NavigateToString(string htmlContent)
	{
		try
		{
			_nativeICoreWebView2.NavigateToString(htmlContent);
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

	public async Task<string> AddScriptToExecuteOnDocumentCreatedAsync(string javaScript)
	{
		CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler;
		try
		{
			handler = new CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler();
			_nativeICoreWebView2.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
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
		return handler.id;
	}

	public void RemoveScriptToExecuteOnDocumentCreated(string id)
	{
		try
		{
			_nativeICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(id);
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

	public async Task<string> ExecuteScriptAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ExecuteScriptCompletedHandler();
			_nativeICoreWebView2.ExecuteScript(javaScript, handler);
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
		return handler.resultObjectAsJson;
	}

	public async Task CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat imageFormat, Stream imageStream)
	{
		CoreWebView2CapturePreviewCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CapturePreviewCompletedHandler();
			_nativeICoreWebView2.CapturePreview((COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT)imageFormat, (imageStream == null) ? null : new ManagedIStream(imageStream), handler);
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
	}

	public void Reload()
	{
		try
		{
			_nativeICoreWebView2.Reload();
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

	public void PostWebMessageAsJson(string webMessageAsJson)
	{
		try
		{
			_nativeICoreWebView2.PostWebMessageAsJson(webMessageAsJson);
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

	public void PostWebMessageAsString(string webMessageAsString)
	{
		try
		{
			_nativeICoreWebView2.PostWebMessageAsString(webMessageAsString);
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

	public async Task<string> CallDevToolsProtocolMethodAsync(string methodName, string parametersAsJson)
	{
		CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
		try
		{
			handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
			_nativeICoreWebView2.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
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
		return handler.returnObjectAsJson;
	}

	public void GoBack()
	{
		try
		{
			_nativeICoreWebView2.GoBack();
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

	public void GoForward()
	{
		try
		{
			_nativeICoreWebView2.GoForward();
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

	public CoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(string eventName)
	{
		try
		{
			return new CoreWebView2DevToolsProtocolEventReceiver(_nativeICoreWebView2.GetDevToolsProtocolEventReceiver(eventName));
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

	public void Stop()
	{
		try
		{
			_nativeICoreWebView2.Stop();
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

	public void AddHostObjectToScript(string name, object rawObject)
	{
		try
		{
			ICoreWebView2 nativeICoreWebView = _nativeICoreWebView2;
			object @object = rawObject;
			nativeICoreWebView.AddHostObjectToScript(name, ref @object);
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

	public void RemoveHostObjectFromScript(string name)
	{
		try
		{
			_nativeICoreWebView2.RemoveHostObjectFromScript(name);
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

	public void OpenDevToolsWindow()
	{
		try
		{
			_nativeICoreWebView2.OpenDevToolsWindow();
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

	public void AddWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
	{
		try
		{
			_nativeICoreWebView2.AddWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

	public void RemoveWebResourceRequestedFilter(string uri, CoreWebView2WebResourceContext ResourceContext)
	{
		try
		{
			_nativeICoreWebView2.RemoveWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

	internal void OnWebResourceResponseReceived(CoreWebView2WebResourceResponseReceivedEventArgs args)
	{
		webResourceResponseReceived?.Invoke(this, args);
	}

	internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
	{
		dOMContentLoaded?.Invoke(this, args);
	}

	public void NavigateWithWebResourceRequest(CoreWebView2WebResourceRequest Request)
	{
		try
		{
			_nativeICoreWebView2_2.NavigateWithWebResourceRequest(Request._nativeICoreWebView2WebResourceRequest);
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

	public async Task<bool> TrySuspendAsync()
	{
		CoreWebView2TrySuspendCompletedHandler handler;
		try
		{
			handler = new CoreWebView2TrySuspendCompletedHandler();
			_nativeICoreWebView2_3.TrySuspend(handler);
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
		return handler.isSuccessful;
	}

	public void Resume()
	{
		try
		{
			_nativeICoreWebView2_3.Resume();
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

	public void SetVirtualHostNameToFolderMapping(string hostName, string folderPath, CoreWebView2HostResourceAccessKind accessKind)
	{
		try
		{
			_nativeICoreWebView2_3.SetVirtualHostNameToFolderMapping(hostName, folderPath, (COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND)accessKind);
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

	public void ClearVirtualHostNameToFolderMapping(string hostName)
	{
		try
		{
			_nativeICoreWebView2_3.ClearVirtualHostNameToFolderMapping(hostName);
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

	internal void OnFrameCreated(CoreWebView2FrameCreatedEventArgs args)
	{
		frameCreated?.Invoke(this, args);
	}

	internal void OnDownloadStarting(CoreWebView2DownloadStartingEventArgs args)
	{
		downloadStarting?.Invoke(this, args);
	}

	internal void OnClientCertificateRequested(CoreWebView2ClientCertificateRequestedEventArgs args)
	{
		clientCertificateRequested?.Invoke(this, args);
	}

	public void OpenTaskManagerWindow()
	{
		try
		{
			try
			{
				_nativeICoreWebView2_6.OpenTaskManagerWindow();
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2Experimental4.OpenTaskManagerWindow();
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

	internal void OnIsMutedChanged(object args)
	{
		isMutedChanged?.Invoke(this, args);
	}

	internal void OnIsDocumentPlayingAudioChanged(object args)
	{
		isDocumentPlayingAudioChanged?.Invoke(this, args);
	}

	internal void OnIsDefaultDownloadDialogOpenChanged(object args)
	{
		isDefaultDownloadDialogOpenChanged?.Invoke(this, args);
	}

	public void OpenDefaultDownloadDialog()
	{
		try
		{
			try
			{
				_nativeICoreWebView2_9.OpenDefaultDownloadDialog();
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2Experimental11.OpenDefaultDownloadDialog();
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

	public void CloseDefaultDownloadDialog()
	{
		try
		{
			try
			{
				_nativeICoreWebView2_9.CloseDefaultDownloadDialog();
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2Experimental11.CloseDefaultDownloadDialog();
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

	internal void OnBasicAuthenticationRequested(CoreWebView2BasicAuthenticationRequestedEventArgs args)
	{
		basicAuthenticationRequested?.Invoke(this, args);
	}

	internal void OnContextMenuRequested(CoreWebView2ContextMenuRequestedEventArgs args)
	{
		contextMenuRequested?.Invoke(this, args);
	}

	public async Task<string> CallDevToolsProtocolMethodForSessionAsync(string sessionId, string methodName, string parametersAsJson)
	{
		CoreWebView2CallDevToolsProtocolMethodCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
				_nativeICoreWebView2_11.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2CallDevToolsProtocolMethodCompletedHandler();
				_nativeICoreWebView2Experimental14.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.returnObjectAsJson;
	}

	internal void OnStatusBarTextChanged(object args)
	{
		statusBarTextChanged?.Invoke(this, args);
	}

	internal void OnServerCertificateErrorDetected(CoreWebView2ServerCertificateErrorDetectedEventArgs args)
	{
		serverCertificateErrorDetected?.Invoke(this, args);
	}

	public async Task ClearServerCertificateErrorActionsAsync()
	{
		CoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler();
				_nativeICoreWebView2_14.ClearServerCertificateErrorActions(handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler();
				_nativeICoreWebView2Experimental15.ClearServerCertificateErrorActions(handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
	}

	internal void OnFaviconChanged(object args)
	{
		faviconChanged?.Invoke(this, args);
	}

	public async Task<Stream> GetFaviconAsync(CoreWebView2FaviconImageFormat format)
	{
		CoreWebView2GetFaviconCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2GetFaviconCompletedHandler();
				_nativeICoreWebView2_15.GetFavicon((COREWEBVIEW2_FAVICON_IMAGE_FORMAT)format, handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2GetFaviconCompletedHandler();
				_nativeICoreWebView2Experimental12.GetFavicon((COREWEBVIEW2_FAVICON_IMAGE_FORMAT)format, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.faviconStream;
	}

	public async Task<CoreWebView2PrintStatus> PrintAsync(CoreWebView2PrintSettings printSettings)
	{
		CoreWebView2PrintCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2PrintCompletedHandler();
				_nativeICoreWebView2_16.Print(printSettings._nativeICoreWebView2PrintSettings, handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2PrintCompletedHandler();
				_nativeICoreWebView2Experimental17.Print(printSettings._nativeICoreWebView2PrintSettings, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.printStatus;
	}

	public void ShowPrintUI(CoreWebView2PrintDialogKind printDialogKind)
	{
		try
		{
			try
			{
				_nativeICoreWebView2_16.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2Experimental17.ShowPrintUI((COREWEBVIEW2_PRINT_DIALOG_KIND)printDialogKind);
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

	public async Task<Stream> PrintToPdfStreamAsync(CoreWebView2PrintSettings printSettings)
	{
		CoreWebView2PrintToPdfStreamCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2PrintToPdfStreamCompletedHandler();
				_nativeICoreWebView2_16.PrintToPdfStream(printSettings._nativeICoreWebView2PrintSettings, handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2PrintToPdfStreamCompletedHandler();
				_nativeICoreWebView2Experimental17.PrintToPdfStream(printSettings._nativeICoreWebView2PrintSettings, handler);
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
		await handler;
		Marshal.ThrowExceptionForHR(handler.errCode);
		return handler.pdfStream;
	}

	public async Task<CoreWebView2ExecuteScriptResult> ExecuteScriptWithResultAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptWithResultCompletedHandler handler;
		try
		{
			handler = new CoreWebView2ExecuteScriptWithResultCompletedHandler();
			_nativeICoreWebView2Experimental19.ExecuteScriptWithResult(javaScript, handler);
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

	public void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, string additionalDataAsJson)
	{
		try
		{
			_nativeICoreWebView2Experimental18.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2ExperimentalSharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
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

	internal void AddHostObjectHelper(CoreWebView2PrivateHostObjectHelper helper)
	{
		try
		{
			_nativeICoreWebView2PrivatePartial.AddHostObjectHelper(helper._nativeICoreWebView2PrivateHostObjectHelper);
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
