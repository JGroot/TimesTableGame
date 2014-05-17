Imports System
Imports System.String
Public Class Form1
    Dim strInput As String
    Dim strAnswer As String
    Dim intTotalRight As Integer


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt0x0.TextChanged
        txt0x0.SelectionAlignment = HorizontalAlignment.Center
        strAnswer = "0"
        strInput = txt0x0.Text

        If strInput = strAnswer Then
            txt0x0.BackColor = Color.LightGreen
            txt0x0.ReadOnly = True
            intTotalRight += 1
        ElseIf IsNullOrEmpty(strInput) Then
            txt0x0.BackColor = Color.White
        Else
            txt0x0.BackColor = Color.Red
        End If

    End Sub
End Class
