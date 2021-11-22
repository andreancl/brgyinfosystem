Imports MySql.Data.MySqlClient

Public Class NewUser

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim rdo As String = ""

        If rdoadmin.Checked = True Then
            rdo = "1"
        Else
            rdo = "2"
        End If
        query = "insert into users(LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,Birthplace,ContactNo,Address,Username,Password,Position,UserType) values ('" & resident_id & "','" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNum.Text & "', '" & txtAddress.Text & "')"
        create(query, txtFirstName.Text & " " & txtLastName.Text)
    End Sub

    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbUser)
    End Sub
End Class