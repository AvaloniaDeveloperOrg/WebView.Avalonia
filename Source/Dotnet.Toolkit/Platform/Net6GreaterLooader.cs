namespace Dotnet.Toolkit.Platform;

#if NET6_0_OR_GREATER

using Dotnet.Toolkit.Interfaces;

public class Net6GreaterLooader : ILibraryLoader
{
    IntPtr ILibraryLoader.GetProcAddress(IntPtr dll, string procName, bool optional)
    {
        try
        {
            if (optional)
            {
                return NativeLibrary.TryGetExport(dll, procName, out var address) ? address : default;
            }
            return NativeLibrary.GetExport(dll, procName);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error {dll} {ex}");
        }
    }

    IntPtr ILibraryLoader.LoadLibrary(string dllName, IntPtr hReservedNull, uint dwFlags)
    {
        try
        {
            return NativeLibrary.Load(dllName);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error loading {dllName} {ex}");
        }
    }
}

#endif