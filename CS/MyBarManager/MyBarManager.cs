using System;
using DevExpress.XtraBars;
using System.ComponentModel;
using DevExpress.XtraBars.Styles;

namespace WindowsApplication1 {
    public class MyBarManager : BarManager {
        public MyBarManager(IContainer container)
            : base(container) {
        }
        public MyBarManager()
            : base() {
            MyBarButtonItem.Register();
        }
    }
}