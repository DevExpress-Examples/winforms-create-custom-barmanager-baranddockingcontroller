Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles

Namespace WindowsApplication1
	Public Class MyBarButtonItem
		Inherits BarButtonItem
		Public Const BaseBarItemName As String = "BarButtonItem"
		Public Const BarItemName As String = "MyBarButtonItem"
		Public Const BarItemCaption As String = "My bar button"
		Shared Sub New()
			Register()
		End Sub
		Public Shared Sub Register()
			Register(BarAndDockingController.Default)
		End Sub

		Public Shared Sub Register(ByVal controller As BarAndDockingController)
			Register(controller.PaintStyles)
		End Sub
		Public Shared Sub Register(ByVal styles As BarManagerPaintStyleCollection)
			For Each paintStyle As BarManagerPaintStyle In styles
				Dim list As BarItemInfo = paintStyle.ItemInfoCollection(BaseBarItemName)
				If list IsNot Nothing AndAlso paintStyle.ItemInfoCollection(BarItemName) Is Nothing Then
					paintStyle.ItemInfoCollection.Add(New BarItemInfo(BarItemName, BarItemCaption, -1, GetType(MyBarButtonItem), list.LinkType, list.ViewInfoType, list.LinkPainter, True, False))
				End If
			Next paintStyle
		End Sub
	End Class
End Namespace
