Imports DevExpress.XtraBars
Imports System.ComponentModel

Namespace WindowsApplication1

    Public Class MyBarManager
        Inherits BarManager

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub

        Public Sub New()
            MyBase.New()
            MyBarButtonItem.Register()
        End Sub
    End Class
End Namespace
