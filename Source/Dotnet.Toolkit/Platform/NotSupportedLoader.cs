using Dotnet.Toolkit.Interfaces;

namespace Dotnet.Toolkit.Platform;
public class NotSupportedLoader : ILibraryLoader
{
    IntPtr ILibraryLoader.GetProcAddress(IntPtr dll, string procName, bool optional)
    {
        throw new PlatformNotSupportedException($"this platform not can GetProcAddress( {dll}, {procName}, {optional}).");
    }

    IntPtr ILibraryLoader.LoadLibrary(string dllName, IntPtr hReservedNull, uint dwFlags)
    {
        throw new PlatformNotSupportedException($"this platform not can LoadLibrary( {dllName}, {hReservedNull}, {dwFlags}).");
    }
}