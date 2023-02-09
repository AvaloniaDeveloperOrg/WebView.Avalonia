namespace Dotnet.Toolkit.Helpers;

public static class RuntimeExHelpers
{
    public static bool IsDotNetFramework() => typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Framework");
    public static bool IsDotNetCore() => typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET Core");
    public static bool IsDotNet() => typeof(object).Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product.Contains(".NET");
    public static bool IsX86() => RuntimeInformation.ProcessArchitecture.HasFlag(Architecture.X86);
    public static bool IsX64() => RuntimeInformation.ProcessArchitecture.HasFlag(Architecture.X64);
    public static bool IsArm() => RuntimeInformation.ProcessArchitecture.HasFlag(Architecture.Arm);
    public static bool IsArm64() => RuntimeInformation.ProcessArchitecture.HasFlag(Architecture.Arm64);

    public static string X86 = nameof(Architecture.X86).ToLower();
    public static string X64 = nameof(Architecture.X64).ToLower();
    public static string Arm = nameof(Architecture.Arm).ToLower();
    public static string Arm64 = nameof(Architecture.Arm64).ToLower();

    public static string Win  = "win";
    public static string Linux  = "linux";
    public static string OsX = "osx";
}
