using System;
using DevExpress.XtraBars.Styles;

namespace WindowsApplication1 {
    public class MySkinBarManagerPaintStyle : SkinBarManagerPaintStyle {
        public MySkinBarManagerPaintStyle(BarManagerPaintStyleCollection collection) : base(collection) { }
        protected override void RegisterItemInfo() {
            base.RegisterItemInfo();
            BarItemInfo list = ItemInfoCollection[MyBarButtonItem.BaseBarItemName];
            ItemInfoCollection.Add(new BarItemInfo(MyBarButtonItem.BarItemName, MyBarButtonItem.BarItemCaption, -1, typeof(MyBarButtonItem), list.LinkType, list.ViewInfoType, list.LinkPainter, true, false));
        }
    }
}
