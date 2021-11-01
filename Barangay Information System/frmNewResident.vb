Imports MySql.Data.MySqlClient

Public Class NewResident
    Dim command As MySqlCommand

    Public Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connection As New Connections 'Called the Class Connection'
        Try
            Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
            Dim resident_id = "RES" + datetime_now
            Dim query As String
            Query = "insert into residents(ResidentId,LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,Birthplace,CivilStatus,Religion, Nationality,ContactNo,Address) values ('" & resident_id & "','" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & cmbSex.Text & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNum.Text & "', '" & txtAddress.Text & "')"
            command = New MySqlCommand(query, connection.GetDBConnection())
            connection.OpenDBConnection()
            command.ExecuteNonQuery()
            MessageBox.Show("Registration Successful.")
            Resident.load_ResidentInfo()
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