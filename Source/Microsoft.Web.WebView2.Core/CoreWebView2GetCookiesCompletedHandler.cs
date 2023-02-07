using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetCookiesCompletedHandler : ICoreWebView2GetCookiesCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public List<CoreWebView2Cookie> cookieList { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2GetCookiesCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2CookieList cookieList)
	{
		this.cookieList = ((cookieList == null) ? new List<CoreWebView2Cookie>() : COMDotNetTypeConverter.CookieListCOMToNet(cookieList));
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2GetCookiesCompletedHandler GetAwaiter()
	{
		return this;
	}

	public void OnCompleted(Action continuation)
	{
		this.continuation = continuation;
		if (IsCompleted)
		{
			continuation();
		}
	}

	public List<CoreWebView2Cookie> GetResult()
	{
		return cookieList;
	}
}
