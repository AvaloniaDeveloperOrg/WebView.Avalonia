using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2PrintToPdfStreamCompletedHandler : ICoreWebView2PrintToPdfStreamCompletedHandler, INotifyCompletion
{
	private Action continuation;

	public Stream pdfStream { get; private set; }

	public int errCode { get; private set; }

	public bool IsCompleted { get; private set; }

	public CoreWebView2PrintToPdfStreamCompletedHandler()
	{
		IsCompleted = false;
	}

	public void Invoke(int errCode, IStream pdfStream)
	{
		this.pdfStream = COMDotNetTypeConverter.StreamCOMToNet(pdfStream);
		this.errCode = errCode;
		IsCompleted = true;
		if (continuation != null)
		{
			continuation();
		}
	}

	public CoreWebView2PrintToPdfStreamCompletedHandler GetAwaiter()
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
		return pdfStream;
	}
}
