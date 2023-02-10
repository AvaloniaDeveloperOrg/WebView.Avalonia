using Avalonia.WebView.Core;
using Dotnet.Toolkit.Extensions;

namespace Avalonia.WebView;

public partial class WebView : NativeControlHost
{
    public WebView(IServiceProvider? serviceProvider = default)
    {
        if (serviceProvider is not null)
            _platformWebViewProvider = serviceProvider.GetRequiredService<IPlatformWebViewProvider>();
        else
            _platformWebViewProvider = AvaloniaLocator.Current.GetRequiredService<IPlatformWebViewProvider>();
    }

    readonly IPlatformWebViewProvider _platformWebViewProvider;
    IPlatformWebView? _platformWebView;


}
