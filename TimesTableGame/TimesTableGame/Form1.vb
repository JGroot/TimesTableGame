Imports System
Imports System.String
Public Class frmTimeTable
    Dim strInput As String
    Dim strAnswer As String
    Dim intTotalRight As Integer


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt0x0.TextChanged
        txt0x0.SelectionAlignment = HorizontalAlignment.Center
        lblEquation.Text = "0 X 0 =  "
        strAnswer = "0"
        strInput = txt0x0.Text
        lblInput.Text = txt0x0.Text

        CheckAnswer(strInput, strAnswer, txt0x0)


    End Sub


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



 

End Class
