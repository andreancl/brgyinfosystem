Imports MySql.Data.MySqlClient

Public Class NewUser
    Dim Command As MySqlCommand

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim Reader As MySqlDataReader
        Try
            Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
            Dim user_id = "USER" + datetime_now
            Dim Query As String
            Query = "insert into users(UserId,LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,ContactNumber,Address,Username,Password,Position,UserTypeId) values ('" & user_id & "','" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & cmbSex.Text & "', '" & dtpBirthdate.Text & "','" & txtContactNum.Text & "', '" & txtAddress.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbPosition.Text & "','" & cmbUserType.Text & "')"
            Command = New MySqlCommand(Query, connection.GetDBConnection())
            Reader = Command.ExecuteReader
            MessageBox.Show("Account has been successfully created.")
            Me.Close()
            connection.CloseDBConnection() 'Called the Method CloseDBConnection'
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.DisposeDBConnection() 'Called the Method DisposeDBConnection'
        End Try
    End Sub

    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub
End Class