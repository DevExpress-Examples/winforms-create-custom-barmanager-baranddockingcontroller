Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars
Imports System.ComponentModel

Namespace WindowsApplication1
	Public Class MyBarAndDockingController
		Inherits BarAndDockingController
		Public Sub New(ByVal container As IContainer)
			MyBase.New()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Sub RegisterPaintStyles()
			MyBase.RegisterPaintStyles()
			PaintStyles.Add(New MySkinBarManagerPaintStyle(PaintStyles))
		End Sub
	End Class
End Namespace
