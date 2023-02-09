namespace CefSharp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using CefSharp.Core.Interop;

    /// <summary>
    /// Callback interface used to select a client certificate for authentication.
    /// </summary>
    public sealed unsafe partial class CefSelectClientCertificateCallback
    {
        /// <summary>
        /// Chooses the specified certificate for client certificate authentication.
        /// NULL value means that no client certificate should be used.
        /// </summary>
        public void Select(CefX509Certificate cert)
        {
            cef_select_client_certificate_callback_t.select(_self, cert != null ? cert.ToNative() : null);
        }
    }
}
