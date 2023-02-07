using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2Frame
{
	internal ICoreWebView2Frame _nativeICoreWebView2FrameValue;

	internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2Value;

	internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3Value;

	internal ICoreWebView2ExperimentalFrame4 _nativeICoreWebView2ExperimentalFrame4Value;

	internal ICoreWebView2ExperimentalFrame3 _nativeICoreWebView2ExperimentalFrame3Value;

	internal ICoreWebView2ExperimentalFrame2 _nativeICoreWebView2ExperimentalFrame2Value;

	internal ICoreWebView2ExperimentalFrame _nativeICoreWebView2ExperimentalFrameValue;

	internal object _rawNative;

	private EventRegistrationToken _nameChangedToken;

	private EventHandler<object> nameChanged;

	private EventRegistrationToken _destroyedToken;

	private EventHandler<object> destroyed;

	private EventRegistrationToken _navigationStartingToken;

	private EventHandler<CoreWebView2NavigationStartingEventArgs> navigationStarting;

	private EventRegistrationToken _contentLoadingToken;

	private EventHandler<CoreWebView2ContentLoadingEventArgs> contentLoading;

	private EventRegistrationToken _navigationCompletedToken;

	private EventHandler<CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

	private EventRegistrationToken _dOMContentLoadedToken;

	private EventHandler<CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

	private EventRegistrationToken _webMessageReceivedToken;

	private EventHandler<CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

	private EventRegistrationToken _permissionRequestedToken;

	private EventHandler<CoreWebView2PermissionRequestedEventArgs> permissionRequested;

	internal ICoreWebView2Frame _nativeICoreWebView2Frame
	{
		get
		{
			if (_nativeICoreWebView2FrameValue == null)
			{
				try
				{
					_nativeICoreWebView2FrameValue = (ICoreWebView2Frame)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2FrameValue;
		}
		set
		{
			_nativeICoreWebView2FrameValue = value;
		}
	}

	internal ICoreWebView2Frame2 _nativeICoreWebView2Frame2
	{
		get
		{
			if (_nativeICoreWebView2Frame2Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame2Value = (ICoreWebView2Frame2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame2Value;
		}
		set
		{
			_nativeICoreWebView2Frame2Value = value;
		}
	}

	internal ICoreWebView2Frame3 _nativeICoreWebView2Frame3
	{
		get
		{
			if (_nativeICoreWebView2Frame3Value == null)
			{
				try
				{
					_nativeICoreWebView2Frame3Value = (ICoreWebView2Frame3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2Frame3Value;
		}
		set
		{
			_nativeICoreWebView2Frame3Value = value;
		}
	}

	internal ICoreWebView2ExperimentalFrame4 _nativeICoreWebView2ExperimentalFrame4
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalFrame4Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalFrame4Value = (ICoreWebView2ExperimentalFrame4)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalFrame4Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalFrame4Value = value;
		}
	}

	internal ICoreWebView2ExperimentalFrame3 _nativeICoreWebView2ExperimentalFrame3
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalFrame3Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalFrame3Value = (ICoreWebView2ExperimentalFrame3)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalFrame3Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalFrame3Value = value;
		}
	}

	internal ICoreWebView2ExperimentalFrame2 _nativeICoreWebView2ExperimentalFrame2
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalFrame2Value == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalFrame2Value = (ICoreWebView2ExperimentalFrame2)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalFrame2Value;
		}
		set
		{
			_nativeICoreWebView2ExperimentalFrame2Value = value;
		}
	}

	internal ICoreWebView2ExperimentalFrame _nativeICoreWebView2ExperimentalFrame
	{
		get
		{
			if (_nativeICoreWebView2ExperimentalFrameValue == null)
			{
				try
				{
					_nativeICoreWebView2ExperimentalFrameValue = (ICoreWebView2ExperimentalFrame)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExperimentalFrame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2ExperimentalFrameValue;
		}
		set
		{
			_nativeICoreWebView2ExperimentalFrameValue = value;
		}
	}

	public string Name
	{
		get
		{
			try
			{
				return _nativeICoreWebView2Frame.Name;
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

	public event EventHandler<object> NameChanged
	{
		add
		{
			if (nameChanged == null)
			{
				try
				{
					_nativeICoreWebView2Frame.add_NameChanged(new CoreWebView2FrameNameChangedEventHandler(OnNameChanged), out _nameChangedToken);
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
			nameChanged = (EventHandler<object>)Delegate.Combine(nameChanged, value);
		}
		remove
		{
			nameChanged = (EventHandler<object>)Delegate.Remove(nameChanged, value);
			if (nameChanged != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Frame.remove_NameChanged(_nameChangedToken);
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

	public event EventHandler<object> Destroyed
	{
		add
		{
			if (destroyed == null)
			{
				try
				{
					_nativeICoreWebView2Frame.add_Destroyed(new CoreWebView2FrameDestroyedEventHandler(OnDestroyed), out _destroyedToken);
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
			destroyed = (EventHandler<object>)Delegate.Combine(destroyed, value);
		}
		remove
		{
			destroyed = (EventHandler<object>)Delegate.Remove(destroyed, value);
			if (destroyed != null)
			{
				return;
			}
			try
			{
				_nativeICoreWebView2Frame.remove_Destroyed(_destroyedToken);
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
					try
					{
						_nativeICoreWebView2Frame2.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler(OnNavigationStarting), out _navigationStartingToken);
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
				try
				{
					_nativeICoreWebView2Frame2.remove_NavigationStarting(_navigationStartingToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame.remove_NavigationStarting(_navigationStartingToken);
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

	public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading
	{
		add
		{
			if (contentLoading == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2Frame2.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler(OnContentLoading), out _contentLoadingToken);
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
				try
				{
					_nativeICoreWebView2Frame2.remove_ContentLoading(_contentLoadingToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame.remove_ContentLoading(_contentLoadingToken);
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

	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
	{
		add
		{
			if (navigationCompleted == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2Frame2.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler(OnNavigationCompleted), out _navigationCompletedToken);
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
				try
				{
					_nativeICoreWebView2Frame2.remove_NavigationCompleted(_navigationCompletedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame.remove_NavigationCompleted(_navigationCompletedToken);
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

	public event EventHandler<CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
	{
		add
		{
			if (dOMContentLoaded == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2Frame2.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler(OnDOMContentLoaded), out _dOMContentLoadedToken);
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
				try
				{
					_nativeICoreWebView2Frame2.remove_DOMContentLoaded(_dOMContentLoadedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame.remove_DOMContentLoaded(_dOMContentLoadedToken);
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

	public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
	{
		add
		{
			if (webMessageReceived == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2Frame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame2.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler(OnWebMessageReceived), out _webMessageReceivedToken);
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
				try
				{
					_nativeICoreWebView2Frame2.remove_WebMessageReceived(_webMessageReceivedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame2.remove_WebMessageReceived(_webMessageReceivedToken);
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

	public event EventHandler<CoreWebView2PermissionRequestedEventArgs> PermissionRequested
	{
		add
		{
			if (permissionRequested == null)
			{
				try
				{
					try
					{
						_nativeICoreWebView2Frame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
					}
					catch (NotImplementedException)
					{
						_nativeICoreWebView2ExperimentalFrame3.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler(OnPermissionRequested), out _permissionRequestedToken);
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
				try
				{
					_nativeICoreWebView2Frame3.remove_PermissionRequested(_permissionRequestedToken);
				}
				catch (NotImplementedException)
				{
					_nativeICoreWebView2ExperimentalFrame3.remove_PermissionRequested(_permissionRequestedToken);
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

	public void AddHostObjectToScript(string name, object rawObject, IEnumerable<string> origins)
	{
		ICoreWebView2Frame nativeICoreWebView2Frame = _nativeICoreWebView2Frame;
		object @object = rawObject;
		nativeICoreWebView2Frame.AddHostObjectToScriptWithOrigins(name, ref @object, (uint)origins.Count(), origins.Select((string origin) => origin).ToArray());
	}

	internal CoreWebView2Frame(object rawCoreWebView2Frame)
	{
		_rawNative = rawCoreWebView2Frame;
	}

	internal void OnNameChanged(object args)
	{
		nameChanged?.Invoke(this, args);
	}

	internal void OnDestroyed(object args)
	{
		destroyed?.Invoke(this, args);
	}

	public void RemoveHostObjectFromScript(string name)
	{
		try
		{
			_nativeICoreWebView2Frame.RemoveHostObjectFromScript(name);
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

	public int IsDestroyed()
	{
		try
		{
			return _nativeICoreWebView2Frame.IsDestroyed();
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

	internal void OnNavigationStarting(CoreWebView2NavigationStartingEventArgs args)
	{
		navigationStarting?.Invoke(this, args);
	}

	internal void OnContentLoading(CoreWebView2ContentLoadingEventArgs args)
	{
		contentLoading?.Invoke(this, args);
	}

	internal void OnNavigationCompleted(CoreWebView2NavigationCompletedEventArgs args)
	{
		navigationCompleted?.Invoke(this, args);
	}

	internal void OnDOMContentLoaded(CoreWebView2DOMContentLoadedEventArgs args)
	{
		dOMContentLoaded?.Invoke(this, args);
	}

	internal void OnWebMessageReceived(CoreWebView2WebMessageReceivedEventArgs args)
	{
		webMessageReceived?.Invoke(this, args);
	}

	public async Task<string> ExecuteScriptAsync(string javaScript)
	{
		CoreWebView2ExecuteScriptCompletedHandler handler;
		try
		{
			try
			{
				handler = new CoreWebView2ExecuteScriptCompletedHandler();
				_nativeICoreWebView2Frame2.ExecuteScript(javaScript, handler);
			}
			catch (NotImplementedException)
			{
				handler = new CoreWebView2ExecuteScriptCompletedHandler();
				_nativeICoreWebView2ExperimentalFrame.ExecuteScript(javaScript, handler);
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
		return handler.resultObjectAsJson;
	}

	public void PostWebMessageAsJson(string webMessageAsJson)
	{
		try
		{
			try
			{
				_nativeICoreWebView2Frame2.PostWebMessageAsJson(webMessageAsJson);
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2ExperimentalFrame2.PostWebMessageAsJson(webMessageAsJson);
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

	public void PostWebMessageAsString(string webMessageAsString)
	{
		try
		{
			try
			{
				_nativeICoreWebView2Frame2.PostWebMessageAsString(webMessageAsString);
			}
			catch (NotImplementedException)
			{
				_nativeICoreWebView2ExperimentalFrame2.PostWebMessageAsString(webMessageAsString);
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

	internal void OnPermissionRequested(CoreWebView2PermissionRequestedEventArgs args)
	{
		permissionRequested?.Invoke(this, args);
	}

	public void PostSharedBufferToScript(CoreWebView2SharedBuffer sharedBuffer, CoreWebView2SharedBufferAccess access, string additionalDataAsJson)
	{
		try
		{
			_nativeICoreWebView2ExperimentalFrame4.PostSharedBufferToScript(sharedBuffer._nativeICoreWebView2ExperimentalSharedBuffer, (COREWEBVIEW2_SHARED_BUFFER_ACCESS)access, additionalDataAsJson);
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
