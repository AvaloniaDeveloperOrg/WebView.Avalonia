namespace Dotnet.Toolkit.Platform.Mac;

public class MacLibrary
{
    public const string libfolder = "/usr/lib/";
    public const string dylib = nameof(dylib);

    public const string libSystem = nameof(libSystem);
    public const string libSystemLibrary = $"{libfolder}{libSystem}.{dylib}";


}
