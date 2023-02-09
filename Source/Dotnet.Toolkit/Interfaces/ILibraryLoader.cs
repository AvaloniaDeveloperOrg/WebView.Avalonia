namespace Dotnet.Toolkit.Interfaces;

public interface ILibraryLoader
{
    IntPtr LoadLibrary(string dllName, IntPtr hReservedNull, uint dwFlags);
    IntPtr GetProcAddress(IntPtr dll, string procName, bool optional);
}
