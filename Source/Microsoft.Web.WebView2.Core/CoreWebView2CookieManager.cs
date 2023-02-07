using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2CookieManager
{
	internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManagerValue;

	internal object _rawNative;

	internal ICoreWebView2CookieManager _nativeICoreWebView2CookieManager
	{
		get
		{
			if (_nativeICoreWebView2CookieManagerValue == null)
			{
				try
				{
					_nativeICoreWebView2CookieManagerValue = (ICoreWebView2CookieManager)_rawNative;
				}
				catch (Exception inner)
				{
					throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
				}
			}
			return _nativeICoreWebView2CookieManagerValue;
		}
		set
		{
			_nativeICoreWebView2CookieManagerValue = value;
		}
	}

	public CoreWebView2Cookie CreateCookieWithSystemNetCookie(Cookie systemNetCookie)
	{
		return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CreateCookie(systemNetCookie.Name, systemNetCookie.Value, systemNetCookie.Domain, systemNetCookie.Path))
		{
			IsHttpOnly = systemNetCookie.HttpOnly,
			IsSecure = systemNetCookie.Secure,
			Expires = systemNetCookie.Expires.ToUniversalTime()
		};
	}

	internal CoreWebView2CookieManager(object rawCoreWebView2CookieManager)
	{
		_rawNative = rawCoreWebView2CookieManager;
	}

	public CoreWebView2Cookie CreateCookie(string name, string value, string Domain, string Path)
	{
		try
		{
			return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CreateCookie(name, value, Domain, Path));
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

	public CoreWebView2Cookie CopyCookie(CoreWebView2Cookie cookieParam)
	{
		try
		{
			return new CoreWebView2Cookie(_nativeICoreWebView2CookieManager.CopyCookie(cookieParam._nativeICoreWebView2Cookie));
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

	public async Task<List<CoreWebView2Cookie>> GetCookiesAsync(string uri)
	{
		CoreWebView2GetCookiesCompletedHandler handler;
		try
		{
			handler = new CoreWebView2GetCookiesCompletedHandler();
			_nativeICoreWebView2CookieManager.GetCookies(uri, handler);
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
		return handler.cookieList;
	}

	public void AddOrUpdateCookie(CoreWebView2Cookie cookie)
	{
		try
		{
			_nativeICoreWebView2CookieManager.AddOrUpdateCookie(cookie._nativeICoreWebView2Cookie);
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

	public void DeleteCookie(CoreWebView2Cookie cookie)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookie(cookie._nativeICoreWebView2Cookie);
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

	public void DeleteCookies(string name, string uri)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookies(name, uri);
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

	public void DeleteCookiesWithDomainAndPath(string name, string Domain, string Path)
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteCookiesWithDomainAndPath(name, Domain, Path);
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

	public void DeleteAllCookies()
	{
		try
		{
			_nativeICoreWebView2CookieManager.DeleteAllCookies();
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
