using Microsoft.Web.WebView2.Core.Raw;

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
}
