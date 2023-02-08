namespace WebView.Sample.WinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        webView2.Source = new Uri("https://www.baidu.com");
    }
}
