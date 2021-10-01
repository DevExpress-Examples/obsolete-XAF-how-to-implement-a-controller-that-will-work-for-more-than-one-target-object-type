<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134576308/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1797)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BO.cs](./CS/WinWebSolution.Module/BO.cs) (VB: [BO.vb](./VB/WinWebSolution.Module/BO.vb))
* [DemoViewController.cs](./CS/WinWebSolution.Module/DemoViewController.cs) (VB: [DemoViewController.vb](./VB/WinWebSolution.Module/DemoViewController.vb))
<!-- default file list end -->
# How to implement a controller that will work for more than one target object type


To make a single ViewController or Action available in Views of different business object types simultaneously, set the [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType) (or [ActionBase.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.TargetObjectType)) property in code to an interface or their base class type, which is implemented or inherited by all these business types respectively. Alternatively, for the same task, you can specify several View identifiers via the [ViewController.TargetViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewId)  (or [ActionBase.TargetViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.TargetViewId)) property.