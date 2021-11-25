Public Class NewResident
    Public resident_id As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim rdo As String = ""
            query = "SELECT * FROM `residents` WHERE `ResidentId`='" & lblResId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "UPDATE `residents` SET  `LastName`='" & txtLastName.Text _
                   & "', `FirstName`='" & txtFirstName.Text & "', `MiddleName`='" & txtMiddleName.Text _
                   & "', `Suffix`='" & cmbSuffix.Text & "', `Sex`='" & rdo _
                   & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") _
                   & "', `Birthplace`='" & txtBirthplace.Text & "', `CivilStatus`='" & cmbCivilStatus.Text _
                   & "', `Religion`='" & txtReligion.Text & "', `Nationality`='" & txtNationality.Text _
                   & "', `ContactNo`='" & txtContactNo.Text & "', `Address`='" & txtAddress.Text _
                   & "' WHERE `ResidentId`='" & lblResId.Text & "'"
                updates(query, txtFirstName.Text & " " & txtLastName.Text)
            Else
                Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
                Dim resident_id = "RES" + datetime_now

                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "INSERT INTO `residents` (`ResidentId`, `LastName`, `FirstName`, `MiddleName`" _
                    & ", `Suffix`, `Sex`, `Birthdate`, `Birthplace`, `CivilStatus`, `Religion`" _
                    & ", `Nationality`, `ContactNo`, `Address`) VALUES ('" & resident_id & "'" _
                    & ", '" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "'" _
                    & ", '" & cmbSuffix.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "'" _
                    & ", '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "'" _
                    & ", '" & txtNationality.Text & "', '" & txtContactNo.Text & "', '" & txtAddress.Text & "')"
                create(query, txtFirstName.Text & " " & txtLastName.Text)
            End If
            Resident.load_ResidentInfo()
            cleartext(gbResident)
            setup(gbResident)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub NewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbResident)
    End Sub

    Private Sub lblResId_TextChanged(sender As Object, e As EventArgs) Handles lblResId.TextChanged
        Try
            query = "SELECT * FROM `residents` WHERE `ResidentId`='" & lblResId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtLastName.Text = dt.Rows(0).Item("LastName")
                txtFirstName.Text = dt.Rows(0).Item("FirstName")
                txtMiddleName.Text = dt.Rows(0).Item("MiddleName")
                cmbSuffix.Text = dt.Rows(0).Item("Suffix")
                dtpBirthdate.Value = dt.Rows(0).Item("Birthdate")
                txtBirthplace.Text = dt.Rows(0).Item("Birthplace")
                cmbCivilStatus.Text = dt.Rows(0).Item("CivilStatus")
                txtReligion.Text = dt.Rows(0).Item("Religion")
                txtNationality.Text = dt.Rows(0).Item("Nationality")
                txtContactNo.Text = dt.Rows(0).Item("ContactNo")
                txtAddress.Text = dt.Rows(0).Item("Address")
                If dt.Rows(0).Item("Sex") = "Male" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class