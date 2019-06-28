Imports mtmsec

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sec As New mtmsoftsec
        TextBox1.Text = sec.getID()
       
    End Sub
End Class
