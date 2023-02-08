namespace Microsoft.Web.WebView2.Core;

public enum CoreWebView2ProcessFailedKind
{
	BrowserProcessExited,
	RenderProcessExited,
	RenderProcessUnresponsive,
	FrameRenderProcessExited,
	UtilityProcessExited,
	SandboxHelperProcessExited,
	GpuProcessExited,
	PpapiPluginProcessExited,
	PpapiBrokerProcessExited,
	UnknownProcessExited
}
