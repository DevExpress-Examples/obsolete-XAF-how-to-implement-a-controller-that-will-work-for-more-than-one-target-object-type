Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module

    Public Interface ISupportDemoAction
    End Interface

    <DefaultClassOptions>
    <System.ComponentModel.DisplayName("I have the Demo Action")>
    Public Class DomainObject1
        Inherits BaseObject
        Implements ISupportDemoAction

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <DefaultClassOptions>
    <System.ComponentModel.DisplayName("I have the Demo Action")>
    Public Class DomainObject2
        Inherits BaseObject
        Implements ISupportDemoAction

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <DefaultClassOptions>
    <System.ComponentModel.DisplayName("I don't have the Demo Action")>
    Public Class DomainObject3
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class
End Namespace
