using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2CreateCoreWebView2ControllerCompletedHandler : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public CoreWebView2Controller createdController { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2CreateCoreWebView2ControllerCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, ICoreWebView2Controller createdController)
	{
		this.createdController = new CoreWebView2Controller(createdController);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2CreateCoreWebView2ControllerCompletedHandler GetAwaiter()
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

	public CoreWebView2Controller GetResult()
	{
		return createdController;
	}
}
