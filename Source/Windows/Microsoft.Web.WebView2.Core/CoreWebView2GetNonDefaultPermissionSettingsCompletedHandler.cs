using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core;

internal class CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler : ICoreWebView2ExperimentalGetNonDefaultPermissionSettingsCompletedHandler, INotifyCompletion
{
    private Action continuation;

    public IReadOnlyList<CoreWebView2PermissionSetting> collectionView { get; private set; }

    public int errCode { get; private set; }

    public bool IsCompleted { get; private set; }

    public void Invoke(int errCode, ICoreWebView2ExperimentalPermissionSettingCollectionView permissionSettingCollectionView)
    {
        collectionView = COMDotNetTypeConverter.CoreWebView2ExperimentalPermissionSettingCollectionViewCOMToNet(permissionSettingCollectionView);
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler()
    {
        IsCompleted = false;
    }

    public void Invoke(int errCode, IReadOnlyList<CoreWebView2PermissionSetting> collectionView)
    {
        this.collectionView = collectionView;
        this.errCode = errCode;
        IsCompleted = true;
        if (continuation != null)
        {
            continuation();
        }
    }

    public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler GetAwaiter()
    {
        return this;
    }

    public void OnCompleted(Action continuation)
    {
        this.continuation = continuation;
        if (IsCompleted)
        {
            continuation();
        }
    }

    public IReadOnlyList<CoreWebView2PermissionSetting> GetResult()
    {
        return collectionView;
    }
}
