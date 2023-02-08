namespace Avalonia.WebView.Core.Extensions;

public static class ServiceProviderExtensions
{
    public static TService? GetService<TService>(this IServiceProvider provider)
    {
        var service = provider?.GetService(typeof(TService));
        if (service is not TService tService)
            return default;

        return tService;
    }

    public static TService GetRequiredService<TService>(this IServiceProvider provider)
    {
        var service = provider.GetService<TService>();
        if (service is null)
            throw new ArgumentNullException($"Service is null, type:{typeof(TService)}");

        return service;
    }
}
