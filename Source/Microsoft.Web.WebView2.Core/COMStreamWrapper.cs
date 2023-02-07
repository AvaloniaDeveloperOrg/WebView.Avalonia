namespace Microsoft.Web.WebView2.Core;

internal class COMStreamWrapper : Stream
{
    private IStream istream;

    private IntPtr mInt64;

    public override bool CanRead => true;

    public override bool CanSeek => false;

    public override bool CanWrite => true;

    public override long Length
    {
        get
        {
            istream.Stat(out var pstatstg, 1);
            return pstatstg.cbSize;
        }
    }

    public override long Position
    {
        get
        {
            throw new NotSupportedException();
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    public COMStreamWrapper(IStream source)
    {
        istream = source;
        mInt64 = Marshal.AllocCoTaskMem(8);
    }

    ~COMStreamWrapper()
    {
        Marshal.FreeCoTaskMem(mInt64);
    }

    public override void Flush()
    {
        istream.Commit(0);
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        if (offset != 0)
        {
            throw new NotImplementedException();
        }
        istream.Read(buffer, count, mInt64);
        return Marshal.ReadInt32(mInt64);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        istream.Seek(offset, (int)origin, mInt64);
        return Marshal.ReadInt64(mInt64);
    }

    public override void SetLength(long value)
    {
        istream.SetSize(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        if (offset != 0)
        {
            throw new NotImplementedException();
        }
        istream.Write(buffer, count, IntPtr.Zero);
    }
}
