
namespace Android.WebView.Avalonia.Imps;
internal class PlatformHandleImp<T> : IPlatformHandle
{
    public PlatformHandleImp(IntPtr hwnd)
    {
        Handle = hwnd;
    }

    public IntPtr Handle { get;}

    public string? HandleDescriptor => typeof(T).Name;
}
