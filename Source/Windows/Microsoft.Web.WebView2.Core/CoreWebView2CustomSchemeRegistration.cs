using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

public class CoreWebView2CustomSchemeRegistration
{
    private class RawCustomSchemeRegistration : ICoreWebView2CustomSchemeRegistration
    {
        public string SchemeName { get; set; }

        public int TreatAsSecure { get; set; }

        public int HasAuthorityComponent { get; set; }

        private List<string> AllowedOrigins { get; } = new List<string>();


        public RawCustomSchemeRegistration(string schemeName, bool treatAsSecure, bool hasAuthorityComponent, List<string> allowedOrigins)
        {
            SchemeName = schemeName;
            TreatAsSecure = (treatAsSecure ? 1 : 0);
            HasAuthorityComponent = (hasAuthorityComponent ? 1 : 0);
            AllowedOrigins = allowedOrigins;
        }

        public void GetAllowedOrigins(out uint allowedOriginsCount, IntPtr allowedOriginsPtr)
        {
            allowedOriginsCount = (uint)AllowedOrigins.Count;
            if (allowedOriginsCount != 0)
            {
                IntPtr intPtr = Marshal.AllocCoTaskMem((int)allowedOriginsCount * Marshal.SizeOf<IntPtr>());
                for (int i = 0; i < allowedOriginsCount; i++)
                {
                    Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), Marshal.StringToCoTaskMemAuto(AllowedOrigins[i]));
                }
                Marshal.WriteIntPtr(allowedOriginsPtr, intPtr);
            }
        }

        public void SetAllowedOrigins(uint allowedOriginsCount, ref string allowedOrigins)
        {
            throw new NotImplementedException();
        }
    }

    public string SchemeName { get; }

    public bool TreatAsSecure { get; set; }

    public bool HasAuthorityComponent { get; set; }

    public List<string> AllowedOrigins { get; set; } = new List<string>();


    public CoreWebView2CustomSchemeRegistration(string schemeName)
    {
        SchemeName = schemeName;
    }

    internal IntPtr GetNative()
    {
        return Marshal.GetComInterfaceForObject(new RawCustomSchemeRegistration(SchemeName, TreatAsSecure, HasAuthorityComponent, AllowedOrigins), typeof(ICoreWebView2CustomSchemeRegistration));
    }
}
