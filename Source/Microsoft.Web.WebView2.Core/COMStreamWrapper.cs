using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core;

internal class COMStreamWrapper : Stream
{
	private IStream _istream;

	private IntPtr _mInt64;

	private long _size;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length
	{
		get
		{
			_istream.Stat(out var pstatstg, 1);
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
		_istream = source;
		_mInt64 = Marshal.AllocCoTaskMem(8);
		try
		{
			_size = Length;
			if (_size > 0)
			{
				GC.AddMemoryPressure(_size);
			}
		}
		catch (Exception ex)
		{
			_ = "Warning: The stream does not implement Stat properly, therefore it will not be possible to detect its size and report to .NET GC so it can be cleaned up. If it uses any unmanaged memory this may cause out of memory issues. Exception message: " + ex.Message;
		}
	}

	~COMStreamWrapper()
	{
		_istream = null;
		Marshal.FreeCoTaskMem(_mInt64);
		if (_size > 0)
		{
			GC.RemoveMemoryPressure(_size);
			_size = 0L;
		}
	}

	public override void Flush()
	{
		_istream.Commit(0);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (offset != 0)
		{
			throw new NotImplementedException();
		}
		_istream.Read(buffer, count, _mInt64);
		return Marshal.ReadInt32(_mInt64);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		_istream.Seek(offset, (int)origin, _mInt64);
		return Marshal.ReadInt64(_mInt64);
	}

	public override void SetLength(long value)
	{
		_istream.SetSize(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (offset != 0)
		{
			throw new NotImplementedException();
		}
		_istream.Write(buffer, count, IntPtr.Zero);
	}
}
