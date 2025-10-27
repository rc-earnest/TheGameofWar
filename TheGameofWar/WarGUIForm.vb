'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text
Imports System.Threading
Public Class WarGUIForm
    Private game As New WarGameLogic
    Private roundNumber As Integer
    'subs-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'event handlers------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartRoundButton_Click(sender As Object, e As EventArgs) Handles StartRoundButton.Click
        If roundNumber = 0 Then
            game.Shuffle()
            game.Deal()
        Else
            MsgBox("Error, you cannot start a game right now. Press okay to conitnue", MsgBoxStyle.OkOnly)
        End If
        GameTimer.Enabled = True
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If game.p1.GetHand > 0 And game.p2.GetHand > 0 Then
            game.PlayNextStep()
            roundNumber += 1
            RndsPlayedLabel.Text = ($"Round:{CStr(roundNumber)}")
            P1CardsLabel.Text = ($"Player 1 Cards in Hand: {CStr(game.p1.GetHand())}")
            P1CapLabel.Text = ($"Player 1 Cards Captured: {CStr(game.p1.GetCaptures())}")
            P2CardsLabel.Text = ($"Player 2 Cards in Hand: {CStr(game.p2.GetHand())}")
            P2CapLabel.Text = ($"Player 2 Cards Captured: {CStr(game.p2.GetCaptures())}")
            WarsPlayedLabel.Text = ($"Total Wars Played this game: {CStr(game.wars)}")
            RndWinLabel.Text = ($"Round Winner: {game.roundWinner}")
        Else
            GameTimer.Enabled = False
            game.EndGame()
            GameWinnerLabel.Text = ($"Game Winner: {game.gameWinner}")
            roundNumber = 0
        End If
    End Sub

    Private Sub EndRoundButton_Click(sender As Object, e As EventArgs) Handles EndRoundButton.Click
        GameTimer.Enabled = False
        game.EndGame()
        GameWinnerLabel.Text = ($"Game Winner: {game.gameWinner}")
        roundNumber = 0
        MessageBox.Show("Round Has Ended Successfully")
    End Sub
End Class
