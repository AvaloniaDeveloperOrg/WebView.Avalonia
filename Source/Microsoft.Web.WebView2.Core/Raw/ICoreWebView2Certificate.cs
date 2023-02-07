namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("C5FB2FCE-1CAC-4AEE-9C79-5ED0362EAAE0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2Certificate
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

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string ToPemEncoding();
}
