Imports MySql.Data.MySqlClient

Public Class Register
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=nicole062419;database=brgyinfodb"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into brgyinfodb.tbl_resident (LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,Birthplace,CivilStatus,Religion, Nationality,ContactNo,Address) values ('" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & cmbSex.Text & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNum.Text & "', '" & txtAddress.Text & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader


            MessageBox.Show("Data Saved.")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Class