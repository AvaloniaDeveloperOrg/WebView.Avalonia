namespace Microsoft.Web.WebView2.Core;

[Flags]
public enum CoreWebView2BrowsingDataKinds
{
    FileSystems = 1,
    IndexedDb = 2,
    LocalStorage = 4,
    WebSql = 8,
    CacheStorage = 0x10,
    AllDomStorage = 0x20,
    Cookies = 0x40,
    AllSite = 0x80,
    DiskCache = 0x100,
    DownloadHistory = 0x200,
    GeneralAutofill = 0x400,
    PasswordAutosave = 0x800,
    BrowsingHistory = 0x1000,
    Settings = 0x2000,
    AllProfile = 0x4000
}
