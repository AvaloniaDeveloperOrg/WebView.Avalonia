namespace CefSharp.Core;

public class CefRuntimeException : Exception
{
    public CefRuntimeException(string message)
        : base(message)
    {
    }
}
