'Rudy Earnest
'RCET 3371
'Fall 2025
'Game of War
Option Strict On
Option Explicit On
Option Compare Text

Public Class Card


    Private _suit As String
    Public Property Suit() As String
        Get
            Return _suit
        End Get
        Set(ByVal value As String)
            _suit = value
        End Set
    End Property

    Private _rank As String
    Public Property Rank() As String
        Get
            Return _rank
        End Get
        Set(ByVal value As String)
            _rank = value
        End Set
    End Property

    Private _frontImage As Image
    Public Property FrontImage() As Image
        Get
            Return _frontImage
        End Get
        Set(ByVal value As Image)
            _frontImage = value
        End Set
    End Property

    Private _backImage As Image
    Public Property BackImage() As Image
        Get
            Return _backImage
        End Get
        Set(ByVal value As Image)
            _backImage = value
        End Set
    End Property

    Sub New(rank As String, suit As String)

        Me.Suit = suit.ToUpper
        Me.Rank = rank.ToUpper
        Me.FrontImage = CType(My.Resources.ResourceManager.GetObject($"{Me.Rank}{Me.Suit}"), Image)
        If Me.FrontImage Is Nothing Then
            Me.FrontImage = CType(My.Resources.ResourceManager.GetObject($"_{Me.Rank}{Me.Suit}"), Image)
        End If
        If Me.FrontImage Is Nothing Then
            Me.FrontImage = My.Resources.aces
        End If

        Me.BackImage = My.Resources.Green_back

    End Sub

End Class
