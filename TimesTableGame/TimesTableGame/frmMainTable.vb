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


    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Enter key inputs 
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ' SendKeys.Send("{TAB}")
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Then
            e.Handled = False
        End If

        'Allows only numberic input
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
   
    ' To clear all textboxes
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        'to change answer label as user types

        For Each c As Control In Me.Controls

            If TypeOf c Is RichTextBox Then

                DirectCast(c, RichTextBox).Text = ""
                c.Enabled = True
                intTotalRight = 0
                lblTotalRight.Text = 0
                c.BackColor = Color.White
                lblEquation.Text = "Ready?"
                lblInput.Text = ""
            End If
        Next
    End Sub

    'TODO: Show Answer button
    'TODO:  See if I can get tab key to act as input without setting multiline to 'true'
    'TODO: Allow different difficulty levels

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        'checks which text box cursor is in
        'fetches answer 
        'displays answer
        'resets when player leaves textbox
    End Sub





    Private Sub txt0x0_GotFocus(sender As Object, e As EventArgs) Handles txt0x0.GotFocus
        lblInput.Text = txt0x0.Text
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
    Private Sub txt4x0_GotFocus(sender As Object, e As EventArgs) Handles txt4x0.GotFocus
        lblEquation.Text = "4 X 0 ="
        txt4x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x1_GotFocus(sender As Object, e As EventArgs) Handles txt4x1.GotFocus
        lblEquation.Text = "4 X 1 ="
        txt4x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x2_GotFocus(sender As Object, e As EventArgs) Handles txt4x2.GotFocus
        lblEquation.Text = "4 X 2 ="
        txt4x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x3_GotFocus(sender As Object, e As EventArgs) Handles txt4x3.GotFocus
        lblEquation.Text = "4 X 3 ="
        txt4x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x4_GotFocus(sender As Object, e As EventArgs) Handles txt4x4.GotFocus
        lblEquation.Text = "4 X 4 ="
        txt4x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x5_GotFocus(sender As Object, e As EventArgs) Handles txt4x5.GotFocus
        lblEquation.Text = "4 X 5 ="
        txt4x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x6_GotFocus(sender As Object, e As EventArgs) Handles txt4x6.GotFocus
        lblEquation.Text = "4 X 6 ="
        txt4x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x7_GotFocus(sender As Object, e As EventArgs) Handles txt4x7.GotFocus
        lblEquation.Text = "4 X 7 ="
        txt4x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x8_GotFocus(sender As Object, e As EventArgs) Handles txt4x8.GotFocus
        lblEquation.Text = "4 X 8 ="
        txt4x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt4x9_GotFocus(sender As Object, e As EventArgs) Handles txt4x9.GotFocus
        lblEquation.Text = "4 X 9 ="
        txt4x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x0_GotFocus(sender As Object, e As EventArgs) Handles txt5x0.GotFocus
        lblEquation.Text = "5 X 0 ="
        txt5x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x1_GotFocus(sender As Object, e As EventArgs) Handles txt5x1.GotFocus
        lblEquation.Text = "5 X 1 ="
        txt5x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x2_GotFocus(sender As Object, e As EventArgs) Handles txt5x2.GotFocus
        lblEquation.Text = "5 X 2 ="
        txt5x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x3_GotFocus(sender As Object, e As EventArgs) Handles txt5x3.GotFocus
        lblEquation.Text = "5 X 3 ="
        txt5x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x4_GotFocus(sender As Object, e As EventArgs) Handles txt5x4.GotFocus
        lblEquation.Text = "5 X 4 ="
        txt5x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x5_GotFocus(sender As Object, e As EventArgs) Handles txt5x5.GotFocus
        lblEquation.Text = "5 X 5 ="
        txt5x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x6_GotFocus(sender As Object, e As EventArgs) Handles txt5x6.GotFocus
        lblEquation.Text = "5 X 6 ="
        txt5x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x7_GotFocus(sender As Object, e As EventArgs) Handles txt5x7.GotFocus
        lblEquation.Text = "5 X 7 ="
        txt5x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x8_GotFocus(sender As Object, e As EventArgs) Handles txt5x8.GotFocus
        lblEquation.Text = "5 X 8 ="
        txt5x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x9_GotFocus(sender As Object, e As EventArgs) Handles txt5x9.GotFocus
        lblEquation.Text = "5 X 9 ="
        txt5x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt5x10_GotFocus(sender As Object, e As EventArgs) Handles txt5x10.GotFocus
        lblEquation.Text = "5 X 10 ="
        txt5x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
   
    Private Sub txt6x0_GotFocus(sender As Object, e As EventArgs) Handles txt6x0.GotFocus
        lblEquation.Text = "6 X 0 ="
        txt6x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x1_GotFocus(sender As Object, e As EventArgs) Handles txt6x1.GotFocus
        lblEquation.Text = "6 X 1 ="
        txt6x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x2_GotFocus(sender As Object, e As EventArgs) Handles txt6x2.GotFocus
        lblEquation.Text = "6 X 2 ="
        txt6x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x3_GotFocus(sender As Object, e As EventArgs) Handles txt6x3.GotFocus
        lblEquation.Text = "6 X 3 ="
        txt6x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x4_GotFocus(sender As Object, e As EventArgs) Handles txt6x4.GotFocus
        lblEquation.Text = "6 X 4 ="
        txt6x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x5_GotFocus(sender As Object, e As EventArgs) Handles txt6x5.GotFocus
        lblEquation.Text = "6 X 5 ="
        txt6x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x6_GotFocus(sender As Object, e As EventArgs) Handles txt6x6.GotFocus
        lblEquation.Text = "6 X 6 ="
        txt6x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x7_GotFocus(sender As Object, e As EventArgs) Handles txt6x7.GotFocus
        lblEquation.Text = "6 X 7 ="
        txt6x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x8_GotFocus(sender As Object, e As EventArgs) Handles txt6x8.GotFocus
        lblEquation.Text = "6 X 8 ="
        txt6x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x9_GotFocus(sender As Object, e As EventArgs) Handles txt6x9.GotFocus
        lblEquation.Text = "6 X 9 ="
        txt6x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt6x10_GotFocus(sender As Object, e As EventArgs) Handles txt6x10.GotFocus
        lblEquation.Text = "6 X 10 ="
        txt6x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x0_GotFocus(sender As Object, e As EventArgs) Handles txt7x0.GotFocus
        lblEquation.Text = "7 X 0 ="
        txt7x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x1_GotFocus(sender As Object, e As EventArgs) Handles txt7x1.GotFocus
        lblEquation.Text = "7 X 1 ="
        txt7x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x2_GotFocus(sender As Object, e As EventArgs) Handles txt7x2.GotFocus
        lblEquation.Text = "7 X 2 ="
        txt7x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x3_GotFocus(sender As Object, e As EventArgs) Handles txt7x3.GotFocus
        lblEquation.Text = "7 X 3 ="
        txt7x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x4_GotFocus(sender As Object, e As EventArgs) Handles txt7x4.GotFocus
        lblEquation.Text = "7 X 4 ="
        txt7x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x5_GotFocus(sender As Object, e As EventArgs) Handles txt7x5.GotFocus
        lblEquation.Text = "7 X 5 ="
        txt7x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x6_GotFocus(sender As Object, e As EventArgs) Handles txt7x6.GotFocus
        lblEquation.Text = "7 X 6 ="
        txt7x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x7_GotFocus(sender As Object, e As EventArgs) Handles txt7x7.GotFocus
        lblEquation.Text = "7 X 7 ="
        txt7x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x8_GotFocus(sender As Object, e As EventArgs) Handles txt7x8.GotFocus
        lblEquation.Text = "7 X 8 ="
        txt7x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x9_GotFocus(sender As Object, e As EventArgs) Handles txt7x9.GotFocus
        lblEquation.Text = "7 X 9 ="
        txt7x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt7x10_GotFocus(sender As Object, e As EventArgs) Handles txt7x10.GotFocus
        lblEquation.Text = "7 X 10 ="
        txt7x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x0_GotFocus(sender As Object, e As EventArgs) Handles txt8x0.GotFocus
        lblEquation.Text = "8 X 0 ="
        txt8x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x1_GotFocus(sender As Object, e As EventArgs) Handles txt8x1.GotFocus
        lblEquation.Text = "8 X 1 ="
        txt8x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x2_GotFocus(sender As Object, e As EventArgs) Handles txt8x2.GotFocus
        lblEquation.Text = "8 X 2 ="
        txt8x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x3_GotFocus(sender As Object, e As EventArgs) Handles txt8x3.GotFocus
        lblEquation.Text = "8 X 3 ="
        txt8x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x4_GotFocus(sender As Object, e As EventArgs) Handles txt8x4.GotFocus
        lblEquation.Text = "8 X 4 ="
        txt8x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x5_GotFocus(sender As Object, e As EventArgs) Handles txt8x5.GotFocus
        lblEquation.Text = "8 X 5 ="
        txt8x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x6_GotFocus(sender As Object, e As EventArgs) Handles txt8x6.GotFocus
        lblEquation.Text = "8 X 6 ="
        txt8x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x7_GotFocus(sender As Object, e As EventArgs) Handles txt8x7.GotFocus
        lblEquation.Text = "8 X 7 ="
        txt8x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x8_GotFocus(sender As Object, e As EventArgs) Handles txt8x8.GotFocus
        lblEquation.Text = "8 X 8 ="
        txt8x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x9_GotFocus(sender As Object, e As EventArgs) Handles txt8x9.GotFocus
        lblEquation.Text = "8 X 9 ="
        txt8x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt8x10_GotFocus(sender As Object, e As EventArgs) Handles txt8x10.GotFocus
        lblEquation.Text = "8 X 10 ="
        txt8x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x0_GotFocus(sender As Object, e As EventArgs) Handles txt9x0.GotFocus
        lblEquation.Text = "9 X 0 ="
        txt9x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x1_GotFocus(sender As Object, e As EventArgs) Handles txt9x1.GotFocus
        lblEquation.Text = "9 X 1 ="
        txt9x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x2_GotFocus(sender As Object, e As EventArgs) Handles txt9x2.GotFocus
        lblEquation.Text = "9 X 2 ="
        txt9x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x3_GotFocus(sender As Object, e As EventArgs) Handles txt9x3.GotFocus
        lblEquation.Text = "9 X 3 ="
        txt9x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x4_GotFocus(sender As Object, e As EventArgs) Handles txt9x4.GotFocus
        lblEquation.Text = "9 X 4 ="
        txt9x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x5_GotFocus(sender As Object, e As EventArgs) Handles txt9x5.GotFocus
        lblEquation.Text = "9 X 5 ="
        txt9x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x6_GotFocus(sender As Object, e As EventArgs) Handles txt9x6.GotFocus
        lblEquation.Text = "9 X 6 ="
        txt9x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x7_GotFocus(sender As Object, e As EventArgs) Handles txt9x7.GotFocus
        lblEquation.Text = "9 X 7 ="
        txt9x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x8_GotFocus(sender As Object, e As EventArgs) Handles txt9x8.GotFocus
        lblEquation.Text = "9 X 8 ="
        txt9x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x9_GotFocus(sender As Object, e As EventArgs) Handles txt9x9.GotFocus
        lblEquation.Text = "9 X 9 ="
        txt9x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt9x10_GotFocus(sender As Object, e As EventArgs) Handles txt9x10.GotFocus
        lblEquation.Text = "9 X 10 ="
        txt9x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x0_GotFocus(sender As Object, e As EventArgs) Handles txt10x0.GotFocus
        lblEquation.Text = "10 X 0 ="
        txt10x0.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x1_GotFocus(sender As Object, e As EventArgs) Handles txt10x1.GotFocus
        lblEquation.Text = "10 X 1 ="
        txt10x1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x2_GotFocus(sender As Object, e As EventArgs) Handles txt10x2.GotFocus
        lblEquation.Text = "10 X 2 ="
        txt10x2.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x3_GotFocus(sender As Object, e As EventArgs) Handles txt10x3.GotFocus
        lblEquation.Text = "10 X 3 ="
        txt10x3.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x4_GotFocus(sender As Object, e As EventArgs) Handles txt10x4.GotFocus
        lblEquation.Text = "10 X 4 ="
        txt10x4.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x5_GotFocus(sender As Object, e As EventArgs) Handles txt10x5.GotFocus
        lblEquation.Text = "10 X 5 ="
        txt10x5.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x6_GotFocus(sender As Object, e As EventArgs) Handles txt10x6.GotFocus
        lblEquation.Text = "10 X 6 ="
        txt10x6.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x7_GotFocus(sender As Object, e As EventArgs) Handles txt10x7.GotFocus
        lblEquation.Text = "10 X 7 ="
        txt10x7.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x8_GotFocus(sender As Object, e As EventArgs) Handles txt10x8.GotFocus
        lblEquation.Text = "10 X 8 ="
        txt10x8.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x9_GotFocus(sender As Object, e As EventArgs) Handles txt10x9.GotFocus
        lblEquation.Text = "10 X 9 ="
        txt10x9.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub txt10x10_GotFocus(sender As Object, e As EventArgs) Handles txt10x10.GotFocus
        lblEquation.Text = "10 X 10 ="
        txt10x10.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    '***************************************************************************************************************************
    'takes input and calls the CheckAnswer function

    Private Sub txt0x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x0.KeyDown
        lblInput.Text = txt0x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x0.Text
            CheckAnswer(strInput, strAnswer, txt0x0)
        End If
    End Sub
    Private Sub txt0x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x1.KeyDown
        lblInput.Text = txt0x1.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x1.Text
            CheckAnswer(strInput, strAnswer, txt0x1)
        End If
    End Sub
    Private Sub txt0x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x2.KeyDown
        lblInput.Text = txt0x2.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x2.Text
            CheckAnswer(strInput, strAnswer, txt0x2)
        End If
    End Sub
    Private Sub txt0x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x3.KeyDown
        lblInput.Text = txt0x3.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x3.Text
            CheckAnswer(strInput, strAnswer, txt0x3)
        End If
    End Sub
    Private Sub txt0x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x4.KeyDown
        lblInput.Text = txt0x1.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x4.Text
            CheckAnswer(strInput, strAnswer, txt0x4)
        End If
    End Sub
    Private Sub txt0x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x5.KeyDown
        lblInput.Text = txt0x5.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x5.Text
            CheckAnswer(strInput, strAnswer, txt0x5)
        End If
    End Sub
    Private Sub txt0x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x6.KeyDown
        lblInput.Text = txt0x6.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x6.Text
            CheckAnswer(strInput, strAnswer, txt0x6)
        End If
    End Sub
    Private Sub txt0x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x7.KeyDown
        lblInput.Text = txt0x7.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x7.Text
            CheckAnswer(strInput, strAnswer, txt0x7)
        End If
    End Sub
    Private Sub txt0x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x8.KeyDown
        lblInput.Text = txt0x8.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x8.Text
            CheckAnswer(strInput, strAnswer, txt0x8)
        End If
    End Sub
    Private Sub txt0x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x9.KeyDown
        lblInput.Text = txt0x9.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x9.Text
            CheckAnswer(strInput, strAnswer, txt0x9)
        End If
    End Sub
    Private Sub txt0x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt0x10.KeyDown
        lblInput.Text = txt0x10.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt0x10.Text
            CheckAnswer(strInput, strAnswer, txt0x10)
        End If
    End Sub
    Private Sub txt1x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x0.KeyDown
        lblInput.Text = txt1x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x0.Text
            CheckAnswer(strInput, strAnswer, txt1x0)
        End If
    End Sub
    Private Sub txt1x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x1.KeyDown
        lblInput.Text = txt1x1.Text
        strAnswer = "1"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x1.Text
            CheckAnswer(strInput, strAnswer, txt1x1)
        End If
    End Sub
    Private Sub txt1x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x2.KeyDown
        lblInput.Text = txt1x2.Text
        strAnswer = "2"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x2.Text
            CheckAnswer(strInput, strAnswer, txt1x2)
        End If
    End Sub
    Private Sub txt1x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x3.KeyDown
        lblInput.Text = txt1x3.Text
        strAnswer = "3"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x3.Text
            CheckAnswer(strInput, strAnswer, txt1x3)
        End If
    End Sub
    Private Sub txt1x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x4.KeyDown
        lblInput.Text = txt1x4.Text
        strAnswer = "4"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x4.Text
            CheckAnswer(strInput, strAnswer, txt1x4)
        End If
    End Sub
    Private Sub txt1x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x5.KeyDown
        lblInput.Text = txt1x5.Text
        strAnswer = "5"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x5.Text
            CheckAnswer(strInput, strAnswer, txt1x5)
        End If
    End Sub
    Private Sub txt1x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x6.KeyDown
        lblInput.Text = txt1x6.Text
        strAnswer = "6"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x6.Text
            CheckAnswer(strInput, strAnswer, txt1x6)
        End If
    End Sub
    Private Sub txt1x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x7.KeyDown
        lblInput.Text = txt1x7.Text
        strAnswer = "7"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x7.Text
            CheckAnswer(strInput, strAnswer, txt1x7)
        End If
    End Sub
    Private Sub txt1x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x8.KeyDown
        lblInput.Text = txt1x8.Text
        strAnswer = "8"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x8.Text
            CheckAnswer(strInput, strAnswer, txt1x8)
        End If
    End Sub
    Private Sub txt1x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x9.KeyDown
        lblInput.Text = txt1x9.Text
        strAnswer = "9"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x9.Text
            CheckAnswer(strInput, strAnswer, txt1x9)
        End If
    End Sub
    Private Sub txt1x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1x10.KeyDown
        lblInput.Text = txt1x10.Text
        strAnswer = "10"
        If e.KeyCode = Keys.Enter Then
            strInput = txt1x10.Text
            CheckAnswer(strInput, strAnswer, txt1x10)
        End If
    End Sub
    Private Sub txt2x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x0.KeyDown
        lblInput.Text = txt2x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x0.Text
            CheckAnswer(strInput, strAnswer, txt2x0)
        End If
    End Sub
    Private Sub txt2x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x1.KeyDown
        lblInput.Text = txt2x1.Text
        strAnswer = "2"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x1.Text
            CheckAnswer(strInput, strAnswer, txt2x1)
        End If
    End Sub
    Private Sub txt2x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x2.KeyDown
        lblInput.Text = txt2x2.Text
        strAnswer = "4"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x2.Text
            CheckAnswer(strInput, strAnswer, txt2x2)
        End If
    End Sub
    Private Sub txt2x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x3.KeyDown
        lblInput.Text = txt2x3.Text
        strAnswer = "6"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x3.Text
            CheckAnswer(strInput, strAnswer, txt2x3)
        End If
    End Sub
    Private Sub txt2x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x4.KeyDown
        lblInput.Text = txt2x4.Text
        strAnswer = "8"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x4.Text
            CheckAnswer(strInput, strAnswer, txt2x4)
        End If
    End Sub
    Private Sub txt2x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x5.KeyDown
        lblInput.Text = txt2x5.Text
        strAnswer = "10"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x5.Text
            CheckAnswer(strInput, strAnswer, txt2x5)
        End If
    End Sub
    Private Sub txt2x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x6.KeyDown
        lblInput.Text = txt2x6.Text
        strAnswer = "12"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x6.Text
            CheckAnswer(strInput, strAnswer, txt2x6)
        End If
    End Sub
    Private Sub txt2x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x7.KeyDown
        lblInput.Text = txt2x7.Text
        strAnswer = "14"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x7.Text
            CheckAnswer(strInput, strAnswer, txt2x7)
        End If
    End Sub
    Private Sub txt2x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x8.KeyDown
        lblInput.Text = txt2x8.Text
        strAnswer = "16"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x8.Text
            CheckAnswer(strInput, strAnswer, txt2x8)
        End If
    End Sub
    Private Sub txt2x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x9.KeyDown
        lblInput.Text = txt2x9.Text
        strAnswer = "18"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x9.Text
            CheckAnswer(strInput, strAnswer, txt2x9)
        End If
    End Sub
    Private Sub txt2x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt2x10.KeyDown
        lblInput.Text = txt2x10.Text
        strAnswer = "20"
        If e.KeyCode = Keys.Enter Then
            strInput = txt2x10.Text
            CheckAnswer(strInput, strAnswer, txt2x10)
        End If
    End Sub
    Private Sub txt3x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x0.KeyDown
        lblInput.Text = txt3x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x0.Text
            CheckAnswer(strInput, strAnswer, txt3x0)
        End If
    End Sub
    Private Sub txt3x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x1.KeyDown
        lblInput.Text = txt3x1.Text
        strAnswer = "3"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x1.Text
            CheckAnswer(strInput, strAnswer, txt3x1)
        End If
    End Sub
    Private Sub txt3x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x2.KeyDown
        lblInput.Text = txt3x2.Text
        strAnswer = "6"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x2.Text
            CheckAnswer(strInput, strAnswer, txt3x2)
        End If
    End Sub
    Private Sub txt3x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x3.KeyDown
        lblInput.Text = txt3x3.Text
        strAnswer = "9"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x3.Text
            CheckAnswer(strInput, strAnswer, txt3x3)
        End If
    End Sub
    Private Sub txt3x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x4.KeyDown
        lblInput.Text = txt3x4.Text
        strAnswer = "12"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x4.Text
            CheckAnswer(strInput, strAnswer, txt3x4)
        End If
    End Sub
    Private Sub txt3x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x5.KeyDown
        lblInput.Text = txt3x5.Text
        strAnswer = "15"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x5.Text
            CheckAnswer(strInput, strAnswer, txt3x5)
        End If
    End Sub
    Private Sub txt3x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x6.KeyDown
        lblInput.Text = txt3x6.Text
        strAnswer = "18"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x6.Text
            CheckAnswer(strInput, strAnswer, txt3x6)
        End If
    End Sub
    Private Sub txt3x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x7.KeyDown
        lblInput.Text = txt3x7.Text
        strAnswer = "21"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x7.Text
            CheckAnswer(strInput, strAnswer, txt3x7)
        End If
    End Sub
    Private Sub txt3x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x8.KeyDown
        lblInput.Text = txt3x8.Text
        strAnswer = "24"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x8.Text
            CheckAnswer(strInput, strAnswer, txt3x8)
        End If
    End Sub
    Private Sub txt3x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x9.KeyDown
        lblInput.Text = txt3x9.Text
        strAnswer = "27"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x9.Text
            CheckAnswer(strInput, strAnswer, txt3x9)
        End If
    End Sub
    Private Sub txt3x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt3x10.KeyDown
        lblInput.Text = txt3x10.Text
        strAnswer = "30"
        If e.KeyCode = Keys.Enter Then
            strInput = txt3x10.Text
            CheckAnswer(strInput, strAnswer, txt3x10)
        End If
    End Sub
    Private Sub txt4x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x0.KeyDown
        lblInput.Text = txt4x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x0.Text
            CheckAnswer(strInput, strAnswer, txt4x0)
        End If
    End Sub
    Private Sub txt4x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x1.KeyDown
        lblInput.Text = txt4x1.Text
        strAnswer = "4"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x1.Text
            CheckAnswer(strInput, strAnswer, txt4x1)
        End If
    End Sub
    Private Sub txt4x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x2.KeyDown
        lblInput.Text = txt4x2.Text
        strAnswer = "8"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x2.Text
            CheckAnswer(strInput, strAnswer, txt4x2)
        End If
    End Sub
    Private Sub txt4x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x3.KeyDown
        lblInput.Text = txt4x3.Text
        strAnswer = "12"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x3.Text
            CheckAnswer(strInput, strAnswer, txt4x3)
        End If
    End Sub
    Private Sub txt4x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x4.KeyDown
        lblInput.Text = txt4x4.Text
        strAnswer = "16"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x4.Text
            CheckAnswer(strInput, strAnswer, txt4x4)
        End If
    End Sub
    Private Sub txt4x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x5.KeyDown
        lblInput.Text = txt4x5.Text
        strAnswer = "20"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x5.Text
            CheckAnswer(strInput, strAnswer, txt4x5)
        End If
    End Sub
    Private Sub txt4x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x6.KeyDown
        lblInput.Text = txt4x6.Text
        strAnswer = "24"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x6.Text
            CheckAnswer(strInput, strAnswer, txt4x6)
        End If
    End Sub
    Private Sub txt4x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x7.KeyDown
        lblInput.Text = txt4x7.Text
        strAnswer = "28"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x7.Text
            CheckAnswer(strInput, strAnswer, txt4x7)
        End If
    End Sub
    Private Sub txt4x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x8.KeyDown
        lblInput.Text = txt4x8.Text
        strAnswer = "32"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x8.Text
            CheckAnswer(strInput, strAnswer, txt4x8)
        End If
    End Sub
    Private Sub txt4x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x9.KeyDown
        lblInput.Text = txt4x9.Text
        strAnswer = "36"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x9.Text
            CheckAnswer(strInput, strAnswer, txt4x9)
        End If
    End Sub
    Private Sub txt4x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt4x10.KeyDown
        lblInput.Text = txt4x10.Text
        strAnswer = "40"
        If e.KeyCode = Keys.Enter Then
            strInput = txt4x10.Text
            CheckAnswer(strInput, strAnswer, txt4x10)
        End If
    End Sub
    Private Sub txt5x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x0.KeyDown
        lblInput.Text = txt5x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x0.Text
            CheckAnswer(strInput, strAnswer, txt5x0)
        End If
    End Sub
    Private Sub txt5x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x1.KeyDown
        lblInput.Text = txt5x1.Text
        strAnswer = "5"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x1.Text
            CheckAnswer(strInput, strAnswer, txt5x1)
        End If
    End Sub
    Private Sub txt5x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x2.KeyDown
        lblInput.Text = txt5x2.Text
        strAnswer = "10"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x2.Text
            CheckAnswer(strInput, strAnswer, txt5x2)
        End If
    End Sub
    Private Sub txt5x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x3.KeyDown
        lblInput.Text = txt5x3.Text
        strAnswer = "15"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x3.Text
            CheckAnswer(strInput, strAnswer, txt5x3)
        End If
    End Sub
    Private Sub txt5x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x4.KeyDown
        lblInput.Text = txt5x4.Text
        strAnswer = "20"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x4.Text
            CheckAnswer(strInput, strAnswer, txt5x4)
        End If
    End Sub
    Private Sub txt5x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x5.KeyDown
        lblInput.Text = txt5x5.Text
        strAnswer = "25"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x5.Text
            CheckAnswer(strInput, strAnswer, txt5x5)
        End If
    End Sub
    Private Sub txt5x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x6.KeyDown
        lblInput.Text = txt5x6.Text
        strAnswer = "30"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x6.Text
            CheckAnswer(strInput, strAnswer, txt5x6)
        End If
    End Sub
    Private Sub txt5x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x7.KeyDown
        lblInput.Text = txt5x7.Text
        strAnswer = "35"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x7.Text
            CheckAnswer(strInput, strAnswer, txt5x7)
        End If
    End Sub
    Private Sub txt5x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x8.KeyDown
        lblInput.Text = txt5x8.Text
        strAnswer = "40"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x8.Text
            CheckAnswer(strInput, strAnswer, txt5x8)
        End If
    End Sub
    Private Sub txt5x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x9.KeyDown
        lblInput.Text = txt5x9.Text
        strAnswer = "45"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x9.Text
            CheckAnswer(strInput, strAnswer, txt5x9)
        End If
    End Sub
    Private Sub txt5x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt5x10.KeyDown
        lblInput.Text = txt5x10.Text
        strAnswer = "50"
        If e.KeyCode = Keys.Enter Then
            strInput = txt5x10.Text
            CheckAnswer(strInput, strAnswer, txt5x10)
        End If
    End Sub
    Private Sub txt6x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x0.KeyDown
        lblInput.Text = txt6x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x0.Text
            CheckAnswer(strInput, strAnswer, txt6x0)
        End If
    End Sub
    Private Sub txt6x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x1.KeyDown
        lblInput.Text = txt6x1.Text
        strAnswer = "6"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x1.Text
            CheckAnswer(strInput, strAnswer, txt6x1)
        End If
    End Sub
    Private Sub txt6x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x2.KeyDown
        lblInput.Text = txt6x2.Text
        strAnswer = "12"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x2.Text
            CheckAnswer(strInput, strAnswer, txt6x2)
        End If
    End Sub
    Private Sub txt6x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x3.KeyDown
        lblInput.Text = txt6x3.Text
        strAnswer = "18"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x3.Text
            CheckAnswer(strInput, strAnswer, txt6x3)
        End If
    End Sub
    Private Sub txt6x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x4.KeyDown
        lblInput.Text = txt6x4.Text
        strAnswer = "24"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x4.Text
            CheckAnswer(strInput, strAnswer, txt6x4)
        End If
    End Sub
    Private Sub txt6x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x5.KeyDown
        lblInput.Text = txt6x5.Text
        strAnswer = "30"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x5.Text
            CheckAnswer(strInput, strAnswer, txt6x5)
        End If
    End Sub
    Private Sub txt6x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x6.KeyDown
        lblInput.Text = txt6x6.Text
        strAnswer = "36"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x6.Text
            CheckAnswer(strInput, strAnswer, txt6x6)
        End If
    End Sub
    Private Sub txt6x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x7.KeyDown
        lblInput.Text = txt6x7.Text
        strAnswer = "42"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x7.Text
            CheckAnswer(strInput, strAnswer, txt6x7)
        End If
    End Sub
    Private Sub txt6x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x8.KeyDown
        lblInput.Text = txt6x8.Text
        strAnswer = "48"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x8.Text
            CheckAnswer(strInput, strAnswer, txt6x8)
        End If
    End Sub
    Private Sub txt6x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x9.KeyDown
        lblInput.Text = txt6x9.Text
        strAnswer = "54"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x9.Text
            CheckAnswer(strInput, strAnswer, txt6x9)
        End If
    End Sub
    Private Sub txt6x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt6x10.KeyDown
        lblInput.Text = txt6x10.Text
        strAnswer = "60"
        If e.KeyCode = Keys.Enter Then
            strInput = txt6x10.Text
            CheckAnswer(strInput, strAnswer, txt6x10)
        End If
    End Sub
    Private Sub txt7x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x0.KeyDown
        lblInput.Text = txt7x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x0.Text
            CheckAnswer(strInput, strAnswer, txt7x0)
        End If
    End Sub
    Private Sub txt7x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x1.KeyDown
        lblInput.Text = txt7x1.Text
        strAnswer = "7"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x1.Text
            CheckAnswer(strInput, strAnswer, txt7x1)
        End If
    End Sub
    Private Sub txt7x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x2.KeyDown
        lblInput.Text = txt7x2.Text
        strAnswer = "14"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x2.Text
            CheckAnswer(strInput, strAnswer, txt7x2)
        End If
    End Sub
    Private Sub txt7x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x3.KeyDown
        lblInput.Text = txt7x3.Text
        strAnswer = "21"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x3.Text
            CheckAnswer(strInput, strAnswer, txt7x3)
        End If
    End Sub
    Private Sub txt7x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x4.KeyDown
        lblInput.Text = txt7x4.Text
        strAnswer = "28"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x4.Text
            CheckAnswer(strInput, strAnswer, txt7x4)
        End If
    End Sub
    Private Sub txt7x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x5.KeyDown
        lblInput.Text = txt7x5.Text
        strAnswer = "35"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x5.Text
            CheckAnswer(strInput, strAnswer, txt7x5)
        End If
    End Sub
    Private Sub txt7x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x6.KeyDown
        lblInput.Text = txt7x6.Text
        strAnswer = "42"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x6.Text
            CheckAnswer(strInput, strAnswer, txt7x6)
        End If
    End Sub
    Private Sub txt7x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x7.KeyDown
        lblInput.Text = txt7x7.Text
        strAnswer = "49"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x7.Text
            CheckAnswer(strInput, strAnswer, txt7x7)
        End If
    End Sub
    Private Sub txt7x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x8.KeyDown
        lblInput.Text = txt7x8.Text
        strAnswer = "56"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x8.Text
            CheckAnswer(strInput, strAnswer, txt7x8)
        End If
    End Sub
    Private Sub txt7x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x9.KeyDown
        lblInput.Text = txt7x9.Text
        strAnswer = "63"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x9.Text
            CheckAnswer(strInput, strAnswer, txt7x9)
        End If
    End Sub
    Private Sub txt7x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt7x10.KeyDown
        lblInput.Text = txt7x10.Text
        strAnswer = "70"
        If e.KeyCode = Keys.Enter Then
            strInput = txt7x10.Text
            CheckAnswer(strInput, strAnswer, txt7x10)
        End If
    End Sub
    Private Sub txt8x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x0.KeyDown
        lblInput.Text = txt8x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x0.Text
            CheckAnswer(strInput, strAnswer, txt8x0)
        End If
    End Sub
    Private Sub txt8x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x1.KeyDown
        lblInput.Text = txt8x1.Text
        strAnswer = "8"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x1.Text
            CheckAnswer(strInput, strAnswer, txt8x1)
        End If
    End Sub
    Private Sub txt8x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x2.KeyDown
        lblInput.Text = txt8x2.Text
        strAnswer = "16"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x2.Text
            CheckAnswer(strInput, strAnswer, txt8x2)
        End If
    End Sub
    Private Sub txt8x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x3.KeyDown
        lblInput.Text = txt8x3.Text
        strAnswer = "24"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x3.Text
            CheckAnswer(strInput, strAnswer, txt8x3)
        End If
    End Sub
    Private Sub txt8x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x4.KeyDown
        lblInput.Text = txt8x4.Text
        strAnswer = "32"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x4.Text
            CheckAnswer(strInput, strAnswer, txt8x4)
        End If
    End Sub
    Private Sub txt8x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x5.KeyDown
        lblInput.Text = txt8x5.Text
        strAnswer = "40"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x5.Text
            CheckAnswer(strInput, strAnswer, txt8x5)
        End If
    End Sub
    Private Sub txt8x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x6.KeyDown
        lblInput.Text = txt8x6.Text
        strAnswer = "48"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x6.Text
            CheckAnswer(strInput, strAnswer, txt8x6)
        End If
    End Sub
    Private Sub txt8x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x7.KeyDown
        lblInput.Text = txt8x7.Text
        strAnswer = "56"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x7.Text
            CheckAnswer(strInput, strAnswer, txt8x7)
        End If
    End Sub
    Private Sub txt8x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x8.KeyDown
        lblInput.Text = txt8x8.Text
        strAnswer = "64"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x8.Text
            CheckAnswer(strInput, strAnswer, txt8x8)
        End If
    End Sub
    Private Sub txt8x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x9.KeyDown
        lblInput.Text = txt8x9.Text
        strAnswer = "72"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x9.Text
            CheckAnswer(strInput, strAnswer, txt8x9)
        End If
    End Sub
    Private Sub txt8x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt8x10.KeyDown
        lblInput.Text = txt8x10.Text
        strAnswer = "80"
        If e.KeyCode = Keys.Enter Then
            strInput = txt8x10.Text
            CheckAnswer(strInput, strAnswer, txt8x10)
        End If
    End Sub
    Private Sub txt9x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x0.KeyDown
        lblInput.Text = txt9x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x0.Text
            CheckAnswer(strInput, strAnswer, txt9x0)
        End If
    End Sub
    Private Sub txt9x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x1.KeyDown
        lblInput.Text = txt9x1.Text
        strAnswer = "9"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x1.Text
            CheckAnswer(strInput, strAnswer, txt9x1)
        End If
    End Sub
    Private Sub txt9x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x2.KeyDown
        lblInput.Text = txt9x2.Text
        strAnswer = "18"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x2.Text
            CheckAnswer(strInput, strAnswer, txt9x2)
        End If
    End Sub
    Private Sub txt9x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x3.KeyDown
        lblInput.Text = txt9x3.Text
        strAnswer = "27"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x3.Text
            CheckAnswer(strInput, strAnswer, txt9x3)
        End If
    End Sub
    Private Sub txt9x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x4.KeyDown
        lblInput.Text = txt9x4.Text
        strAnswer = "36"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x4.Text
            CheckAnswer(strInput, strAnswer, txt9x4)
        End If
    End Sub
    Private Sub txt9x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x5.KeyDown
        lblInput.Text = txt9x5.Text
        strAnswer = "45"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x5.Text
            CheckAnswer(strInput, strAnswer, txt9x5)
        End If
    End Sub
    Private Sub txt9x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x6.KeyDown
        lblInput.Text = txt9x6.Text
        strAnswer = "54"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x6.Text
            CheckAnswer(strInput, strAnswer, txt9x6)
        End If
    End Sub
    Private Sub txt9x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x7.KeyDown
        lblInput.Text = txt9x7.Text
        strAnswer = "63"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x7.Text
            CheckAnswer(strInput, strAnswer, txt9x7)
        End If
    End Sub
    Private Sub txt9x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x8.KeyDown
        lblInput.Text = txt9x8.Text
        strAnswer = "72"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x8.Text
            CheckAnswer(strInput, strAnswer, txt9x8)
        End If
    End Sub
    Private Sub txt9x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x9.KeyDown
        lblInput.Text = txt9x9.Text
        strAnswer = "81"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x9.Text
            CheckAnswer(strInput, strAnswer, txt9x9)
        End If
    End Sub
    Private Sub txt9x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt9x10.KeyDown
        lblInput.Text = txt9x10.Text
        strAnswer = "90"
        If e.KeyCode = Keys.Enter Then
            strInput = txt9x10.Text
            CheckAnswer(strInput, strAnswer, txt9x10)
        End If
    End Sub
    Private Sub txt10x0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x0.KeyDown
        lblInput.Text = txt10x0.Text
        strAnswer = "0"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x0.Text
            CheckAnswer(strInput, strAnswer, txt10x0)
        End If
    End Sub
    Private Sub txt10x1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x1.KeyDown
        lblInput.Text = txt10x1.Text
        strAnswer = "10"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x1.Text
            CheckAnswer(strInput, strAnswer, txt10x1)
        End If
    End Sub
    Private Sub txt10x2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x2.KeyDown
        lblInput.Text = txt10x2.Text
        strAnswer = "20"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x2.Text
            CheckAnswer(strInput, strAnswer, txt10x2)
        End If
    End Sub
    Private Sub txt10x3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x3.KeyDown
        lblInput.Text = txt10x3.Text
        strAnswer = "30"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x3.Text
            CheckAnswer(strInput, strAnswer, txt10x3)
        End If
    End Sub
    Private Sub txt10x4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x4.KeyDown
        lblInput.Text = txt10x4.Text
        strAnswer = "40"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x4.Text
            CheckAnswer(strInput, strAnswer, txt10x4)
        End If
    End Sub
    Private Sub txt10x5_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x5.KeyDown
        lblInput.Text = txt10x5.Text
        strAnswer = "50"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x5.Text
            CheckAnswer(strInput, strAnswer, txt10x5)
        End If
    End Sub
    Private Sub txt10x6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x6.KeyDown
        lblInput.Text = txt10x6.Text
        strAnswer = "60"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x6.Text
            CheckAnswer(strInput, strAnswer, txt10x6)
        End If
    End Sub
    Private Sub txt10x7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x7.KeyDown
        lblInput.Text = txt10x7.Text
        strAnswer = "70"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x7.Text
            CheckAnswer(strInput, strAnswer, txt10x7)
        End If
    End Sub
    Private Sub txt10x8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x8.KeyDown
        lblInput.Text = txt10x8.Text
        strAnswer = "80"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x8.Text
            CheckAnswer(strInput, strAnswer, txt10x8)
        End If
    End Sub
    Private Sub txt10x9_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x9.KeyDown
        lblInput.Text = txt10x9.Text
        strAnswer = "90"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x9.Text
            CheckAnswer(strInput, strAnswer, txt10x9)
        End If
    End Sub
    Private Sub txt10x10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt10x10.KeyDown
        lblInput.Text = txt10x10.Text
        strAnswer = "100"
        If e.KeyCode = Keys.Enter Then
            strInput = txt10x10.Text
            CheckAnswer(strInput, strAnswer, txt10x10)
        End If
    End Sub



    'allows label for the answer to display as user enters answer
    Private Sub txt0x0_TextChanged(sender As Object, e As EventArgs) Handles txt0x0.TextChanged
        lblInput.Text = txt0x0.Text
    End Sub
    Private Sub txt0x1_TextChanged(sender As Object, e As EventArgs) Handles txt0x1.TextChanged
        lblInput.Text = txt0x1.Text
    End Sub
    Private Sub txt0x2_TextChanged(sender As Object, e As EventArgs) Handles txt0x2.TextChanged
        lblInput.Text = txt0x2.Text
    End Sub
    Private Sub txt0x3_TextChanged(sender As Object, e As EventArgs) Handles txt0x3.TextChanged
        lblInput.Text = txt0x3.Text
    End Sub
    Private Sub txt0x4_TextChanged(sender As Object, e As EventArgs) Handles txt0x4.TextChanged
        lblInput.Text = txt0x4.Text
    End Sub
    Private Sub txt0x5_TextChanged(sender As Object, e As EventArgs) Handles txt0x4.TextChanged
        lblInput.Text = txt0x5.Text
    End Sub
    Private Sub txt0x6_TextChanged(sender As Object, e As EventArgs) Handles txt0x6.TextChanged
        lblInput.Text = txt0x6.Text
    End Sub
    Private Sub txt0x7_TextChanged(sender As Object, e As EventArgs) Handles txt0x7.TextChanged
        lblInput.Text = txt0x7.Text
    End Sub
    Private Sub txt0x8_TextChanged(sender As Object, e As EventArgs) Handles txt0x8.TextChanged
        lblInput.Text = txt0x8.Text
    End Sub
    Private Sub txt0x9_TextChanged(sender As Object, e As EventArgs) Handles txt0x9.TextChanged
        lblInput.Text = txt0x9.Text
    End Sub
    Private Sub txt0x10_TextChanged(sender As Object, e As EventArgs) Handles txt0x10.TextChanged
        lblInput.Text = txt0x10.Text
    End Sub
    Private Sub txt1x0_TextChanged(sender As Object, e As EventArgs) Handles txt1x0.TextChanged
        lblInput.Text = txt1x0.Text
    End Sub
    Private Sub txt1x1_TextChanged(sender As Object, e As EventArgs) Handles txt1x1.TextChanged
        lblInput.Text = txt1x1.Text
    End Sub
    Private Sub txt1x2_TextChanged(sender As Object, e As EventArgs) Handles txt1x2.TextChanged
        lblInput.Text = txt1x2.Text
    End Sub
    Private Sub txt1x3_TextChanged(sender As Object, e As EventArgs) Handles txt1x3.TextChanged
        lblInput.Text = txt1x3.Text
    End Sub
    Private Sub txt1x4_TextChanged(sender As Object, e As EventArgs) Handles txt1x4.TextChanged
        lblInput.Text = txt1x4.Text
    End Sub
    Private Sub txt1x5_TextChanged(sender As Object, e As EventArgs) Handles txt1x4.TextChanged
        lblInput.Text = txt1x5.Text
    End Sub
    Private Sub txt1x6_TextChanged(sender As Object, e As EventArgs) Handles txt1x6.TextChanged
        lblInput.Text = txt1x6.Text
    End Sub
    Private Sub txt1x7_TextChanged(sender As Object, e As EventArgs) Handles txt1x7.TextChanged
        lblInput.Text = txt1x7.Text
    End Sub
    Private Sub txt1x8_TextChanged(sender As Object, e As EventArgs) Handles txt1x8.TextChanged
        lblInput.Text = txt1x8.Text
    End Sub
    Private Sub txt1x9_TextChanged(sender As Object, e As EventArgs) Handles txt1x9.TextChanged
        lblInput.Text = txt1x9.Text
    End Sub
    Private Sub txt1x10_TextChanged(sender As Object, e As EventArgs) Handles txt1x10.TextChanged
        lblInput.Text = txt1x10.Text
    End Sub
    Private Sub txt2x0_TextChanged(sender As Object, e As EventArgs) Handles txt2x0.TextChanged
        lblInput.Text = txt2x0.Text
    End Sub
    Private Sub txt2x1_TextChanged(sender As Object, e As EventArgs) Handles txt2x1.TextChanged
        lblInput.Text = txt2x1.Text
    End Sub
    Private Sub txt2x2_TextChanged(sender As Object, e As EventArgs) Handles txt2x2.TextChanged
        lblInput.Text = txt2x2.Text
    End Sub
    Private Sub txt2x3_TextChanged(sender As Object, e As EventArgs) Handles txt2x3.TextChanged
        lblInput.Text = txt2x3.Text
    End Sub
    Private Sub txt2x4_TextChanged(sender As Object, e As EventArgs) Handles txt2x4.TextChanged
        lblInput.Text = txt2x4.Text
    End Sub
    Private Sub txt2x5_TextChanged(sender As Object, e As EventArgs) Handles txt2x4.TextChanged
        lblInput.Text = txt2x5.Text
    End Sub
    Private Sub txt2x6_TextChanged(sender As Object, e As EventArgs) Handles txt2x6.TextChanged
        lblInput.Text = txt2x6.Text
    End Sub
    Private Sub txt2x7_TextChanged(sender As Object, e As EventArgs) Handles txt2x7.TextChanged
        lblInput.Text = txt2x7.Text
    End Sub
    Private Sub txt2x8_TextChanged(sender As Object, e As EventArgs) Handles txt2x8.TextChanged
        lblInput.Text = txt2x8.Text
    End Sub
    Private Sub txt2x9_TextChanged(sender As Object, e As EventArgs) Handles txt2x9.TextChanged
        lblInput.Text = txt2x9.Text
    End Sub
    Private Sub txt2x10_TextChanged(sender As Object, e As EventArgs) Handles txt2x10.TextChanged
        lblInput.Text = txt2x10.Text
    End Sub
    Private Sub txt3x0_TextChanged(sender As Object, e As EventArgs) Handles txt3x0.TextChanged
        lblInput.Text = txt3x0.Text
    End Sub
    Private Sub txt3x1_TextChanged(sender As Object, e As EventArgs) Handles txt3x1.TextChanged
        lblInput.Text = txt3x1.Text
    End Sub
    Private Sub txt3x2_TextChanged(sender As Object, e As EventArgs) Handles txt3x2.TextChanged
        lblInput.Text = txt3x2.Text
    End Sub
    Private Sub txt3x3_TextChanged(sender As Object, e As EventArgs) Handles txt3x3.TextChanged
        lblInput.Text = txt3x3.Text
    End Sub
    Private Sub txt3x4_TextChanged(sender As Object, e As EventArgs) Handles txt3x4.TextChanged
        lblInput.Text = txt3x4.Text
    End Sub
    Private Sub txt3x5_TextChanged(sender As Object, e As EventArgs) Handles txt3x4.TextChanged
        lblInput.Text = txt3x5.Text
    End Sub
    Private Sub txt3x6_TextChanged(sender As Object, e As EventArgs) Handles txt3x6.TextChanged
        lblInput.Text = txt3x6.Text
    End Sub
    Private Sub txt3x7_TextChanged(sender As Object, e As EventArgs) Handles txt3x7.TextChanged
        lblInput.Text = txt3x7.Text
    End Sub
    Private Sub txt3x8_TextChanged(sender As Object, e As EventArgs) Handles txt3x8.TextChanged
        lblInput.Text = txt3x8.Text
    End Sub
    Private Sub txt3x9_TextChanged(sender As Object, e As EventArgs) Handles txt3x9.TextChanged
        lblInput.Text = txt3x9.Text
    End Sub
    Private Sub txt3x10_TextChanged(sender As Object, e As EventArgs) Handles txt3x10.TextChanged
        lblInput.Text = txt3x10.Text
    End Sub
    Private Sub txt4x0_TextChanged(sender As Object, e As EventArgs) Handles txt4x0.TextChanged
        lblInput.Text = txt4x0.Text
    End Sub
    Private Sub txt4x1_TextChanged(sender As Object, e As EventArgs) Handles txt4x1.TextChanged
        lblInput.Text = txt4x1.Text
    End Sub
    Private Sub txt4x2_TextChanged(sender As Object, e As EventArgs) Handles txt4x2.TextChanged
        lblInput.Text = txt4x2.Text
    End Sub
    Private Sub txt4x3_TextChanged(sender As Object, e As EventArgs) Handles txt4x3.TextChanged
        lblInput.Text = txt4x3.Text
    End Sub
    Private Sub txt4x4_TextChanged(sender As Object, e As EventArgs) Handles txt4x4.TextChanged
        lblInput.Text = txt4x4.Text
    End Sub
    Private Sub txt4x5_TextChanged(sender As Object, e As EventArgs) Handles txt4x4.TextChanged
        lblInput.Text = txt4x5.Text
    End Sub
    Private Sub txt4x6_TextChanged(sender As Object, e As EventArgs) Handles txt4x6.TextChanged
        lblInput.Text = txt4x6.Text
    End Sub
    Private Sub txt4x7_TextChanged(sender As Object, e As EventArgs) Handles txt4x7.TextChanged
        lblInput.Text = txt4x7.Text
    End Sub
    Private Sub txt4x8_TextChanged(sender As Object, e As EventArgs) Handles txt4x8.TextChanged
        lblInput.Text = txt4x8.Text
    End Sub
    Private Sub txt4x9_TextChanged(sender As Object, e As EventArgs) Handles txt4x9.TextChanged
        lblInput.Text = txt4x9.Text
    End Sub
    Private Sub txt4x10_TextChanged(sender As Object, e As EventArgs) Handles txt4x10.TextChanged
        lblInput.Text = txt4x10.Text
    End Sub
    Private Sub txt5x0_TextChanged(sender As Object, e As EventArgs) Handles txt5x0.TextChanged
        lblInput.Text = txt5x0.Text
    End Sub
    Private Sub txt5x1_TextChanged(sender As Object, e As EventArgs) Handles txt5x1.TextChanged
        lblInput.Text = txt5x1.Text
    End Sub
    Private Sub txt5x2_TextChanged(sender As Object, e As EventArgs) Handles txt5x2.TextChanged
        lblInput.Text = txt5x2.Text
    End Sub
    Private Sub txt5x3_TextChanged(sender As Object, e As EventArgs) Handles txt5x3.TextChanged
        lblInput.Text = txt5x3.Text
    End Sub
    Private Sub txt5x4_TextChanged(sender As Object, e As EventArgs) Handles txt5x4.TextChanged
        lblInput.Text = txt5x4.Text
    End Sub
    Private Sub txt5x5_TextChanged(sender As Object, e As EventArgs) Handles txt5x4.TextChanged
        lblInput.Text = txt5x5.Text
    End Sub
    Private Sub txt5x6_TextChanged(sender As Object, e As EventArgs) Handles txt5x6.TextChanged
        lblInput.Text = txt5x6.Text
    End Sub
    Private Sub txt5x7_TextChanged(sender As Object, e As EventArgs) Handles txt5x7.TextChanged
        lblInput.Text = txt5x7.Text
    End Sub
    Private Sub txt5x8_TextChanged(sender As Object, e As EventArgs) Handles txt5x7.TextChanged
        lblInput.Text = txt5x7.Text
    End Sub
    Private Sub txt5x9_TextChanged(sender As Object, e As EventArgs) Handles txt5x9.TextChanged
        lblInput.Text = txt5x9.Text
    End Sub
    Private Sub txt5x10_TextChanged(sender As Object, e As EventArgs) Handles txt5x10.TextChanged
        lblInput.Text = txt5x10.Text
    End Sub
    Private Sub txt6x0_TextChanged(sender As Object, e As EventArgs) Handles txt6x0.TextChanged
        lblInput.Text = txt6x0.Text
    End Sub
    Private Sub txt6x1_TextChanged(sender As Object, e As EventArgs) Handles txt6x1.TextChanged
        lblInput.Text = txt6x1.Text
    End Sub
    Private Sub txt6x2_TextChanged(sender As Object, e As EventArgs) Handles txt6x2.TextChanged
        lblInput.Text = txt6x2.Text
    End Sub
    Private Sub txt6x3_TextChanged(sender As Object, e As EventArgs) Handles txt6x3.TextChanged
        lblInput.Text = txt6x3.Text
    End Sub
    Private Sub txt6x4_TextChanged(sender As Object, e As EventArgs) Handles txt6x4.TextChanged
        lblInput.Text = txt6x4.Text
    End Sub
    Private Sub txt6x5_TextChanged(sender As Object, e As EventArgs) Handles txt6x4.TextChanged
        lblInput.Text = txt6x5.Text
    End Sub
    Private Sub txt6x6_TextChanged(sender As Object, e As EventArgs) Handles txt6x6.TextChanged
        lblInput.Text = txt6x6.Text
    End Sub
    Private Sub txt6x7_TextChanged(sender As Object, e As EventArgs) Handles txt6x7.TextChanged
        lblInput.Text = txt6x7.Text
    End Sub
    Private Sub txt6x8_TextChanged(sender As Object, e As EventArgs) Handles txt6x8.TextChanged
        lblInput.Text = txt6x8.Text
    End Sub
    Private Sub txt6x9_TextChanged(sender As Object, e As EventArgs) Handles txt6x9.TextChanged
        lblInput.Text = txt6x9.Text
    End Sub
    Private Sub txt6x10_TextChanged(sender As Object, e As EventArgs) Handles txt6x10.TextChanged
        lblInput.Text = txt6x10.Text
    End Sub
    Private Sub txt7x0_TextChanged(sender As Object, e As EventArgs) Handles txt7x0.TextChanged
        lblInput.Text = txt7x0.Text
    End Sub
    Private Sub txt7x1_TextChanged(sender As Object, e As EventArgs) Handles txt7x1.TextChanged
        lblInput.Text = txt7x1.Text
    End Sub
    Private Sub txt7x2_TextChanged(sender As Object, e As EventArgs) Handles txt7x2.TextChanged
        lblInput.Text = txt7x2.Text
    End Sub
    Private Sub txt7x3_TextChanged(sender As Object, e As EventArgs) Handles txt7x3.TextChanged
        lblInput.Text = txt7x3.Text
    End Sub
    Private Sub txt7x4_TextChanged(sender As Object, e As EventArgs) Handles txt7x4.TextChanged
        lblInput.Text = txt7x4.Text
    End Sub
    Private Sub txt7x5_TextChanged(sender As Object, e As EventArgs) Handles txt7x4.TextChanged
        lblInput.Text = txt7x5.Text
    End Sub
    Private Sub txt7x6_TextChanged(sender As Object, e As EventArgs) Handles txt7x6.TextChanged
        lblInput.Text = txt7x6.Text
    End Sub
    Private Sub txt7x7_TextChanged(sender As Object, e As EventArgs) Handles txt7x6.TextChanged
        lblInput.Text = txt7x6.Text
    End Sub
    Private Sub txt7x8_TextChanged(sender As Object, e As EventArgs) Handles txt7x8.TextChanged
        lblInput.Text = txt7x8.Text
    End Sub
    Private Sub txt7x9_TextChanged(sender As Object, e As EventArgs) Handles txt7x9.TextChanged
        lblInput.Text = txt7x9.Text
    End Sub
    Private Sub txt7x10_TextChanged(sender As Object, e As EventArgs) Handles txt7x10.TextChanged
        lblInput.Text = txt7x10.Text
    End Sub
    Private Sub txt8x0_TextChanged(sender As Object, e As EventArgs) Handles txt8x0.TextChanged
        lblInput.Text = txt8x0.Text
    End Sub
    Private Sub txt8x1_TextChanged(sender As Object, e As EventArgs) Handles txt8x1.TextChanged
        lblInput.Text = txt8x1.Text
    End Sub
    Private Sub txt8x2_TextChanged(sender As Object, e As EventArgs) Handles txt8x2.TextChanged
        lblInput.Text = txt8x2.Text
    End Sub
    Private Sub txt8x3_TextChanged(sender As Object, e As EventArgs) Handles txt8x3.TextChanged
        lblInput.Text = txt8x3.Text
    End Sub
    Private Sub txt8x4_TextChanged(sender As Object, e As EventArgs) Handles txt8x4.TextChanged
        lblInput.Text = txt8x4.Text
    End Sub
    Private Sub txt8x5_TextChanged(sender As Object, e As EventArgs) Handles txt8x4.TextChanged
        lblInput.Text = txt8x5.Text
    End Sub
    Private Sub txt8x6_TextChanged(sender As Object, e As EventArgs) Handles txt8x6.TextChanged
        lblInput.Text = txt8x6.Text
    End Sub
    Private Sub txt8x7_TextChanged(sender As Object, e As EventArgs) Handles txt8x7.TextChanged
        lblInput.Text = txt8x7.Text
    End Sub
    Private Sub txt8x8_TextChanged(sender As Object, e As EventArgs) Handles txt8x8.TextChanged
        lblInput.Text = txt8x8.Text
    End Sub
    Private Sub txt8x9_TextChanged(sender As Object, e As EventArgs) Handles txt8x9.TextChanged
        lblInput.Text = txt8x9.Text
    End Sub
    Private Sub txt8x10_TextChanged(sender As Object, e As EventArgs) Handles txt8x10.TextChanged
        lblInput.Text = txt8x10.Text
    End Sub
    Private Sub txt9x0_TextChanged(sender As Object, e As EventArgs) Handles txt9x0.TextChanged
        lblInput.Text = txt9x0.Text
    End Sub
    Private Sub txt9x1_TextChanged(sender As Object, e As EventArgs) Handles txt9x1.TextChanged
        lblInput.Text = txt9x1.Text
    End Sub
    Private Sub txt9x2_TextChanged(sender As Object, e As EventArgs) Handles txt9x2.TextChanged
        lblInput.Text = txt9x2.Text
    End Sub
    Private Sub txt9x3_TextChanged(sender As Object, e As EventArgs) Handles txt9x3.TextChanged
        lblInput.Text = txt9x3.Text
    End Sub
    Private Sub txt9x4_TextChanged(sender As Object, e As EventArgs) Handles txt9x4.TextChanged
        lblInput.Text = txt9x4.Text
    End Sub
    Private Sub txt9x5_TextChanged(sender As Object, e As EventArgs) Handles txt9x4.TextChanged
        lblInput.Text = txt9x5.Text
    End Sub
    Private Sub txt9x6_TextChanged(sender As Object, e As EventArgs) Handles txt9x6.TextChanged
        lblInput.Text = txt9x6.Text
    End Sub
    Private Sub txt9x7_TextChanged(sender As Object, e As EventArgs) Handles txt9x7.TextChanged
        lblInput.Text = txt9x7.Text
    End Sub
    Private Sub txt9x8_TextChanged(sender As Object, e As EventArgs) Handles txt9x8.TextChanged
        lblInput.Text = txt9x8.Text
    End Sub
    Private Sub txt9x9_TextChanged(sender As Object, e As EventArgs) Handles txt9x9.TextChanged
        lblInput.Text = txt9x9.Text
    End Sub
    Private Sub txt9x10_TextChanged(sender As Object, e As EventArgs) Handles txt9x10.TextChanged
        lblInput.Text = txt9x10.Text
    End Sub
    Private Sub txt10x0_TextChanged(sender As Object, e As EventArgs) Handles txt10x0.TextChanged
        lblInput.Text = txt10x0.Text
    End Sub
    Private Sub txt10x1_TextChanged(sender As Object, e As EventArgs) Handles txt10x1.TextChanged
        lblInput.Text = txt10x1.Text
    End Sub
    Private Sub txt10x2_TextChanged(sender As Object, e As EventArgs) Handles txt10x2.TextChanged
        lblInput.Text = txt10x2.Text
    End Sub
    Private Sub txt10x3_TextChanged(sender As Object, e As EventArgs) Handles txt10x3.TextChanged
        lblInput.Text = txt10x3.Text
    End Sub
    Private Sub txt10x4_TextChanged(sender As Object, e As EventArgs) Handles txt10x4.TextChanged
        lblInput.Text = txt10x4.Text
    End Sub
    Private Sub txt10x5_TextChanged(sender As Object, e As EventArgs) Handles txt10x4.TextChanged
        lblInput.Text = txt10x5.Text
    End Sub
    Private Sub txt10x6_TextChanged(sender As Object, e As EventArgs) Handles txt10x6.TextChanged
        lblInput.Text = txt10x6.Text
    End Sub
    Private Sub txt10x7_TextChanged(sender As Object, e As EventArgs) Handles txt10x7.TextChanged
        lblInput.Text = txt10x7.Text
    End Sub
    Private Sub txt10x8_TextChanged(sender As Object, e As EventArgs) Handles txt10x8.TextChanged
        lblInput.Text = txt10x8.Text
    End Sub
    Private Sub txt10x9_TextChanged(sender As Object, e As EventArgs) Handles txt10x9.TextChanged
        lblInput.Text = txt10x9.Text
    End Sub
    Private Sub txt10x10_TextChanged(sender As Object, e As EventArgs) Handles txt10x10.TextChanged
        lblInput.Text = txt10x10.Text
    End Sub
    +
End Class
