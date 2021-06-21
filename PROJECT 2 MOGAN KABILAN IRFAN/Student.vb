Imports MySql.Data.MySqlClient
Public Class Student
    Private Sub btnrea_Click(sender As Object, e As EventArgs) Handles btnrea.Click
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM students")
        If retrieveTable.CreateDataReader.HasRows = False Then
            MessageBox.Show("No data found.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim row As DataRow
        dgvStudent.Rows.Clear()
        For Each row In retrieveTable.Rows
            dgvStudent.Rows.Add(row("Id"), row("MatrixNo"), row("Name"), row("Department"))

        Next
        retrieveTable = Nothing
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        UpdateSQL.Show()
    End Sub
End Class