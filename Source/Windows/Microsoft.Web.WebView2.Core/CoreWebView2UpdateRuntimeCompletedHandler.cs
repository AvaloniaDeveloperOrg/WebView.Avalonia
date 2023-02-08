using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2UpdateRuntimeCompletedHandler : ICoreWebView2ExperimentalUpdateRuntimeCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2UpdateRuntimeResult result { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2UpdateRuntimeCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2ExperimentalUpdateRuntimeResult result)
	{
		this.result = new CoreWebView2UpdateRuntimeResult(result);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2UpdateRuntimeCompletedHandler GetAwaiter()
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

	public CoreWebView2UpdateRuntimeResult GetResult()
	{
		return result;
	}
}
