using System;
using DevExpress.XtraBars;
using System.ComponentModel;

namespace WindowsApplication1 {
    public class MyBarAndDockingController : BarAndDockingController {
        public MyBarAndDockingController(IContainer container) : base() { }
        public MyBarAndDockingController() : base() { }
        protected override void RegisterPaintStyles() {
            base.RegisterPaintStyles();
            PaintStyles.Add(new MySkinBarManagerPaintStyle(PaintStyles));
        }
    }
}
