Public Class frmGamemaster
    'Public Structure Question
    '    Dim strPrompt As String
    '    Dim strAnswer As String
    'End Structure
    Private btnButtons() As Button
    Private inFile As IO.StreamReader
    Private strColors() As String = {"Red", "Blue", "Green", "Yellow"}
    Public Discard As Card
    Public intGivenD4 As Integer ' Draw4
    Public intGivenW As Integer 'Wild
    Public intGivenRe As Integer ' Reverses
    Public intGivenS As Integer 'skips
    Public intGivenR As Integer 'Regular, numeric cards
    Public intCurrent As Integer ' Current player

    Private Sub FrmGamemaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.AppStarting
        btnButtons = {btnGame}
        Dim intIndex As Integer
        For intIndex = 0 To UBound(btnButtons)
            btnButtons(intIndex).Visible = False
        Next intIndex
        Cursor = Cursors.Default
        For intIndex = 0 To UBound(btnButtons)
            btnButtons(intIndex).Visible = True
        Next intIndex
        lblSelect.Text = "Select an action..."
        Randomize()

    End Sub

    Private Sub BtnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        MsgBox("Now starting game... Please wait...")
        frmPlayer2.Show()
        frmPlayer1.Show()
        frmPlayer1.ClearAll()
        intGivenD4 = 0
        intGivenR = 0
        intGivenRe = 0
        intGivenW = 0
        intGivenS = 0
        Dim intIndex As Integer, intChoice As Integer, blnValid As Boolean, intChoice2 As Integer
        For intIndex = 0 To 6
            ReDim Preserve frmPlayer1.MyCards(UBound(frmPlayer1.MyCards) + 1)
            Do
                intChoice = Int(Rnd() * 4 + 1)

                If intChoice = 1 Then
                    'Reverse/Skip
                    intChoice = Int(Rnd() * 2 + 1)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    If intChoice = 1 Then
                        'Reverse
                        frmPlayer1.MyCards(intIndex) = New Card("reverse", Card.DetermineColor(intChoice2))
                        frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                        frmPlayer1.lblLabels(intIndex).Text = ""
                        If intGivenRe = 8 Then
                            blnValid = False
                        Else
                            intGivenRe += 1
                            blnValid = True
                        End If
                    Else
                        'Skip
                        frmPlayer1.MyCards(intIndex) = New Card("skip", Card.DetermineColor(intChoice2))
                        frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                        frmPlayer1.lblLabels(intIndex).Text = ""
                        If intGivenS = 8 Then
                            blnValid = False
                        Else
                            intGivenS += 1
                            blnValid = True
                        End If
                    End If

                ElseIf intChoice = 2 Then
                    'Draw4Wild
                    frmPlayer1.MyCards(intIndex) = New Card("4wild", Card.CardColor.None)
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    frmPlayer1.lblLabels(intIndex).Text = ""
                    intGivenD4 += 1
                    If intGivenD4 >= 4 Then
                        blnValid = False
                        intGivenD4 = 4
                    Else
                        blnValid = True

                    End If
                ElseIf intChoice = 3 Then
                    'Wild
                    intGivenW += 1
                    frmPlayer1.MyCards(intIndex) = New Card("wild", Card.CardColor.None)
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    frmPlayer1.lblLabels(intIndex).Text = ""
                    If intGivenW >= 4 Then
                        blnValid = False
                        intGivenW = 4
                    Else
                        blnValid = True
                    End If
                Else
                    'Numeric Card
                    intChoice = Int(Rnd() * 9)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    frmPlayer1.MyCards(intIndex) = New Card(intChoice, Card.DetermineColor(intChoice2))
                    If frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Red Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.RedUno
                    ElseIf frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Green Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.GreenUno
                    ElseIf frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Blue Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.BlueUno
                    Else
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.YellowUno
                    End If
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    If frmPlayer1.MyCards(intIndex).Number <> -1 Then
                        frmPlayer1.lblLabels(intIndex).Text = frmPlayer1.MyCards(intIndex).Number
                    End If
                End If

            Loop Until blnValid


        Next intIndex

        'PLAYER 2
        For intIndex = 0 To 6
            ReDim Preserve frmPlayer2.MyCards(UBound(frmPlayer2.MyCards) + 1)
            Do
                intChoice = Int(Rnd() * 4 + 1)

                If intChoice = 1 Then
                    'Reverse/Skip
                    intChoice = Int(Rnd() * 2 + 1)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    If intChoice = 1 Then
                        'Reverse
                        frmPlayer2.MyCards(intIndex) = New Card("reverse", Card.DetermineColor(intChoice2))
                        frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                        frmPlayer2.lblLabels(intIndex).Text = ""
                        If intGivenRe = 8 Then
                            blnValid = False
                        Else
                            intGivenRe += 1
                            blnValid = True
                        End If
                    Else
                        'Skip
                        frmPlayer2.MyCards(intIndex) = New Card("skip", Card.DetermineColor(intChoice2))
                        frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                        frmPlayer2.lblLabels(intIndex).Text = ""
                        If intGivenS = 8 Then
                            blnValid = False
                        Else
                            intGivenS += 1
                            blnValid = True
                        End If
                    End If

                ElseIf intChoice = 2 Then
                    'Draw4Wild
                    frmPlayer2.MyCards(intIndex) = New Card("4wild", Card.CardColor.None)
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    frmPlayer2.lblLabels(intIndex).Text = ""
                    intGivenD4 += 1
                    If intGivenD4 >= 4 Then
                        blnValid = False
                        intGivenD4 = 4
                    Else
                        blnValid = True

                    End If
                ElseIf intChoice = 3 Then
                    'Wild
                    intGivenW += 1
                    frmPlayer2.MyCards(intIndex) = New Card("wild", Card.CardColor.None)
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    frmPlayer2.lblLabels(intIndex).Text = ""
                    If intGivenW >= 4 Then
                        blnValid = False
                        intGivenW = 4
                    Else
                        blnValid = True
                    End If
                Else
                    'Numeric Card
                    intChoice = Int(Rnd() * 9)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    frmPlayer2.MyCards(intIndex) = New Card(intChoice, Card.DetermineColor(intChoice2))
                    If frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Red Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.RedUno
                    ElseIf frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Green Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.GreenUno
                    ElseIf frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Blue Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.BlueUno
                    Else
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.YellowUno
                    End If
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    If frmPlayer2.MyCards(intIndex).Number <> -1 Then
                        frmPlayer2.lblLabels(intIndex).Text = frmPlayer2.MyCards(intIndex).Number
                    End If
                End If

            Loop Until blnValid
            picDraw.Visible = True


        Next intIndex

        intChoice = Int(Rnd() * 9)
        intChoice2 = Int(Rnd() * 4 + 1)

        Discard = New Card(intChoice, Card.DetermineColor(intChoice2))
        If Discard.Color = Card.CardColor.Red Then
            Discard.Cover = My.Resources.RedUno
        ElseIf Discard.Color = Card.CardColor.Green Then
            Discard.Cover = My.Resources.GreenUno
        ElseIf Discard.Color = Card.CardColor.Blue Then
            Discard.Cover = My.Resources.BlueUno
        Else
            Discard.Cover = My.Resources.YellowUno
        End If
        picDiscard.Image = Discard.Cover
        lblDiscardNum.Text = Discard.Number
        frmPlayer1.Hide()
        frmPlayer2.Hide()
        MsgBox("Player One's Turn! Have player two turn their back or close their eyes.", Title:="Revealing Player One Cards.")
        frmPlayer1.Show()
        intCurrent = 1

        MsgBox(UBound(frmPlayer1.MyCards))
    End Sub

    Private Sub ColorSelected(sender As Object, e As EventArgs) Handles radBlue.Click, radGreen.Click, radRed.Click, radYellow.Click


    End Sub

    Private Sub DrawCard(sender As Object, e As EventArgs) Handles picDraw.Click
        Dim intChoice As Integer, intChoice2 As Integer, intIndex As Integer, blnValid As Boolean

        If intCurrent = 1 Then
            intIndex = UBound(frmPlayer1.MyCards) + 1
            Do
                intChoice = Int(Rnd() * 4 + 1)

                If intChoice = 1 Then
                    'Reverse/Skip
                    intChoice = Int(Rnd() * 2 + 1)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    If intChoice = 1 Then
                        'Reverse
                        frmPlayer1.MyCards(intIndex) = New Card("reverse", Card.DetermineColor(intChoice2))
                        frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                        frmPlayer1.lblLabels(intIndex).Text = ""
                        If intGivenRe = 8 Then
                            blnValid = False
                        Else
                            intGivenRe += 1
                            blnValid = True
                        End If
                    Else
                        'Skip
                        frmPlayer1.MyCards(intIndex) = New Card("skip", Card.DetermineColor(intChoice2))
                        frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                        frmPlayer1.lblLabels(intIndex).Text = ""
                        If intGivenS = 8 Then
                            blnValid = False
                        Else
                            intGivenS += 1
                            blnValid = True
                        End If
                    End If

                ElseIf intChoice = 2 Then
                    'Draw4Wild
                    frmPlayer1.MyCards(intIndex) = New Card("4wild", Card.CardColor.None)
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    frmPlayer1.lblLabels(intIndex).Text = ""
                    intGivenD4 += 1
                    If intGivenD4 >= 4 Then
                        blnValid = False
                        intGivenD4 = 4
                    Else
                        blnValid = True

                    End If
                ElseIf intChoice = 3 Then
                    'Wild
                    intGivenW += 1
                    frmPlayer1.MyCards(intIndex) = New Card("wild", Card.CardColor.None)
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    frmPlayer1.lblLabels(intIndex).Text = ""
                    If intGivenW >= 4 Then
                        blnValid = False
                        intGivenW = 4
                    Else
                        blnValid = True
                    End If
                Else
                    'Numeric Card
                    intChoice = Int(Rnd() * 9)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    frmPlayer1.MyCards(intIndex) = New Card(intChoice, Card.DetermineColor(intChoice2))
                    If frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Red Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.RedUno
                    ElseIf frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Green Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.GreenUno
                    ElseIf frmPlayer1.MyCards(intIndex).Color = Card.CardColor.Blue Then
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.BlueUno
                    Else
                        frmPlayer1.MyCards(intIndex).Cover = My.Resources.YellowUno
                    End If
                    frmPlayer1.picBoxes(intIndex).Image = frmPlayer1.MyCards(intIndex).Cover
                    If frmPlayer1.MyCards(intIndex).Number <> -1 Then
                        frmPlayer1.lblLabels(intIndex).Text = frmPlayer1.MyCards(intIndex).Number
                    End If
                End If

            Loop Until blnValid
        Else
            Do
                intChoice = Int(Rnd() * 4 + 1)

                If intChoice = 1 Then
                    'Reverse/Skip
                    intChoice = Int(Rnd() * 2 + 1)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    If intChoice = 1 Then
                        'Reverse
                        frmPlayer2.MyCards(intIndex) = New Card("reverse", Card.DetermineColor(intChoice2))
                        frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                        frmPlayer2.lblLabels(intIndex).Text = ""
                        If intGivenRe = 8 Then
                            blnValid = False
                        Else
                            intGivenRe += 1
                            blnValid = True
                        End If
                    Else
                        'Skip
                        frmPlayer2.MyCards(intIndex) = New Card("skip", Card.DetermineColor(intChoice2))
                        frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                        frmPlayer2.lblLabels(intIndex).Text = ""
                        If intGivenS = 8 Then
                            blnValid = False
                        Else
                            intGivenS += 1
                            blnValid = True
                        End If
                    End If

                ElseIf intChoice = 2 Then
                    'Draw4Wild
                    frmPlayer2.MyCards(intIndex) = New Card("4wild", Card.CardColor.None)
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    frmPlayer2.lblLabels(intIndex).Text = ""
                    intGivenD4 += 1
                    If intGivenD4 >= 4 Then
                        blnValid = False
                        intGivenD4 = 4
                    Else
                        blnValid = True

                    End If
                ElseIf intChoice = 3 Then
                    'Wild
                    intGivenW += 1
                    frmPlayer2.MyCards(intIndex) = New Card("wild", Card.CardColor.None)
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    frmPlayer2.lblLabels(intIndex).Text = ""
                    If intGivenW >= 4 Then
                        blnValid = False
                        intGivenW = 4
                    Else
                        blnValid = True
                    End If
                Else
                    'Numeric Card
                    intChoice = Int(Rnd() * 9)
                    intChoice2 = Int(Rnd() * 4 + 1)

                    frmPlayer2.MyCards(intIndex) = New Card(intChoice, Card.DetermineColor(intChoice2))
                    If frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Red Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.RedUno
                    ElseIf frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Green Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.GreenUno
                    ElseIf frmPlayer2.MyCards(intIndex).Color = Card.CardColor.Blue Then
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.BlueUno
                    Else
                        frmPlayer2.MyCards(intIndex).Cover = My.Resources.YellowUno
                    End If
                    frmPlayer2.picBoxes(intIndex).Image = frmPlayer2.MyCards(intIndex).Cover
                    If frmPlayer2.MyCards(intIndex).Number <> -1 And frmPlayer2.MyCards(intIndex).Number <> -2 And frmPlayer2.MyCards(intIndex).Number <> -3 Then
                        frmPlayer2.lblLabels(intIndex).Text = frmPlayer2.MyCards(intIndex).Number
                    Else
                        frmPlayer2.lblLabels(intIndex).Text = ""
                    End If
                End If

            Loop Until blnValid
        End If



    End Sub

End Class