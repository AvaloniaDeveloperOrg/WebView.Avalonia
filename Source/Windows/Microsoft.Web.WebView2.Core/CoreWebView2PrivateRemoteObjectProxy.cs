using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrivateRemoteObjectProxy
{
	internal ICoreWebView2PrivateRemoteObjectProxy _nativeICoreWebView2PrivateRemoteObjectProxyValue;

	internal object _rawNative;

	internal ICoreWebView2PrivateRemoteObjectProxy _nativeICoreWebView2PrivateRemoteObjectProxy
	{
		get
		{
			if (_nativeICoreWebView2PrivateRemoteObjectProxyValue == null)
			{
				try
				{
					_nativeICoreWebView2PrivateRemoteObjectProxyValue = (ICoreWebView2PrivateRemoteObjectProxy)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateRemoteObjectProxy.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2PrivateRemoteObjectProxyValue;
		}
		set
		{
			_nativeICoreWebView2PrivateRemoteObjectProxyValue = value;
		}
	}

	internal CoreWebView2PrivateRemoteObjectProxy(object rawCoreWebView2PrivateRemoteObjectProxy)
	{
		_rawNative = rawCoreWebView2PrivateRemoteObjectProxy;
	}

	internal int GetId()
	{
		try
		{
			return _nativeICoreWebView2PrivateRemoteObjectProxy.GetId();
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
