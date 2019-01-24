Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace ChartUpdateExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.BestFit()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim cachedData As New List(Of Object)()
			Dim data As IList = pivotGridControl1
			Dim props As PropertyDescriptorCollection = DirectCast(pivotGridControl1, ITypedList).GetItemProperties(Nothing)
			Dim pdValues As PropertyDescriptor = props("Values"), pdSeries As PropertyDescriptor = props("Series"), pdArguments As PropertyDescriptor = props("Arguments")
			For i As Integer = 0 To data.Count - 1
				Dim series As Object = pdSeries.GetValue(data(i))
				Dim argument As Object = pdArguments.GetValue(data(i))
				Dim value As Object = pdValues.GetValue(data(i))
				cachedData.Add(New Record(If(value Is DBNull.Value, 0, Convert.ToInt32(value)), argument, series))
			Next i

			chartControl1.SeriesDataMember = "Series"
			chartControl1.SeriesTemplate.ArgumentDataMember = "Argument"
			chartControl1.SeriesTemplate.ValueDataMembers.Clear()
			chartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Value" })
			chartControl1.DataSource = cachedData
		End Sub
	End Class
End Namespace