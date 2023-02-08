using System;

namespace Microsoft.Web.WebView2.Core;

[Flags]
public enum CoreWebView2WebResourceRequestSourceKinds
{
	None = 0,
	Document = 1,
	SharedWorker = 2,
	ServiceWorker = 4,
	All = -1
}
