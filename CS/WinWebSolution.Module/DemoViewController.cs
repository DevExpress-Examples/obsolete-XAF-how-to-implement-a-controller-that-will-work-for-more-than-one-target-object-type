using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace WinWebSolution.Module {
    public class DemoViewController : ViewController {
        public DemoViewController() {
            saDemoAction = new SimpleAction(this, "DemoAction", DevExpress.Persistent.Base.PredefinedCategory.Unspecified);
            saDemoAction.TargetObjectType = typeof(ISupportDemoAction);
        }
        private SimpleAction saDemoAction;
        public SimpleAction DemoAction {
            get { return saDemoAction; }
        }
    }
}
