Imports MySql.Data.MySqlClient
Public Class NewUser
    Public user_id As String
    Dim rdo As String = ""
    Dim rdoad As String = ""
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If
                query = "UPDATE `users` SET  `LastName`='" & txtLastName.Text _
                   & "', `FirstName`='" & txtFirstName.Text & "', `MiddleName`='" & txtMiddleName.Text _
                   & "', `Suffix`='" & cmbSuffix.Text & "', `Sex`='" & rdo _
                   & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") _
                   & "', `Address`='" & txtAddress.Text & "', `ContactNumber`='" & txtContactNum.Text _
                   & "', `Username`='" & txtUsername.Text & "', `Password`='" & txtPassword.Text _
                   & "', `Position`='" & cmbPosition.Text & "', WHERE `UserId`='" & lblUserId.Text & "'"
                updates(query, txtFirstName.Text & " " & txtLastName.Text)
            Else
                Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
                Dim user_id = "USER" + datetime_now

                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If

                query = "INSERT INTO users (`UserId`, `LastName`, `FirstName`, `MiddleName`" _
                & ", `Suffix`, `Sex`, `Birthdate`, `Address`, `ContactNumber`, `Username`" _
                & ", `Password`, `Position`, `UserTypeId`) VALUES ('" & user_id & "', '" & txtLastName.Text & "'" _
                & ", '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "'" _
                & ", '" & rdo & "', '" & dtpBirthdate.Text & "', '" & txtAddress.Text & "'" _
                & ", '" & txtContactNum.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "'" _
                & ", '" & cmbPosition.Text & "', '" & rdoad & "')"
                create(query, txtFirstName.Text & " " & txtLastName.Text)
            End If
            Resident.load_ResidentInfo()
            cleartext(gbUser)
            setup(gbUser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbUser)
    End Sub

    Private Sub lblUserId_TextChanged(sender As Object, e As EventArgs) Handles lblUserId.TextChanged
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtLastName.Text = dt.Rows(0).Item("LastName")
                txtFirstName.Text = dt.Rows(0).Item("FirstName")
                txtMiddleName.Text = dt.Rows(0).Item("MiddleName")
                cmbSuffix.Text = dt.Rows(0).Item("Suffix")
                dtpBirthdate.Value = dt.Rows(0).Item("Birthdate")
                txtAddress.Text = dt.Rows(0).Item("Address")
                txtContactNum.Text = dt.Rows(0).Item("ContactNumber")
                txtUsername.Text = dt.Rows(0).Item("Username")
                txtPassword.Text = dt.Rows(0).Item("Password")
                cmbPosition.Text = dt.Rows(0).Item("Position")

                If dt.Rows(0).Item("Sex") = "Male" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If

                If dt.Rows(0).Item("UserTypeId") = "1" Then
                    rdoadmin.Checked = True
                Else
                    rdouser.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class