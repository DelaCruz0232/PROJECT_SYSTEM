Public Class Form3


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Form2
        obj.Show()
        Me.Hide()
    End Sub
End Class