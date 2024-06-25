<!-- default file list -->
*Files to look at*:

* [BO.cs](./CS/WinWebSolution.Module/BO.cs) (VB: [BO.vb](./VB/WinWebSolution.Module/BO.vb))
* [DemoViewController.cs](./CS/WinWebSolution.Module/DemoViewController.cs) (VB: [DemoViewController.vb](./VB/WinWebSolution.Module/DemoViewController.vb))
<!-- default file list end -->
# How to implement a controller that will work for more than one target object type


To make a single ViewController or Action available in Views of different business object types simultaneously, set the [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType) (or [ActionBase.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.TargetObjectType)) property in code to an interface or their base class type, which is implemented or inherited by all these business types respectively. Alternatively, for the same task, you can specify several View identifiers via the [ViewController.TargetViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewId)  (or [ActionBase.TargetViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.TargetViewId)) property.
