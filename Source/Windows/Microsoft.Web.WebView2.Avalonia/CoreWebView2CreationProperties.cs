using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Avalonia;
public class CoreWebView2CreationProperties : AvaloniaObject
{
    public CoreWebView2CreationProperties()
    {
        BrowserExecutableFolderProperty.Changed.AddClassHandler<CoreWebView2CreationProperties, string>((s, e) => s.TaskClear());
        UserDataFolderProperty.Changed.AddClassHandler<CoreWebView2CreationProperties, string>((s, e) => s.TaskClear());
        LanguageProperty.Changed.AddClassHandler<CoreWebView2CreationProperties, string>((s, e) => s.TaskClear());
        AdditionalBrowserArgumentsProperty.Changed.AddClassHandler<CoreWebView2CreationProperties, string>((s, e) => s.TaskClear());
    }

    public static readonly StyledProperty<string> BrowserExecutableFolderProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, string>(nameof(BrowserExecutableFolder), defaultValue: null);

    public static readonly StyledProperty<string> UserDataFolderProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, string>(nameof(UserDataFolder), defaultValue: null);

    public static readonly StyledProperty<string> LanguageProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, string>(nameof(Language), defaultValue: null);

    public static readonly StyledProperty<string> AdditionalBrowserArgumentsProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, string>(nameof(AdditionalBrowserArguments), defaultValue: null);

    public static readonly StyledProperty<string> ProfileNameProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, string>(nameof(ProfileName), defaultValue: null);

    public static readonly StyledProperty<bool?> IsInPrivateModeEnabledProperty =
          AvaloniaProperty.Register<CoreWebView2CreationProperties, bool?>(nameof(IsInPrivateModeEnabled), defaultValue: null);


    private Task<CoreWebView2Environment>? _task;


    public string BrowserExecutableFolder
    {
        get => GetValue(BrowserExecutableFolderProperty);
        set => SetValue(BrowserExecutableFolderProperty, value);
    }

    public string UserDataFolder
    {
        get => GetValue(UserDataFolderProperty);
        set => SetValue(BrowserExecutableFolderProperty, value);
    }

    public string Language
    {
        get => GetValue(LanguageProperty);
        set => SetValue(LanguageProperty, value);
    }

    public string AdditionalBrowserArguments
    {
        get => GetValue(AdditionalBrowserArgumentsProperty);
        set => SetValue(AdditionalBrowserArgumentsProperty, value);
    }

    public string ProfileName
    {
        get => GetValue(ProfileNameProperty);
        set => SetValue(ProfileNameProperty, value);
    }

    public bool? IsInPrivateModeEnabled
    {
        get => GetValue(IsInPrivateModeEnabledProperty);
        set => SetValue(IsInPrivateModeEnabledProperty, value);
    }

    internal Task<CoreWebView2Environment> CreateEnvironmentAsync()
    {
        if (_task == null && (BrowserExecutableFolder != null || UserDataFolder != null || Language != null || AdditionalBrowserArguments != null))
            _task = CoreWebView2Environment.CreateAsync(BrowserExecutableFolder, UserDataFolder, new CoreWebView2EnvironmentOptions(AdditionalBrowserArguments, Language));

        return _task ?? Task.FromResult<CoreWebView2Environment>(null);
    }

    internal CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions(CoreWebView2Environment environment)
    {
        CoreWebView2ControllerOptions coreWebView2ControllerOptions = null;
        if (ProfileName != null || IsInPrivateModeEnabled.HasValue)
        {
            coreWebView2ControllerOptions = environment.CreateCoreWebView2ControllerOptions();
            coreWebView2ControllerOptions.ProfileName = ProfileName;
            coreWebView2ControllerOptions.IsInPrivateModeEnabled = IsInPrivateModeEnabled.GetValueOrDefault();
        }
        return coreWebView2ControllerOptions;
    }

    public void TaskClear()
    {
        _task = default;
    }
}
