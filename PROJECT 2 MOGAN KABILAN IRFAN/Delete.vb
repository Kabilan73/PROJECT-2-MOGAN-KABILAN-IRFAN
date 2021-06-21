Imports MySql.Data.MySqlClient
Public Class Delete
    Dim connection As New MySqlConnection("datasource=localhost;username=root;password=;database=project2")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim command As New MySqlCommand("DELETE FROM `students` WHERE `Id` = @id", connection)
        command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtDelete.Text
        connection.Open()

        Try
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data is Deleted")
            Else
                MessageBox.Show("Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Something Went Wrong")
        End Try

        connection.Close()
        Me.Close()

    End Sub

    Private Sub txtDelete_TextChanged(sender As Object, e As EventArgs) Handles txtDelete.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class