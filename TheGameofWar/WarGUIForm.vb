'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text
Imports System.Threading
Imports System.Drawing
Public Class WarGUIForm
    Private game As New WarGameLogic
    Private roundNumber As Integer
    'subs & functions-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub InitializeCardGraphics()
        ' List all the PictureBoxes involved in the card display
        Dim allCardPictureBoxes = New PictureBox() {
            P1Card1PictureBox, P1Card2PictureBox, P1Card3PictureBox, P1Card4PictureBox, P1Card5PictureBox,
            P2Card1PictureBox, P2Card2PictureBox, P2Card3PictureBox, P2Card4PictureBox, P2Card5PictureBox
        }

        ' Loop through the list and set the Visible property to False
        For Each pictureBox In allCardPictureBoxes
            pictureBox.Visible = False
            'This thing is amazing and makes sure the image is the same size as the picture box highly recommend
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Next
    End Sub
    Private Function GetCardImageName(c As Card) As String
        Dim rankChar As String = c.Rank.ToUpper()
        Dim suitChar As String = c.Suit.ToUpper()
        Return rankChar & suitChar
    End Function

    Private Sub UpdateCardDisplay()
        ' Group PictureBoxes for easy iteration
        Dim pictureBoxP1List = New PictureBox() {P1Card1PictureBox, P1Card2PictureBox, P1Card3PictureBox, P1Card4PictureBox, P1Card5PictureBox}
        Dim pictureBoxP2List = New PictureBox() {P2Card1PictureBox, P2Card2PictureBox, P2Card3PictureBox, P2Card4PictureBox, P2Card5PictureBox}

        ' Get the cards played in the last tick from the game logic
        Dim p1Cards = game.LastP1CardsPlayed
        Dim p2Cards = game.LastP2CardsPlayed

        ' --- Player 1 Display ---
        For i As Integer = 0 To pictureBoxP1List.Length - 1
            Dim pictureBox = pictureBoxP1List(i)

            If i < p1Cards.Count Then
                ' A card exists for this picture box slot
                pictureBox.Visible = True

                If i = 0 Or i = p1Cards.Count - 1 Then
                    pictureBox.Image = CType(My.Resources.ResourceManager.GetObject(GetCardImageName(p1Cards(i))), Image)
                Else
                    ' All previous cards in the stack are face-down.
                    pictureBox.Image = My.Resources.blue_back
                End If

            Else
                ' No card played in this position, hide the box
                pictureBox.Visible = False
            End If
        Next

        ' --- Player 2 Display ---
        For i As Integer = 0 To pictureBoxP2List.Length - 1
            Dim pictureBox = pictureBoxP2List(i)

            If i < p2Cards.Count Then
                pictureBox.Visible = True

                If i = 0 Or i = p2Cards.Count - 1 Then
                    pictureBox.Image = CType(My.Resources.ResourceManager.GetObject(GetCardImageName(p2Cards(i))), Image)
                Else
                    pictureBox.Image = My.Resources.Red_back
                End If
            Else
                pictureBox.Visible = False
            End If
        Next
    End Sub

    'event handlers------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartRoundButton_Click(sender As Object, e As EventArgs) Handles StartRoundButton.Click
        If roundNumber = 0 Then
            game.Shuffle()
            game.Deal()
        Else
            MessageBox.Show("Error, you cannot start a game right now. Press okay to conitnue")
        End If
        GameTimer.Enabled = True
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If game.p1.GetHand > 0 And game.p2.GetHand > 0 Then
            game.PlayNextStep()
            UpdateCardDisplay()
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

    Private Sub WarGUIForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeCardGraphics()
        GameTimer.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub
End Class
