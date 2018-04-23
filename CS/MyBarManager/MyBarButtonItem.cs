using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;

namespace WindowsApplication1 {
    public class MyBarButtonItem : BarButtonItem {
        public const string BaseBarItemName = "BarButtonItem";
        public const string BarItemName = "MyBarButtonItem";
        public const string BarItemCaption = "My bar button";
        static MyBarButtonItem() { Register(); }
        public static void Register() { Register(BarAndDockingController.Default); }

        public static void Register(BarAndDockingController controller) {
            Register(controller.PaintStyles);
        }
        public static void Register(BarManagerPaintStyleCollection styles) {
            foreach (BarManagerPaintStyle paintStyle in styles) {
                BarItemInfo list = paintStyle.ItemInfoCollection[BaseBarItemName];
                if (list != null && paintStyle.ItemInfoCollection[BarItemName] == null) {
                    paintStyle.ItemInfoCollection.Add(new BarItemInfo(BarItemName, BarItemCaption, -1, typeof(MyBarButtonItem), list.LinkType, list.ViewInfoType, list.LinkPainter, true, false));
                }
            }
        }
    }
}
