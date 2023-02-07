using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2TrySuspendCompletedHandler : ICoreWebView2TrySuspendCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public bool isSuccessful { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2TrySuspendCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, int isSuccessful)
	{
		this.isSuccessful = ((isSuccessful != 0) ? true : false);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2TrySuspendCompletedHandler GetAwaiter()
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

	public bool GetResult()
	{
		return isSuccessful;
	}
}
