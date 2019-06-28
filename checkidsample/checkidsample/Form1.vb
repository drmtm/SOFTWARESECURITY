Imports mtmsec

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sec As New mtmsoftsec ' create class instance
        Dim result As Boolean ' variable to store checking result

        ' read the key from file stored in then pass to the method to check

        result = sec.CheckId("fakeid")
        MessageBox.Show(result)

        ' here you take action based on result 

    End Sub
End Class
