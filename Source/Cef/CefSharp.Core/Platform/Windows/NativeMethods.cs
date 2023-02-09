namespace CefSharp.Core.Platform.Windows;

internal static partial class NativeMethods
{
    private const string _kernek32 = "kernel32.dll";

    [DllImport(_kernek32, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport(_kernek32, SetLastError = true)]
    public static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);
}
