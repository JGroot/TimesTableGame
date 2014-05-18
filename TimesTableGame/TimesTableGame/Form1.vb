Imports System
Imports System.String
Public Class frmTimeTable
    Dim strInput As String
    Dim strAnswer As String
    Dim intTotalRight As Integer


    Sub CheckAnswer(ByVal input As String, ByVal answer As String, ByRef txtbox As RichTextBox)
        intTotalRight = Convert.ToInt32(lblTotalRight.Text)

        If strInput = strAnswer Then
            txtbox.BackColor = Color.LightGreen
            lblInput.ForeColor = Color.Green
            txtbox.Enabled = False
            intTotalRight += 1
            lblTotalRight.Text = Convert.ToString(intTotalRight)
        ElseIf IsNullOrEmpty(strInput) Then
            txtbox.BackColor = Color.White
        Else
            txtbox.BackColor = Color.Red
            lblInput.ForeColor = Color.Red
        End If
    End Sub


    Private Sub txt0x0_TextChanged(sender As Object, e As EventArgs) Handles txt0x0.TextChanged
        txt0x0.SelectionAlignment = HorizontalAlignment.Center
        lblEquation.Text = "0 X 0 =  "
        strAnswer = "0"
        strInput = txt0x0.Text
        lblInput.Text = txt0x0.Text

        CheckAnswer(strInput, strAnswer, txt0x0)
    End Sub

    

    Private Sub txt0x0_GotFocus(sender As Object, e As EventArgs) Handles txt0x0.GotFocus
        lblEquation.Text = "0 X 0 ="
        txt0x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x1_GotFocus(sender As Object, e As EventArgs) Handles txt0x1.GotFocus
        lblEquation.Text = "0 X 1 ="
        txt0x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x2_GotFocus(sender As Object, e As EventArgs) Handles txt0x2.GotFocus
        lblEquation.Text = "0 X 2 ="
        txt0x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x3_GotFocus(sender As Object, e As EventArgs) Handles txt0x3.GotFocus
        lblEquation.Text = "0 X 3 ="
        txt0x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x4_GotFocus(sender As Object, e As EventArgs) Handles txt0x4.GotFocus
        lblEquation.Text = "0 X 4 ="
        txt0x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x5_GotFocus(sender As Object, e As EventArgs) Handles txt0x5.GotFocus
        lblEquation.Text = "0 X 5 ="
        txt0x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub txt0x6_GotFocus(sender As Object, e As EventArgs) Handles txt0x6.GotFocus
        lblEquation.Text = "0 X 6 ="
        txt0x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt0x7_GotFocus(sender As Object, e As EventArgs) Handles txt0x7.GotFocus
        lblEquation.Text = "0 X 7 ="
        txt0x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt0x8_GotFocus(sender As Object, e As EventArgs) Handles txt0x8.GotFocus
        lblEquation.Text = "0 X 8 ="
        txt0x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt0x9_GotFocus(sender As Object, e As EventArgs) Handles txt0x9.GotFocus
        lblEquation.Text = "0 X 9 ="
        txt0x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt0x10_GotFocus(sender As Object, e As EventArgs) Handles txt0x10.GotFocus
        lblEquation.Text = "0 X 10 ="
        txt0x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x0_GotFocus(sender As Object, e As EventArgs) Handles txt1x0.GotFocus
        lblEquation.Text = "1 X 0 ="
        txt1x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x1_GotFocus(sender As Object, e As EventArgs) Handles txt1x1.GotFocus
        lblEquation.Text = "1 X 1 ="
        txt1x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x2_GotFocus(sender As Object, e As EventArgs) Handles txt1x2.GotFocus
        lblEquation.Text = "1 X 2 ="
        txt1x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x3_GotFocus(sender As Object, e As EventArgs) Handles txt1x3.GotFocus
        lblEquation.Text = "1 X 3 ="
        txt1x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x4_GotFocus(sender As Object, e As EventArgs) Handles txt1x4.GotFocus
        lblEquation.Text = "1 X 4 ="
        txt1x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x5_GotFocus(sender As Object, e As EventArgs) Handles txt1x5.GotFocus
        lblEquation.Text = "1 X 5 ="
        txt1x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x6_GotFocus(sender As Object, e As EventArgs) Handles txt1x6.GotFocus
        lblEquation.Text = "1 X 6 ="
        txt1x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x7_GotFocus(sender As Object, e As EventArgs) Handles txt1x7.GotFocus
        lblEquation.Text = "1 X 7 ="
        txt1x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x8_GotFocus(sender As Object, e As EventArgs) Handles txt1x8.GotFocus
        lblEquation.Text = "1 X 8 ="
        txt1x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x9_GotFocus(sender As Object, e As EventArgs) Handles txt1x9.GotFocus
        lblEquation.Text = "1 X 9 ="
        txt1x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x10_GotFocus(sender As Object, e As EventArgs) Handles txt1x10.GotFocus
        lblEquation.Text = "1 X 10 ="
        txt1x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt1x10_GotFocus(sender As Object, e As EventArgs) Handles txt1x10.GotFocus
        lblEquation.Text = "1 X 10 ="
        txt1x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x1_GotFocus(sender As Object, e As EventArgs) Handles txt2x1.GotFocus
        lblEquation.Text = "2 X 1 ="
        txt2x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x2_GotFocus(sender As Object, e As EventArgs) Handles txt2x2.GotFocus
        lblEquation.Text = "2 X 2 ="
        txt2x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x3_GotFocus(sender As Object, e As EventArgs) Handles txt2x3.GotFocus
        lblEquation.Text = "2 X 3 ="
        txt2x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x4_GotFocus(sender As Object, e As EventArgs) Handles txt2x4.GotFocus
        lblEquation.Text = "2 X 4 ="
        txt2x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x5_GotFocus(sender As Object, e As EventArgs) Handles txt2x5.GotFocus
        lblEquation.Text = "2 X 5 ="
        txt2x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x6_GotFocus(sender As Object, e As EventArgs) Handles txt2x6.GotFocus
        lblEquation.Text = "2 X 6 ="
        txt2x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x7_GotFocus(sender As Object, e As EventArgs) Handles txt2x7.GotFocus
        lblEquation.Text = "2 X 7 ="
        txt2x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x8_GotFocus(sender As Object, e As EventArgs) Handles txt2x8.GotFocus
        lblEquation.Text = "2 X 8 ="
        txt2x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x9_GotFocus(sender As Object, e As EventArgs) Handles txt2x9.GotFocus
        lblEquation.Text = "2 X 9 ="
        txt2x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt2x10_GotFocus(sender As Object, e As EventArgs) Handles txt2x10.GotFocus
        lblEquation.Text = "2 X 10 ="
        txt2x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
 
    Private Sub txt0x1_TextChanged(sender As Object, e As EventArgs) Handles txt0x1.TextChanged
        strAnswer = "0"
        strInput = txt0x1.Text
        lblInput.Text = txt0x1.Text

        CheckAnswer(strInput, strAnswer, txt0x1)
    End Sub

    Private Sub txt0x2_TextChanged(sender As Object, e As EventArgs) Handles txt0x2.TextChanged
        strAnswer = "0"
        strInput = txt0x2.Text
        lblInput.Text = txt0x2.Text

        CheckAnswer(strInput, strAnswer, txt0x2)
    End Sub

    Private Sub txt0x3_TextChanged(sender As Object, e As EventArgs) Handles txt0x3.TextChanged
        strAnswer = "0"
        strInput = txt0x3.Text
        lblInput.Text = txt0x3.Text

        CheckAnswer(strInput, strAnswer, txt0x3)
    End Sub


    Private Sub txt0x4_TextChanged(sender As Object, e As EventArgs) Handles txt0x4.TextChanged
        strAnswer = "0"
        strInput = txt0x4.Text
        lblInput.Text = txt0x4.Text

        CheckAnswer(strInput, strAnswer, txt0x4)
    End Sub


    Private Sub txt0x5_TextChanged(sender As Object, e As EventArgs) Handles txt0x5.TextChanged
        strAnswer = "0"
        strInput = txt0x5.Text
        lblInput.Text = txt0x5.Text

        CheckAnswer(strInput, strAnswer, txt0x5)
    End Sub


    Private Sub txt0x6_TextChanged(sender As Object, e As EventArgs) Handles txt0x6.TextChanged
        strAnswer = "0"
        strInput = txt0x6.Text
        lblInput.Text = txt0x6.Text

        CheckAnswer(strInput, strAnswer, txt0x6)
    End Sub


    Private Sub txt0x7_TextChanged(sender As Object, e As EventArgs) Handles txt0x7.TextChanged
        strAnswer = "0"
        strInput = txt0x7.Text
        lblInput.Text = txt0x7.Text

        CheckAnswer(strInput, strAnswer, txt0x7)
    End Sub


    Private Sub txt0x8_TextChanged(sender As Object, e As EventArgs) Handles txt0x8.TextChanged
        strAnswer = "0"
        strInput = txt0x8.Text
        lblInput.Text = txt0x8.Text

        CheckAnswer(strInput, strAnswer, txt0x8)
    End Sub


    Private Sub txt0x9_TextChanged(sender As Object, e As EventArgs) Handles txt0x9.TextChanged
        strAnswer = "0"
        strInput = txt0x9.Text
        lblInput.Text = txt0x9.Text

        CheckAnswer(strInput, strAnswer, txt0x9)
    End Sub


    Private Sub txt0x10_TextChanged(sender As Object, e As EventArgs) Handles txt0x10.TextChanged
        strAnswer = "0"
        strInput = txt0x10.Text
        lblInput.Text = txt0x10.Text

        CheckAnswer(strInput, strAnswer, txt0x10)
    End Sub


    Private Sub txt1x2_TextChanged(sender As Object, e As EventArgs) Handles txt1x2.TextChanged

    End Sub

    Private Sub txt1x5_TextChanged(sender As Object, e As EventArgs) Handles txt1x5.TextChanged

    End Sub
End Class
