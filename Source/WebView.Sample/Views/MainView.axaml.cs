using Avalonia.Controls;
using Microsoft.Web.WebView2.Core;

namespace WebView.Sample.Views;
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    
    void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs arg)
    {
        //Part_Loading.IsVisible = false;
        PART_WebView.IsVisible = true;
    }
}
