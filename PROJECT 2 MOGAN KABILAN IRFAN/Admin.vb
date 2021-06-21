Imports MySql.Data.MySqlClient
Public Class Admin
    Private Sub btncre_Click(sender As Object, e As EventArgs) Handles btncre.Click
        Dim intId As Integer
        Dim strMatrixNo As String = txtno.Text
        Dim strName As String = txtnama.Text
        Dim strDepartment As String = txtdep.Text
        Dim strSql = "INSERT INTO students VALUES ('" & intId & "', '" & strMatrixNo & "', '" & strName & "', '" & strDepartment & "')"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
            MessageBox.Show("Succesfully stored data.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed to stored data." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnrea_Click(sender As Object, e As EventArgs) Handles btnrea.Click
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM students")
        If retrieveTable.CreateDataReader.HasRows = False Then
            MessageBox.Show("No data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim row As DataRow
        dgvStudent.Rows.Clear()
        For Each row In retrieveTable.Rows
            dgvStudent.Rows.Add(row("Id"), row("MatrixNo"), row("Name"), row("Department"))

        Next
        retrieveTable = Nothing
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        UpdateSQL.Show()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Delete.Show()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class