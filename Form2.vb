Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim obj = New Form3
        obj.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New Form3
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New Form4
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim obj = New Form5
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim obj = New Form6
        obj.Show()
        Me.Hide()
    End Sub
End Class