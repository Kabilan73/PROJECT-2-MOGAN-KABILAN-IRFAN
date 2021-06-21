Imports MySql.Data.MySqlClient
Public Class UpdateSQL
    Dim connection As New MySqlConnection("datasource=localhost;username=root;password=;database=project2")
    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim command As New MySqlCommand("UPDATE `students` SET `MatrixNo`=@mats,`Name`=@nam,`Department`=@dep WHERE `Id` =@id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtId.Text
        command.Parameters.Add("@mats", MySqlDbType.VarChar).Value = txtMat.Text
        command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = txtNama.Text
        command.Parameters.Add("@dep", MySqlDbType.Text).Value = txtDep.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Is Updated")

        Else

            MessageBox.Show("ERROR")

        End If

        connection.Close()
        Me.Close()
    End Sub
End Class