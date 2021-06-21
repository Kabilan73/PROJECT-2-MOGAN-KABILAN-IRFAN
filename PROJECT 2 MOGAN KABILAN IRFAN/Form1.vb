Public Class Form1
    Private Sub btnad_Click(sender As Object, e As EventArgs) Handles btnad.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnstud_Click(sender As Object, e As EventArgs) Handles btnstud.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
