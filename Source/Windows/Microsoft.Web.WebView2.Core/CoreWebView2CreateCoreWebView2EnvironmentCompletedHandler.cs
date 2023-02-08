using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler : ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2Environment createdEnvironment { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2Environment createdEnvironment)
	{
		this.createdEnvironment = new CoreWebView2Environment(createdEnvironment);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler GetAwaiter()
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

	public CoreWebView2Environment GetResult()
	{
		return createdEnvironment;
	}
}
