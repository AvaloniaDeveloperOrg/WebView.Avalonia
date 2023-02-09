using Dotnet.Toolkit.Interfaces;

namespace Dotnet.Toolkit.Platform.Windows;

public class Win32Loader : ILibraryLoader
{
    private const string _kernel32 = Win32Library.kernel32Library;

    [DllImport(_kernel32, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport(_kernel32, EntryPoint = "LoadLibraryW", SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr LoadLibrary(string fileName);

    [DllImport(_kernel32, EntryPoint = "LoadLibraryEx", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern IntPtr LoadLibraryEx(string lpszLib, IntPtr hReservedNull, uint dwFlags);

    IntPtr ILibraryLoader.GetProcAddress(IntPtr dll, string procName, bool optional)
    {
        var ptr = GetProcAddress(dll, procName);
        if (ptr == IntPtr.Zero && !optional)
            throw new Exception($"Error {Marshal.GetLastWin32Error()}");
        return ptr;
    }

    IntPtr ILibraryLoader.LoadLibrary(string dllName, IntPtr hReservedNull, uint dwFlags)
    {
        var handle = LoadLibraryEx(dllName, hReservedNull, dwFlags);
        if (handle != IntPtr.Zero)
            return handle;

        var err = Marshal.GetLastWin32Error();
        throw new Exception($"Error loading {dllName} error {err}");
    }
}
