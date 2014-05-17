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
            txtbox.ReadOnly = True
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
 

   
    Private Sub txt0x1_TextChanged(sender As Object, e As EventArgs) Handles txt0x1.TextChanged

        lblEquation.Text = "0 X 1 =  "
        strAnswer = "0"
        strInput = txt0x1.Text
        lblInput.Text = txt0x1.Text

        CheckAnswer(strInput, strAnswer, txt0x1)
    End Sub

    Private Sub txt0x2_TextChanged(sender As Object, e As EventArgs) Handles txt0x2.TextChanged

        lblEquation.Text = "0 X 2 =  "
        strAnswer = "0"
        strInput = txt0x2.Text
        lblInput.Text = txt0x2.Text

        CheckAnswer(strInput, strAnswer, txt0x2)
    End Sub
End Class
