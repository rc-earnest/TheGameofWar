'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text

Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        GameLabel.Text = "Game of War" & vbCrLf & "Version 1.0"
        HeaderLabel.Text = "Rudy Earnest" & vbCrLf & "RCET 3371" & vbCrLf & "Fall 2025"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class