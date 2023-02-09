﻿using System;

namespace CefSharp.Core;

public static class CefBrowserHostExtensions
{
    public static unsafe bool SendDevToolsMessage(this CefBrowserHost browserHost, byte[] message)
    {
        fixed (byte* messagePtr = &message[0])
        {
            return browserHost.SendDevToolsMessage((IntPtr)messagePtr, message.Length);
        }
    }

    public static unsafe bool SendDevToolsMessage(this CefBrowserHost browserHost, ArraySegment<byte> message)
    {
        fixed (byte* messagePtr = &message.Array[message.Offset])
        {
            return browserHost.SendDevToolsMessage((IntPtr)messagePtr, message.Count);
        }
    }
}
