Option Strict On
Option Explicit On
Option Compare Text
'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Imports System.Threading

Public Class WarGameLogic

    'Variable Declarations-------------------------------------------------------------------------------------------------------------------------------------------

    Public p1 As New WarPlayer
    Public p2 As New WarPlayer
    Public wars As Integer
    Public roundWinner As String
    Public gameWinner As String
    Private _deck As New Queue(Of Card)
    Private isInWar As Boolean = False
    Private WarPot As New Queue(Of Card)
    Private LastP1Card As Card
    Private LastP2Card As Card


    'subs------------------------------------------------------------------------------------------------------------------------------------------------------------

    ''' <summary>
    ''' shuffles a 52 card deck and ensures that there are no duplicate cards
    ''' </summary>
    Public Sub Shuffle()
        Dim _suit, _rank As String
        Dim tracker As New List(Of String)

        Do Until Me.CardsRemaining >= 52
            _rank = GetRank(RandomNumber(13))
            _suit = GetSuit(RandomNumber(4))
            '_rank = "a"
            '_suit = "s"


            If Not (tracker.Contains(_rank & _suit)) Then
                Dim newCard As New Card(_rank, _suit)
                Me._deck.Enqueue(newCard)
                tracker.Add(_rank & _suit)
            End If
        Loop

    End Sub

    ''' <summary>
    ''' Deals Cards evenly between player 1 and player 2
    ''' </summary>
    Public Sub Deal()
        Dim cardToDeal As Card


        Dim dealTurn As Integer = 1 ' 1 for P1, 2 for P2. Start with P1.
        ' Loop while there are still cards in the deck
        Do While Me.CardsRemaining > 0
            ' Dequeue (take) the next card from the deck
            cardToDeal = Me._deck.Dequeue()

            ' Deal to Player 1 or Player 2 based on the turn
            If dealTurn = 1 Then
                ' Deal to P1's hand
                p1.Hand.Enqueue(cardToDeal)
                ' Change turn to Player 2
                dealTurn = 2
            Else
                ' Deal to P2's hand
                p2.Hand.Enqueue(cardToDeal)
                ' Change turn back to Player 1
                dealTurn = 1
            End If
        Loop
        If p1.GetHand = p2.GetHand And p1.GetHand > 0 Then
            Console.WriteLine("Cards dealt evenly. P1: " & p1.GetHand & ", P2: " & p2.GetHand)
        Else
            Console.WriteLine("Warning: Cards not dealt evenly or deck was empty.")
        End If
    End Sub

    Public Sub PlayNextStep()
        If p1.GetHand = 0 Or p2.GetHand = 0 Then
            EndGame()
            Return
        End If

        If isInWar Then
            ExecuteOrder66()
        Else
            StartNewRound()
        End If
    End Sub

    Private Sub ExecuteOrder66()
        wars += 1
        If p1.GetHand = 0 Or p2.GetHand = 0 Then
            WarPot.Enqueue(LastP1Card)
            WarPot.Enqueue(LastP2Card)
            EndGame()
            Return
        Else
            Dim tempCard As Card
            If p1.GetHand >= 4 Then
                For i = 1 To 3
                    tempCard = p1.Hand.Dequeue()
                    WarPot.Enqueue(tempCard)
                Next
            Else
                Do Until p1.GetHand = 1
                    tempCard = p1.Hand.Dequeue()
                    WarPot.Enqueue(tempCard)
                Loop
            End If

            If p2.GetHand >= 4 Then
                For i = 1 To 3
                    tempCard = p2.Hand.Dequeue()
                    WarPot.Enqueue(tempCard)
                Next
            Else
                Do Until p2.GetHand = 1
                    tempCard = p2.Hand.Dequeue()
                    WarPot.Enqueue(tempCard)
                Loop
            End If
            LastP1Card = p1.Hand.Dequeue
            LastP2Card = p2.Hand.Dequeue
            If DecodeRank(LastP1Card.Rank) > DecodeRank(LastP2Card.Rank) Then
                roundWinner = "Player 1"
                isInWar = False
                While WarPot.Count > 0
                    p1.Captures.Enqueue(WarPot.Dequeue)
                End While
            ElseIf DecodeRank(LastP1Card.Rank) < DecodeRank(LastP2Card.Rank) Then
                roundWinner = "Player 2"
                isInWar = False
                While WarPot.Count > 0
                    p2.Captures.Enqueue(WarPot.Dequeue)
                End While
            Else
                isInWar = True
                WarPot.Enqueue(LastP1Card)
                WarPot.Enqueue(LastP2Card)
                'MessageBox.Show("The War Continues...")
            End If
        End If
    End Sub

    Private Sub StartNewRound()
        WarPot.Clear()
        LastP1Card = p1.Hand.Dequeue()
        LastP2Card = p2.Hand.Dequeue()
        Dim p1Rank As Integer = DecodeRank(LastP1Card.Rank)
        Dim p2Rank As Integer = DecodeRank(LastP2Card.Rank)
        If p1Rank = p2Rank Then
            WarPot.Enqueue(LastP1Card)
            WarPot.Enqueue(LastP2Card)
            ExecuteOrder66()
            Return
        ElseIf p1Rank > p2Rank Then
            roundWinner = "Player 1"
            p1.Captures.Enqueue(LastP1Card)
            p1.Captures.Enqueue(LastP2Card)
        ElseIf p1Rank < p2Rank Then
            roundWinner = "Player 2"
            p2.Captures.Enqueue(LastP1Card)
            p2.Captures.Enqueue(LastP2Card)
        End If

    End Sub

    Public Sub EndGame()
        If p1.GetCaptures > p2.GetCaptures Then
            gameWinner = "Player 1"
        ElseIf p1.GetCaptures < p2.GetCaptures Then
            gameWinner = "Player 2"
        ElseIf p1.GetCaptures = p2.GetCaptures Then
            gameWinner = "Tie"
        End If
        isInWar = False
        WarPot.Clear()
        _deck.Clear()
        p1.Hand.Clear()
        p2.Hand.Clear()
        p1.Captures.Clear()
        p2.Captures.Clear()
        wars = 0
        roundWinner = ""
    End Sub

    'functions ------------------------------------------------------------------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Maps an integer code (1-4) to a single-character playing card suit code.
    ''' </summary>
    ''' <param name="suit">The integer representing the suit (1=Spades, 2=Hearts, 3=Clubs, 4=Diamonds).</param>
    ''' <returns>
    ''' A single-character string representing the suit ("s", "h", "c", or "d"). 
    ''' Returns "x" if the input integer is invalid (outside the 1-4 range).
    ''' </returns>
    Function GetSuit(suit As Integer) As String
        Dim _suit As String
        Select Case suit
            Case 1
                _suit = "s"
                Return _suit
            Case 2
                _suit = "h"
                Return _suit
            Case 3
                _suit = "c"
                Return _suit
            Case 4
                _suit = "d"
                Return _suit
            Case Else
                MsgBox("suit is invalid")
                _suit = "x"
                Return _suit
                Exit Function
        End Select
    End Function

    ''' <summary>
    ''' Maps an integer code (1-13) to the corresponding single- or double-character playing card rank code.
    ''' </summary>
    ''' <param name="rank">The integer representing the rank (1=Ace, 2-10=Number, 11=Jack, 12=Queen, 13=King).</param>
    ''' <returns>
    ''' A string representing the rank ("a", "2" through "10", "j", "q", or "k"). 
    ''' Returns "x" if the input integer is invalid (outside the 1-13 range).
    ''' </returns>
    Function GetRank(rank As Integer) As String
        Dim _rank As String
        Select Case rank
            Case 1
                _rank = "a"
                Return _rank
            Case 2 To 10
                _rank = CStr(rank)
                Return _rank
            Case 11
                _rank = "j"
                Return _rank
            Case 12
                _rank = "q"
                Return _rank
            Case 13
                _rank = "k"
                Return _rank
            Case Else
                _rank = "x"
                MsgBox("rank is invalid")
                Return _rank
        End Select
    End Function

    ''' <summary>
    ''' Gets the current count of the deck
    ''' </summary>
    ''' <returns>_deck.Count</returns>
    Function CardsRemaining() As Integer
        Return _deck.Count
    End Function

    ''' <summary>
    ''' gets a random number within the range of max and min
    ''' </summary>
    ''' <param name="max"></param>
    ''' <param name="min"></param>
    ''' <returns>number within max to min</returns>
    Private Function RandomNumber(max As Integer, Optional min As Integer = 1) As Integer
        Randomize()
        Return CInt(System.Math.Floor((Rnd() * max) + min))
    End Function

    Private Function DecodeRank(rank As String) As Integer
        Dim _rank As Integer
        Select Case rank
            Case "a"
                _rank = 14
                Return _rank
            Case "1"
                _rank = 1
                Return _rank
            Case "2"
                _rank = 2
                Return _rank
            Case "3"
                _rank = 3
                Return _rank
            Case "4"
                _rank = 4
                Return _rank
            Case "5"
                _rank = 5
                Return _rank
            Case "6"
                _rank = 6
                Return _rank
            Case "7"
                _rank = 7
                Return _rank
            Case "8"
                _rank = 8
                Return _rank
            Case "9"
                _rank = 9
                Return _rank
            Case "10"
                _rank = 10
                Return _rank
            Case "j"
                _rank = 11
                Return _rank
            Case "q"
                _rank = 12
                Return _rank
            Case "k"
                _rank = 13
                Return _rank
            Case Else
                MsgBox("you shouldn't be here...")
                Return 15
        End Select


    End Function
End Class
