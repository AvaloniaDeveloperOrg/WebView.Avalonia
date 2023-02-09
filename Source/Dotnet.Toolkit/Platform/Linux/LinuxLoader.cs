using Dotnet.Toolkit.Interfaces;

namespace Dotnet.Toolkit.Platform.Linux;

public class LinuxLoader : ILibraryLoader
{
    private const string _libdl =  LinuxLibrary.libdl2Library;

    [DllImport(_libdl)]
    private static extern IntPtr dlopen(string path, int flags);

    [DllImport(_libdl)]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport(_libdl)]
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
