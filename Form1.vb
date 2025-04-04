Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTB.Text = "" Or PasswordTB.Text = "" Then
            MsgBox("Enter Username and password")
        ElseIf UnameTB.Text = "TARA KAPE" And PasswordTB.Text = "SIGE" Then
            Dim obj = New Form2
            obj.Show
            Hide
        Else
            MsgBox("Wrong Username or Password")
            UnameTB.Text = ""
            PasswordTB.Text = ""
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
