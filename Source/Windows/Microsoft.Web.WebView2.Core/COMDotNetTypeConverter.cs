using Microsoft.Web.WebView2.Core.Raw;
using System.Numerics;

namespace Microsoft.Web.WebView2.Core;

internal static class COMDotNetTypeConverter
{
    public static Rectangle RectangleCOMToNet(tagRECT rect)
    {
        int left = rect.left;
        int top = rect.top;
        int width = rect.right - rect.left;
        int height = rect.bottom - rect.top;
        return new Rectangle(left, top, width, height);
    }

    public static tagRECT RectangleNetToCOM(Rectangle dotNetRect)
    {
        tagRECT result = default(tagRECT);
        result.top = dotNetRect.Top;
        result.left = dotNetRect.Left;
        result.right = dotNetRect.Right;
        result.bottom = dotNetRect.Bottom;
        return result;
    }

    public static List<CoreWebView2Cookie> CookieListCOMToNet(ICoreWebView2CookieList rawCookieList)
    {
        List<CoreWebView2Cookie> list = new List<CoreWebView2Cookie>(Convert.ToInt32(rawCookieList.Count));
        for (uint num = 0u; num < rawCookieList.Count; num++)
        {
            list.Add(new CoreWebView2Cookie(rawCookieList.GetValueAtIndex(num)));
        }
        return list;
    }

    public static IReadOnlyList<CoreWebView2FrameInfo> CoreWebView2FrameInfoCollectionCOMToNet(ICoreWebView2FrameInfoCollection rawFrameInfoCollection)
    {
        if (rawFrameInfoCollection == null)
        {
            return null;
        }
        List<CoreWebView2FrameInfo> list = new List<CoreWebView2FrameInfo>();
        ICoreWebView2FrameInfoCollectionIterator iterator = rawFrameInfoCollection.GetIterator();
        while (iterator.HasCurrent != 0)
        {
            list.Add(new CoreWebView2FrameInfo(iterator.GetCurrent()));
            iterator.MoveNext();
        }
        return new ReadOnlyCollection<CoreWebView2FrameInfo>(list);
    }

    public static Color ColorCOMToNet(COREWEBVIEW2_COLOR color)
    {
        return Color.FromArgb(color.A, color.R, color.G, color.B);
    }

    public static COREWEBVIEW2_COLOR ColorNetToCOM(Color dotNetColor)
    {
        COREWEBVIEW2_COLOR result = default(COREWEBVIEW2_COLOR);
        result.A = dotNetColor.A;
        result.R = dotNetColor.R;
        result.G = dotNetColor.G;
        result.B = dotNetColor.B;
        return result;
    }

    public static Point PointCOMToNet(tagPOINT point)
    {
        return new Point(point.x, point.y);
    }

    public static tagPOINT PointNetToCOM(Point dotNetPoint)
    {
        tagPOINT result = default(tagPOINT);
        result.x = Convert.ToInt32(dotNetPoint.X);
        result.y = Convert.ToInt32(dotNetPoint.Y);
        return result;
    }

    public static IReadOnlyList<CoreWebView2ClientCertificate> CoreWebView2ClientCertificateCollectionCOMToNet(ICoreWebView2ClientCertificateCollection rawClientCertificateCollection)
    {
        if (rawClientCertificateCollection == null)
        {
            return null;
        }
        List<CoreWebView2ClientCertificate> list = new List<CoreWebView2ClientCertificate>(Convert.ToInt32(rawClientCertificateCollection.Count));
        for (uint num = 0u; num < rawClientCertificateCollection.Count; num++)
        {
            list.Add(new CoreWebView2ClientCertificate(rawClientCertificateCollection.GetValueAtIndex(num)));
        }
        return new ReadOnlyCollection<CoreWebView2ClientCertificate>(list);
    }

    public static IReadOnlyList<string> CoreWebView2StringCollectionCOMToNet(ICoreWebView2StringCollection rawStringCollection)
    {
        if (rawStringCollection == null)
        {
            return null;
        }
        List<string> list = new List<string>(Convert.ToInt32(rawStringCollection.Count));
        for (uint num = 0u; num < rawStringCollection.Count; num++)
        {
            list.Add(rawStringCollection.GetValueAtIndex(num));
        }
        return new ReadOnlyCollection<string>(list);
    }

    public static IList<CoreWebView2ContextMenuItem> CoreWebView2ContextMenuItemCollectionCOMToNet(ICoreWebView2ContextMenuItemCollection rawContextMenuCollection)
    {
        if (rawContextMenuCollection == null)
        {
            return null;
        }
        List<CoreWebView2ContextMenuItem> list = new List<CoreWebView2ContextMenuItem>(Convert.ToInt32(rawContextMenuCollection.Count));
        for (uint num = 0u; num < rawContextMenuCollection.Count; num++)
        {
            list.Add(new CoreWebView2ContextMenuItem(rawContextMenuCollection.GetValueAtIndex(num)));
        }
        ObservableCollection<CoreWebView2ContextMenuItem> collection = new ObservableCollection<CoreWebView2ContextMenuItem>(list);
        collection.CollectionChanged += delegate (object sender, NotifyCollectionChangedEventArgs args)
        {
            switch (args.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                    rawContextMenuCollection.RemoveValueAtIndex((uint)args.OldStartingIndex);
                    break;
                case NotifyCollectionChangedAction.Add:
                    rawContextMenuCollection.InsertValueAtIndex((uint)args.NewStartingIndex, ((CoreWebView2ContextMenuItem)args.NewItems[0])._nativeICoreWebView2ContextMenuItem);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    rawContextMenuCollection.RemoveValueAtIndex((uint)args.OldStartingIndex);
                    rawContextMenuCollection.InsertValueAtIndex((uint)args.NewStartingIndex, ((CoreWebView2ContextMenuItem)args.NewItems[0])._nativeICoreWebView2ContextMenuItem);
                    break;
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                    {
                        uint count = rawContextMenuCollection.Count;
                        for (uint num2 = 0u; num2 < count; num2++)
                        {
                            rawContextMenuCollection.RemoveValueAtIndex(0u);
                        }
                        for (int i = 0; i < collection.Count; i++)
                        {
                            rawContextMenuCollection.InsertValueAtIndex((uint)i, collection[i]._nativeICoreWebView2ContextMenuItem);
                        }
                        break;
                    }
            }
        };
        return collection;
    }

    public static Matrix4x4 Matrix4x4COMToNet(COREWEBVIEW2_MATRIX_4X4 matrix4x4)
    {
        float m = Convert.ToSingle(matrix4x4._11);
        float m2 = Convert.ToSingle(matrix4x4._12);
        float m3 = Convert.ToSingle(matrix4x4._13);
        float m4 = Convert.ToSingle(matrix4x4._14);
        float m5 = Convert.ToSingle(matrix4x4._21);
        float m6 = Convert.ToSingle(matrix4x4._22);
        float m7 = Convert.ToSingle(matrix4x4._23);
        float m8 = Convert.ToSingle(matrix4x4._24);
        float m9 = Convert.ToSingle(matrix4x4._31);
        float m10 = Convert.ToSingle(matrix4x4._32);
        float m11 = Convert.ToSingle(matrix4x4._33);
        float m12 = Convert.ToSingle(matrix4x4._34);
        float m13 = Convert.ToSingle(matrix4x4._41);
        float m14 = Convert.ToSingle(matrix4x4._42);
        float m15 = Convert.ToSingle(matrix4x4._43);
        float m16 = Convert.ToSingle(matrix4x4._44);
        return new Matrix4x4(m, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
    }

    public static COREWEBVIEW2_MATRIX_4X4 Matrix4x4NetToCOM(Matrix4x4 dotNetMatrix4x4)
    {
        COREWEBVIEW2_MATRIX_4X4 result = default(COREWEBVIEW2_MATRIX_4X4);
        result._11 = dotNetMatrix4x4.M11;
        result._12 = dotNetMatrix4x4.M12;
        result._13 = dotNetMatrix4x4.M13;
        result._14 = dotNetMatrix4x4.M14;
        result._21 = dotNetMatrix4x4.M21;
        result._22 = dotNetMatrix4x4.M22;
        result._23 = dotNetMatrix4x4.M23;
        result._24 = dotNetMatrix4x4.M24;
        result._31 = dotNetMatrix4x4.M31;
        result._32 = dotNetMatrix4x4.M32;
        result._33 = dotNetMatrix4x4.M33;
        result._34 = dotNetMatrix4x4.M34;
        result._41 = dotNetMatrix4x4.M41;
        result._42 = dotNetMatrix4x4.M42;
        result._43 = dotNetMatrix4x4.M43;
        result._44 = dotNetMatrix4x4.M44;
        return result;
    }

    public static IReadOnlyList<CoreWebView2ProcessInfo> ProcessInfoCollectionCOMToNet(ICoreWebView2ProcessInfoCollection rawCoreWebView2ProcessInfoCollection)
    {
        if (rawCoreWebView2ProcessInfoCollection == null)
        {
            return null;
        }
        List<CoreWebView2ProcessInfo> list = new List<CoreWebView2ProcessInfo>(Convert.ToInt32(rawCoreWebView2ProcessInfoCollection.Count));
        for (uint num = 0u; num < rawCoreWebView2ProcessInfoCollection.Count; num++)
        {
            list.Add(new CoreWebView2ProcessInfo(rawCoreWebView2ProcessInfoCollection.GetValueAtIndex(num)));
        }
        return new ReadOnlyCollection<CoreWebView2ProcessInfo>(list);
    }

    public static COMStreamWrapper StreamCOMToNet(IStream stream)
    {
        if (stream == null)
        {
            return null;
        }
        return new COMStreamWrapper(stream);
    }

    public static IReadOnlyList<CoreWebView2PermissionSetting> CoreWebView2ExperimentalPermissionSettingCollectionViewCOMToNet(ICoreWebView2ExperimentalPermissionSettingCollectionView rawPermissionSettingCollectionView)
    {
        if (rawPermissionSettingCollectionView == null)
        {
            return null;
        }
        List<CoreWebView2PermissionSetting> list = new List<CoreWebView2PermissionSetting>(Convert.ToInt32(rawPermissionSettingCollectionView.Count));
        for (uint num = 0u; num < rawPermissionSettingCollectionView.Count; num++)
        {
            list.Add(new CoreWebView2PermissionSetting(rawPermissionSettingCollectionView.GetValueAtIndex(num)));
        }
        return new ReadOnlyCollection<CoreWebView2PermissionSetting>(list);
    }
}
