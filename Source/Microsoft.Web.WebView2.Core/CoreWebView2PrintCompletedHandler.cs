using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrintCompletedHandler : ICoreWebView2PrintCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2PrintStatus printStatus { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2PrintCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, COREWEBVIEW2_PRINT_STATUS printStatus)
	{
		this.printStatus = (CoreWebView2PrintStatus)printStatus;
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2PrintCompletedHandler GetAwaiter()
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

	public CoreWebView2PrintStatus GetResult()
	{
		return printStatus;
	}
}
