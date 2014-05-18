Imports System
Imports System.String
Imports System.Text.RegularExpressions
Imports System.ConsoleKey

Public Class frmTimeTable
    Dim strInput As String
    Dim strAnswer As String
    Dim intTotalRight As Integer

    ' checks the user input against the right answer
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

    ' for pressing the enter key in a textbox
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    Private Sub txt0x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x0.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt0x0.SelectionAlignment = HorizontalAlignment.Center
            lblEquation.Text = "0 X 0 =  "
            strAnswer = "0"
            strInput = txt0x0.Text
            lblInput.Text = txt0x0.Text

            CheckAnswer(strInput, strAnswer, txt0x0)
        End If
    End Sub


    'Private Sub txt0x0_TextChanged(sender As Object, e As EventArgs) Handles txt0x0.TextChanged


    '    txt0x0.SelectionAlignment = HorizontalAlignment.Center
    '    lblEquation.Text = "0 X 0 =  "
    '    strAnswer = "0"
    '    strInput = txt0x0.Text
    '    lblInput.Text = txt0x0.Text

    '    CheckAnswer(strInput, strAnswer, txt0x0)

    'End Sub

    

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
    Private Sub txt2x0_GotFocus(sender As Object, e As EventArgs) Handles txt2x0.GotFocus
        lblEquation.Text = "2 X 0 ="
        txt2x0.SelectionAlignment = HorizontalAlignment.Center
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
        txt2x3.SelectionAlignment = HorizontalAlignment.Center
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
    Private Sub txt3x0_GotFocus(sender As Object, e As EventArgs) Handles txt3x0.GotFocus
        lblEquation.Text = "3 X 0 ="
        txt3x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x1_GotFocus(sender As Object, e As EventArgs) Handles txt3x1.GotFocus
        lblEquation.Text = "3 X 1 ="
        txt3x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x2_GotFocus(sender As Object, e As EventArgs) Handles txt3x2.GotFocus
        lblEquation.Text = "3 X 2 ="
        txt3x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x3_GotFocus(sender As Object, e As EventArgs) Handles txt3x3.GotFocus
        lblEquation.Text = "3 X 3 ="
        txt3x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x4_GotFocus(sender As Object, e As EventArgs) Handles txt3x4.GotFocus
        lblEquation.Text = "3 X 4 ="
        txt3x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x5_GotFocus(sender As Object, e As EventArgs) Handles txt3x5.GotFocus
        lblEquation.Text = "3 X 5 ="
        txt3x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x6_GotFocus(sender As Object, e As EventArgs) Handles txt3x6.GotFocus
        lblEquation.Text = "3 X 6 ="
        txt3x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x7_GotFocus(sender As Object, e As EventArgs) Handles txt3x7.GotFocus
        lblEquation.Text = "3 X 7 ="
        txt3x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x8_GotFocus(sender As Object, e As EventArgs) Handles txt3x8.GotFocus
        lblEquation.Text = "3 X 8 ="
        txt3x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x9_GotFocus(sender As Object, e As EventArgs) Handles txt3x9.GotFocus
        lblEquation.Text = "3 X 9 ="
        txt3x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt3x10_GotFocus(sender As Object, e As EventArgs) Handles txt3x10.GotFocus
        lblEquation.Text = "3 X 10 ="
        txt3x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    'takes input and calls the CheckAnswer function

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

    Private Sub txt1x0_TextChanged(sender As Object, e As EventArgs) Handles txt1x0.TextChanged
        strAnswer = "0"
        strInput = txt1x0.Text
        lblInput.Text = txt1x0.Text

        CheckAnswer(strInput, strAnswer, txt1x0)
    End Sub
    Private Sub txt1x1_TextChanged(sender As Object, e As EventArgs) Handles txt1x1.TextChanged
        strAnswer = "1"
        strInput = txt1x1.Text
        lblInput.Text = txt1x1.Text

        CheckAnswer(strInput, strAnswer, txt1x1)
    End Sub
    Private Sub txt1x2_TextChanged(sender As Object, e As EventArgs) Handles txt1x2.TextChanged
        strAnswer = "2"
        strInput = txt1x2.Text
        lblInput.Text = txt1x2.Text

        CheckAnswer(strInput, strAnswer, txt1x2)
    End Sub
    Private Sub txt1x3_TextChanged(sender As Object, e As EventArgs) Handles txt1x3.TextChanged
        strAnswer = "3"
        strInput = txt1x3.Text
        lblInput.Text = txt1x3.Text

        CheckAnswer(strInput, strAnswer, txt1x3)
    End Sub
    Private Sub txt1x4_TextChanged(sender As Object, e As EventArgs) Handles txt1x4.TextChanged
        strAnswer = "4"
        strInput = txt1x4.Text
        lblInput.Text = txt1x4.Text

        CheckAnswer(strInput, strAnswer, txt1x4)
    End Sub
    Private Sub txt1x5_TextChanged(sender As Object, e As EventArgs) Handles txt1x5.TextChanged
        strAnswer = "5"
        strInput = txt1x5.Text
        lblInput.Text = txt1x5.Text

        CheckAnswer(strInput, strAnswer, txt1x5)
    End Sub
    Private Sub txt1x6_TextChanged(sender As Object, e As EventArgs) Handles txt1x6.TextChanged
        strAnswer = "6"
        strInput = txt1x6.Text
        lblInput.Text = txt1x6.Text

        CheckAnswer(strInput, strAnswer, txt1x6)
    End Sub
    Private Sub txt1x7_TextChanged(sender As Object, e As EventArgs) Handles txt1x7.TextChanged
        strAnswer = "7"
        strInput = txt1x7.Text
        lblInput.Text = txt1x7.Text

        CheckAnswer(strInput, strAnswer, txt1x7)
    End Sub
    Private Sub txt1x8_TextChanged(sender As Object, e As EventArgs) Handles txt1x8.TextChanged
        strAnswer = "8"
        strInput = txt1x8.Text
        lblInput.Text = txt1x8.Text

        CheckAnswer(strInput, strAnswer, txt1x8)
    End Sub
    Private Sub txt1x9_TextChanged(sender As Object, e As EventArgs) Handles txt1x9.TextChanged
        strAnswer = "9"
        strInput = txt1x9.Text
        lblInput.Text = txt1x9.Text

        CheckAnswer(strInput, strAnswer, txt1x9)
    End Sub
    Private Sub txt1x10_TextChanged(sender As Object, e As EventArgs) Handles txt1x10.TextChanged
        strAnswer = "10"
        strInput = txt1x10.Text
        lblInput.Text = txt1x10.Text

        CheckAnswer(strInput, strAnswer, txt1x10)
    End Sub

    Private Sub txt2x0_TextChanged(sender As Object, e As EventArgs) Handles txt2x0.TextChanged
        strAnswer = "0"
        strInput = txt2x0.Text
        lblInput.Text = txt2x0.Text

        CheckAnswer(strInput, strAnswer, txt2x0)
    End Sub
    Private Sub txt2x1_TextChanged(sender As Object, e As EventArgs) Handles txt2x1.TextChanged
        strAnswer = "2"
        strInput = txt2x1.Text
        lblInput.Text = txt2x1.Text

        CheckAnswer(strInput, strAnswer, txt2x1)
    End Sub
    Private Sub txt2x2_TextChanged(sender As Object, e As EventArgs) Handles txt2x2.TextChanged
        strAnswer = "4"
        strInput = txt2x2.Text
        lblInput.Text = txt2x2.Text

        CheckAnswer(strInput, strAnswer, txt2x2)
    End Sub
    Private Sub txt2x3_TextChanged(sender As Object, e As EventArgs) Handles txt2x3.TextChanged
        strAnswer = "6"
        strInput = txt2x3.Text
        lblInput.Text = txt2x3.Text

        CheckAnswer(strInput, strAnswer, txt2x3)
    End Sub
    Private Sub txt2x4_TextChanged(sender As Object, e As EventArgs) Handles txt2x4.TextChanged
        strAnswer = "8"
        strInput = txt2x4.Text
        lblInput.Text = txt2x4.Text

        CheckAnswer(strInput, strAnswer, txt2x4)
    End Sub
    Private Sub txt2x5_TextChanged(sender As Object, e As EventArgs) Handles txt2x5.TextChanged
        strAnswer = "10"
        strInput = txt2x5.Text
        lblInput.Text = txt2x5.Text

        CheckAnswer(strInput, strAnswer, txt2x5)
    End Sub
    Private Sub txt2x6_TextChanged(sender As Object, e As EventArgs) Handles txt2x6.TextChanged
        strAnswer = "12"
        strInput = txt2x6.Text
        lblInput.Text = txt2x6.Text

        CheckAnswer(strInput, strAnswer, txt2x6)
    End Sub
    Private Sub txt2x7_TextChanged(sender As Object, e As EventArgs) Handles txt2x7.TextChanged
        strAnswer = "14"
        strInput = txt2x7.Text
        lblInput.Text = txt2x7.Text

        CheckAnswer(strInput, strAnswer, txt2x7)
    End Sub
    Private Sub txt2x8_TextChanged(sender As Object, e As EventArgs) Handles txt2x8.TextChanged
        strAnswer = "16"
        strInput = txt2x8.Text
        lblInput.Text = txt2x8.Text

        CheckAnswer(strInput, strAnswer, txt2x8)
    End Sub
    Private Sub txt2x9_TextChanged(sender As Object, e As EventArgs) Handles txt2x9.TextChanged
        strAnswer = "18"
        strInput = txt2x9.Text
        lblInput.Text = txt2x9.Text

        CheckAnswer(strInput, strAnswer, txt2x9)
    End Sub
    Private Sub txt2x10_TextChanged(sender As Object, e As EventArgs) Handles txt2x10.TextChanged
        strAnswer = "20"
        strInput = txt2x10.Text
        lblInput.Text = txt2x10.Text

        CheckAnswer(strInput, strAnswer, txt2x10)
    End Sub
    Private Sub txt3x0_TextChanged(sender As Object, e As EventArgs) Handles txt3x0.TextChanged
        strAnswer = "0"
        strInput = txt3x0.Text
        lblInput.Text = txt3x0.Text

        CheckAnswer(strInput, strAnswer, txt3x0)
    End Sub
    Private Sub txt3x1_TextChanged(sender As Object, e As EventArgs) Handles txt3x1.TextChanged
        strAnswer = "3"
        strInput = txt3x1.Text
        lblInput.Text = txt3x1.Text

        CheckAnswer(strInput, strAnswer, txt3x1)
    End Sub
    Private Sub txt3x2_TextChanged(sender As Object, e As EventArgs) Handles txt3x2.TextChanged
        strAnswer = "6"
        strInput = txt3x2.Text
        lblInput.Text = txt3x2.Text

        CheckAnswer(strInput, strAnswer, txt3x2)
    End Sub
    Private Sub txt3x3_TextChanged(sender As Object, e As EventArgs) Handles txt3x3.TextChanged
        strAnswer = "9"
        strInput = txt3x3.Text
        lblInput.Text = txt3x3.Text

        CheckAnswer(strInput, strAnswer, txt3x3)
    End Sub
    Private Sub txt3x4_TextChanged(sender As Object, e As EventArgs) Handles txt3x4.TextChanged
        strAnswer = "12"
        strInput = txt3x4.Text
        lblInput.Text = txt3x4.Text

        CheckAnswer(strInput, strAnswer, txt3x4)
    End Sub
    Private Sub txt3x5_TextChanged(sender As Object, e As EventArgs) Handles txt3x5.TextChanged
        strAnswer = "15"
        strInput = txt3x5.Text
        lblInput.Text = txt3x5.Text

        CheckAnswer(strInput, strAnswer, txt3x5)
    End Sub
    Private Sub txt3x6_TextChanged(sender As Object, e As EventArgs) Handles txt3x6.TextChanged
        strAnswer = "18"
        strInput = txt3x6.Text
        lblInput.Text = txt3x6.Text

        CheckAnswer(strInput, strAnswer, txt3x6)
    End Sub
    Private Sub txt3x7_TextChanged(sender As Object, e As EventArgs) Handles txt3x7.TextChanged
        strAnswer = "21"
        strInput = txt3x7.Text
        lblInput.Text = txt3x7.Text

        CheckAnswer(strInput, strAnswer, txt3x7)
    End Sub
    Private Sub txt3x8_TextChanged(sender As Object, e As EventArgs) Handles txt3x8.TextChanged
        strAnswer = "24"
        strInput = txt3x8.Text
        lblInput.Text = txt3x8.Text

        CheckAnswer(strInput, strAnswer, txt3x8)
    End Sub
    Private Sub txt3x9_TextChanged(sender As Object, e As EventArgs) Handles txt3x9.TextChanged
        strAnswer = "27"
        strInput = txt3x9.Text
        lblInput.Text = txt3x9.Text

        CheckAnswer(strInput, strAnswer, txt3x9)
    End Sub
    Private Sub txt3x10_TextChanged(sender As Object, e As EventArgs) Handles txt3x10.TextChanged
        strAnswer = "30"
        strInput = txt3x10.Text
        lblInput.Text = txt3x10.Text

        CheckAnswer(strInput, strAnswer, txt3x10)
    End Sub
End Class
