Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ChartUpdateExample
	Public Class Record
		Public Property Value() As Integer
		Public Property Argument() As Object
		Public Property Series() As Object

		Public Sub New(ByVal value As Integer, ByVal argument As Object, ByVal series As Object)
			Me.Value = value
			Me.Argument = argument
			Me.Series = series
		End Sub
	End Class
End Namespace
