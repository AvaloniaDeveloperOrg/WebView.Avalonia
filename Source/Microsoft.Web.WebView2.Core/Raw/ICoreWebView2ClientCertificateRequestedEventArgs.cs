namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("BC59DB28-BCC3-11EB-8529-0242AC130003")]
[TypeIdentifier]
public interface ICoreWebView2ClientCertificateRequestedEventArgs
{
    [DispId(1610678272)]
    string Host
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        get;
    }

    [DispId(1610678273)]
    int Port
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678274)]
    int IsProxy
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    [DispId(1610678275)]
    ICoreWebView2StringCollection AllowedCertificateAuthorities
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678276)]
    ICoreWebView2ClientCertificateCollection MutuallyTrustedCertificates
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
    }

    [DispId(1610678277)]
    ICoreWebView2ClientCertificate SelectedCertificate
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        [param: MarshalAs(UnmanagedType.Interface)]
        set;
    }

    [DispId(1610678279)]
    int Cancel
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [DispId(1610678281)]
    int Handled
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
        [MethodImpl(MethodImplOptions.InternalCall)]
        [param: In]
        set;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();
}
