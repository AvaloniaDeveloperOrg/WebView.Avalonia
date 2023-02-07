using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetFaviconCompletedHandler : ICoreWebView2GetFaviconCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public Stream faviconStream { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2GetFaviconCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, IStream faviconStream)
	{
		this.faviconStream = COMDotNetTypeConverter.StreamCOMToNet(faviconStream);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2GetFaviconCompletedHandler GetAwaiter()
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

	public Stream GetResult()
	{
		return faviconStream;
	}
}
