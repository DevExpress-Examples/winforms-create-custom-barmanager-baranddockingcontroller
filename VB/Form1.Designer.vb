Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myBarManager1 = New WindowsApplication1.MyBarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.myBarButtonItem1 = New WindowsApplication1.MyBarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.myBarButtonItem2 = New WindowsApplication1.MyBarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.myBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myBarManager1
			' 
			Me.myBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.myBarManager1.DockControls.Add(Me.barDockControlTop)
			Me.myBarManager1.DockControls.Add(Me.barDockControlBottom)
			Me.myBarManager1.DockControls.Add(Me.barDockControlLeft)
			Me.myBarManager1.DockControls.Add(Me.barDockControlRight)
			Me.myBarManager1.Form = Me
			Me.myBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.myBarButtonItem1, Me.myBarButtonItem2})
			Me.myBarManager1.MainMenu = Me.bar2
			Me.myBarManager1.MaxItemId = 2
			Me.myBarManager1.StatusBar = Me.bar3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 1
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.Text = "Tools"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.myBarButtonItem1)})
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' myBarButtonItem1
			' 
			Me.myBarButtonItem1.Caption = "myBarButtonItem1"
			Me.myBarButtonItem1.Id = 0
			Me.myBarButtonItem1.Name = "myBarButtonItem1"
			' 
			' myBarButtonItem2
			' 
			Me.myBarButtonItem2.Caption = "myBarButtonItem2"
			Me.myBarButtonItem2.Id = 1
			Me.myBarButtonItem2.Name = "myBarButtonItem2"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.myBarButtonItem2)})
			Me.popupMenu1.Manager = Me.myBarManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.myBarManager1.SetPopupContextMenu(Me, Me.popupMenu1)
			Me.Text = "Form1"
			CType(Me.myBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myBarManager1 As MyBarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private myBarButtonItem1 As MyBarButtonItem
		Private myBarButtonItem2 As MyBarButtonItem
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu

	End Class
End Namespace

