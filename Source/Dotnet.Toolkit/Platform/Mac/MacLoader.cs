using Dotnet.Toolkit.Interfaces;

namespace Dotnet.Toolkit.Platform.Mac;

public class MacLoader : ILibraryLoader
{
    private const string _libSystem = MacLibrary.libSystemLibrary;

    [DllImport(_libSystem)]
    private static extern IntPtr dlopen(string path, int flags);

    [DllImport(_libSystem)]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport(_libSystem)]
    private static extern IntPtr dlerror();

    IntPtr ILibraryLoader.GetProcAddress(IntPtr dll, string procName, bool optional)
    {
        var ptr = dlsym(dll, procName);
        if (ptr == IntPtr.Zero && !optional)
            throw new Exception(Marshal.PtrToStringAnsi(dlerror()));
        return ptr;
    }

    IntPtr ILibraryLoader.LoadLibrary(string dllName, IntPtr hReservedNull, uint dwFlags)
    {
        var handle = dlopen(dllName, 1);
        if (handle == IntPtr.Zero)
            throw new Exception(Marshal.PtrToStringAnsi(dlerror()));
        return handle;
    }
}
