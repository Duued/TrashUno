Public Class Card
    Private intNumber As Integer
    Private CColor As CardColor
    Private imgCover As Image

    Public Sub New(ByVal intNumIn As Integer, ColorIn As CardColor, imgIn As Image)
        intNumber = intNumIn
        CColor = ColorIn
        imgCover = imgIn
    End Sub

    Public Sub New(ByVal intNumIn As Integer, ColorIn As CardColor)
        intNumber = intNumIn
        CColor = ColorIn
    End Sub

    Public Sub New(ByVal strTypeIn As String, Optional ByVal ColorIn As CardColor = CardColor.None)
        If strTypeIn.ToLower() = "4wild" Then
            intNumber = -1
            CColor = CardColor.None
            imgCover = My.Resources.UnoDraw4
        ElseIf strTypeIn.ToLower() = "wild" Then
            intNumber = -1
            CColor = CardColor.None
            imgCover = My.Resources.WildCard
        ElseIf strTypeIn.ToLower() = "reverse" Then
            intNumber = -2
            If ColorIn = CardColor.Blue Then
                imgCover = My.Resources.unobluereverse
            ElseIf ColorIn = CardColor.Red Then
                imgCover = My.Resources.unoredreverse
            ElseIf ColorIn = CardColor.Green Then
                imgCover = My.Resources.unogreenreverse
            Else
                imgCover = My.Resources.unoyellowreverse
            End If
        ElseIf strTypeIn.ToLower() = "skip" Then
            intNumber = -3
            If ColorIn = CardColor.Blue Then
                imgCover = My.Resources.UnoBlueSkip
            ElseIf ColorIn = CardColor.Red Then
                imgCover = My.Resources.UnoRedSkip
            ElseIf ColorIn = CardColor.Green Then
                imgCover = My.Resources.UnoGreenSkip
            Else
                imgCover = My.Resources.UnoYellowSkip
            End If
        Else
            MsgBox("Invalid strTypeIn. (Parameter error)", vbCritical, "Invalid paremeter")
            End
        End If
    End Sub

    Public Sub New(ByVal strTypeIn As String, Optional ByVal strColorIn As String = "None")
        If strColorIn = "None" Then
            CColor = CardColor.None
        End If
        If strTypeIn.ToLower() = "4wild" Then
            intNumber = -1
            CColor = CardColor.None
            imgCover = My.Resources.UnoDraw4
        ElseIf strTypeIn.ToLower() = "wild" Then
            intNumber = -1
            CColor = CardColor.None
            imgCover = My.Resources.WildCard
        ElseIf strTypeIn.ToLower() = "reverse" Then
            intNumber = -2
            CColor = strColorIn
            If CColor = CardColor.Blue Then
                imgCover = My.Resources.unobluereverse
            ElseIf CColor = CardColor.Red Then
                imgCover = My.Resources.unoredreverse
            ElseIf CColor = CardColor.Green Then
                imgCover = My.Resources.unogreenreverse
            Else
                imgCover = My.Resources.unoyellowreverse
            End If

        ElseIf strTypeIn.ToLower() = "skip" Then
            intNumber = -3
            If CColor = CardColor.Blue Then
                imgCover = My.Resources.UnoBlueSkip
            ElseIf CColor = CardColor.Red Then
                imgCover = My.Resources.UnoRedSkip
            ElseIf CColor = CardColor.Green Then
                imgCover = My.Resources.UnoGreenSkip
            Else
                imgCover = My.Resources.UnoYellowSkip
            End If
        Else
            MsgBox("Invalid strTypeIn. (Parameter error)", vbCritical, "Invalid paremeter")
            End
        End If
    End Sub


    Public Property Number As Integer
        Get
            Return intNumber
        End Get
        Set(value As Integer)
            intNumber = value
        End Set
    End Property

    Public Property Color As CardColor
        Get
            Return CColor

        End Get
        Set(value As CardColor)
            CColor = value
        End Set
    End Property

    Public Property Cover As Image
        Get
            Return imgCover
        End Get
        Set(value As Image)
            imgCover = value
        End Set
    End Property

    Public Enum CardColor
        Red = 1
        Green = 2
        Blue = 3
        Yellow = 4
        None = 5
    End Enum

    Public Shared Function DetermineColor(ByVal intNum As Integer) As CardColor
        If intNum > 4 Or intNum < 1 Then
            Return -1
        End If
        If intNum = 1 Then
            Return CardColor.Red
        ElseIf intNum = 2 Then
            Return CardColor.Green
        ElseIf intNum = 3 Then
            Return CardColor.Blue
        Else
            Return CardColor.Yellow
        End If
    End Function

    Public Shared Function DetermineColor(ByVal CardColorIn As CardColor) As Integer
        If CardColorIn = CardColor.Red Then
            Return 1
        ElseIf CardColorIn = CardColor.Green Then
            Return 2
        ElseIf CardColorIn = CardColor.Blue Then
            Return 3
        Else
            Return 4
        End If
    End Function

    Public Function Compare(ByRef CardIn As Card) As Boolean
        If CardIn.Color = CColor Then
            Return True
        Else
            If CardIn.Number = intNumber Then
                Return True
            ElseIf intNumber = -1 Then
                Return True
            ElseIf intNumber = CardIn.Number Then
                Return True
            Else
                If CardIn.Number = -1 Then
                    If CardIn.Color = CardColor.None And CColor = CardColor.None Then
                        Return True
                    Else
                        If CardIn.Color = CColor Then
                            Return True
                        End If
                    End If
                End If
            End If
        End If
        Return False
    End Function

    Public Shared Sub Redraw(ByRef lblLabelsIn() As Label, ByRef picBoxesIn() As PictureBox, ByRef CardsIn() As Card)
        Dim intIndex As Integer
        For intIndex = 0 To UBound(lblLabelsIn)
            lblLabelsIn(intIndex).Text = ""
            picBoxesIn(intIndex).Image = Nothing
        Next intIndex
        For intIndex = 0 To UBound(CardsIn)
            If CardsIn(intIndex).Number <> -1 And CardsIn(intIndex).Number <> -2 And CardsIn(intIndex).Number <> -3 Then
                lblLabelsIn(intIndex).Text = CardsIn(intIndex).Number
            Else
                lblLabelsIn(intIndex).Text = ""
            End If
            picBoxesIn(intIndex).Image = CardsIn(intIndex).Cover

        Next intIndex
    End Sub


End Class