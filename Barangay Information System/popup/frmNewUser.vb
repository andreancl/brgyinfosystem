Imports MySql.Data.MySqlClient

Public Class NewUser

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
        Dim user_id = "USER" + datetime_now
        Dim rdo As String = ""
        Try
            If rdoadmin.Checked = True Then
                rdo = "1"
            Else
                rdo = "2"
            End If

            query = "INSERT INTO residents (`UserId`, `LastName`, `FirstName`, `MiddleName`" _
                & ", `Suffix`, `Sex`, `Birthdate`, `ContactNumber, `Address`, `Username`, " _
                & ", `Password`, `Position`, `UserTypeId`) VALUES ('" & user_id & "', '" & txtLastName.Text & "'" _
                & ", '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "'" _
                & ", '" & cmbSex.Text & "', '" & dtpBirthdate.Text & "', '" & txtContactNum.Text & "'" _
                & ", '" & txtAddress.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "'" _
                & ", '" & cmbPosition.Text & "', '" & rdo & "')"
            create(query, txtFirstName.Text & " " & txtLastName.Text)

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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class