namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("E7188076-BCC3-11EB-8529-0242AC130003")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2ClientCertificate
{
    [DispId(1610678272)]
    string Subject
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678273)]
    string Issuer
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678274)]
    double ValidFrom
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678275)]
    double ValidTo
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678276)]
    string DerEncodedSerialNumber
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678277)]
    string DisplayName
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678279)]
    ICoreWebView2StringCollection PemEncodedIssuerCertificateChain
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678280)]
    COREWEBVIEW2_CLIENT_CERTIFICATE_KIND Kind
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string ToPemEncoding();
}
