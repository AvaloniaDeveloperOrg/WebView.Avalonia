namespace Microsoft.Web.WebView2.Core;

[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class HostObjectHelper
{
    private CoreWebView2PrivateHostObjectHelper _helper = new CoreWebView2PrivateHostObjectHelper();

    public bool IsMethod(object obj, string name)
    {
        return _helper.IsMethodMember(obj, name) != 0;
    }
}
