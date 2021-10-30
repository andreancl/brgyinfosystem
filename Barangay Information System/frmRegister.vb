Imports MySql.Data.MySqlClient

Public Class Register
    Dim Command As MySqlCommand

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim Reader As MySqlDataReader

        Try
            Dim Query As String
            Query = "insert into tbl_resident (LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,Birthplace,CivilStatus,Religion, Nationality,ContactNo,Address) values ('" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & cmbSex.Text & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNum.Text & "', '" & txtAddress.Text & "')"
            Command = New MySqlCommand(Query, connection.GetDBConnection())
            Reader = Command.ExecuteReader
            MessageBox.Show("Data Saved.")
            connection.CloseDBConnection() 'Called the Method CloseDBConnection'
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.DisposeDBConnection() 'Called the Method DisposeDBConnection'
        End Try
    End Sub

End Class