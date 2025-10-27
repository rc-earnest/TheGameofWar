'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text

Public Class SplashScreenForm
    ' Set the timer to enabled when the form loads
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 
        ' Note: Add a label, image, or progress bar to the form in the designer
        ' to make it look good!

        SplashTimer.Enabled = True ' Start the 3-second countdown
    End Sub

    ' This event fires once the timer's interval (e.g., 3000ms) has passed
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick

        ' 1. Stop the timer immediately so it doesn't run again
        SplashTimer.Enabled = False

        Me.Hide()

        ' 2. Create and display the main game form
        Dim mainForm As New WarGUIForm
        mainForm.Show()

        Application.DoEvents()

        Me.Close()
    End Sub

End Class