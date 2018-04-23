Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Styles

Namespace WindowsApplication1
	Public Class MySkinBarManagerPaintStyle
		Inherits SkinBarManagerPaintStyle
		Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
			MyBase.New(collection)
		End Sub
		Protected Overrides Sub RegisterItemInfo()
			MyBase.RegisterItemInfo()
			Dim list As BarItemInfo = ItemInfoCollection(MyBarButtonItem.BaseBarItemName)
			ItemInfoCollection.Add(New BarItemInfo(MyBarButtonItem.BarItemName, MyBarButtonItem.BarItemCaption, -1, GetType(MyBarButtonItem), list.LinkType, list.ViewInfoType, list.LinkPainter, True, False))
		End Sub
	End Class
End Namespace
