'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text

Public Class WarPlayer
    Public Property Hand As New Queue(Of Card)
    Public Property Captures As New Queue(Of Card)

    Public Function GetHand() As Integer
        Return Hand.Count
    End Function

    Public Function GetCaptures() As Integer
        Return Captures.Count
    End Function
End Class
