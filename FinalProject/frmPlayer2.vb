Imports System.ComponentModel

Public Class frmPlayer2
    Public MyCards(-1) As Card
    Public picBoxes() As PictureBox
    Public lblLabels() As Label
    Private Sub FrmPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBoxes = {picBox1, picBox2, picBox3, picBox4, picBox5, picBox6, picBox7, picBox8, picBox9, picBox10, picBox11, picBox12, picBox13, picBox14, picBox15, picBox16, picBox17, picBox18}
        lblLabels = {lblNum1, lblNum2, lblNum3, lblNum4, lblNum5, lblNum6, lblNum7, lblNum8, lblNum9, lblNum10, lblNum11, lblNum12, lblNum13, lblNum14, lblNum15, lblNum16, lblNum17, lblNum18}
    End Sub

    Private Sub CardClick(sender As Object, e As EventArgs) Handles picBox1.Click, picBox2.Click, picBox3.Click, picBox4.Click, picBox5.Click, picBox6.Click, picBox7.Click, picBox8.Click, picBox9.Click, picBox10.Click, picBox11.Click, picBox12.Click, picBox13.Click, picBox14.Click, picBox15.Click, picBox16.Click, picBox17.Click, picBox18.Click

    End Sub

    Public Sub ClearAll()
        Dim intIndex As Integer
        For intIndex = 0 To UBound(picBoxes)
            picBoxes(intIndex).Image = Nothing
            lblLabels(intIndex).Text = ""
        Next intIndex
    End Sub

    Private Sub CancelClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        MsgBox("No close. You'll break game.", Title:="No Close.")
    End Sub
End Class