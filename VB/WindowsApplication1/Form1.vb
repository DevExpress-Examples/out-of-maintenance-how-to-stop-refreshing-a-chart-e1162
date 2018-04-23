Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs)

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet1.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet1.Categories)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim cachedData As New List(Of Object)()
			Dim data As IList = pivotGridControl1
			Dim props As PropertyDescriptorCollection = (CType(pivotGridControl1, ITypedList)).GetItemProperties(Nothing)
			Dim pdValues As PropertyDescriptor = props("Values"), pdSeries As PropertyDescriptor = props("Series"), pdArguments As PropertyDescriptor = props("Arguments")
			For i As Integer = 0 To data.Count - 1
				Dim serie As Object = pdSeries.GetValue(data(i))
				Dim argument As Object = pdArguments.GetValue(data(i))
				Dim value As Object = pdValues.GetValue(data(i))
				If value Is DBNull.Value Then
					cachedData.Add(New Record(0, argument, serie))
				Else
					cachedData.Add(New Record(Convert.ToInt32(value), argument, serie))
				End If
			Next i

			chartControl1.SeriesDataMember = "Series"
			chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			chartControl1.SeriesTemplate.ValueDataMembers.Clear()
			chartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Values" })
			chartControl1.DataSource = cachedData
		End Sub

		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged

		End Sub
	End Class

	Public Class Record
		Private value As Integer

		Public Property Values() As Integer
			Get
				Return Me.value
			End Get
			Set(ByVal value As Integer)
				Me.value = value
			End Set
		End Property
		Private argument As Object

		Public Property Arguments() As Object
			Get
				Return argument
			End Get
			Set(ByVal value As Object)
				argument = value
			End Set
		End Property

		Private series_Renamed As Object
		Public Property Series() As Object
			Get
				Return series_Renamed
			End Get
			Set(ByVal value As Object)
				series_Renamed = value
			End Set
		End Property


		Public Sub New(ByVal value As Integer, ByVal argument As Object, ByVal series As Object)
			Me.value = value
			Me.argument = argument
			Me.series_Renamed = series

		End Sub

	End Class
End Namespace