Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace WinWebSolution.Module
	Public Class DemoViewController
		Inherits ViewController
		Public Sub New()
			saDemoAction = New SimpleAction(Me, "DemoAction", DevExpress.Persistent.Base.PredefinedCategory.Unspecified)
			saDemoAction.TargetObjectType = GetType(ISupportDemoAction)
		End Sub
		Private saDemoAction As SimpleAction
		Public ReadOnly Property DemoAction() As SimpleAction
			Get
				Return saDemoAction
			End Get
		End Property
	End Class
End Namespace
