Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication149
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim r As New Record() With {.Phone = "123-45-67", .Name = "Name"}
			Me.propertyGridControl1.SelectedObject = r
			propertyGridControl1.RetrieveFields()
			Dim ri As New RepositoryItemTextEdit()
			ri.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			ri.Mask.EditMask = "(\(\d\d\d\))?\d{1,3}-\d\d-\d\d"
			ri.Mask.UseMaskAsDisplayFormat = True
			propertyGridControl1.RepositoryItems.Add(ri)
			propertyGridControl1.GetRowByFieldName("Phone").Properties.RowEdit = ri
		End Sub
	End Class

	Public Class Record
		Private _name As String
		Private _phone As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				_name = value
			End Set
		End Property
		Public Property Phone() As String
			Get
				Return _phone
			End Get
			Set(ByVal value As String)
				_phone = value
			End Set
		End Property
	End Class
End Namespace
