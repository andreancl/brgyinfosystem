Public Class NewResident
    Public resident_id As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim rdo As String = ""

            query = "SELECT * FROM residents WHERE `ResidentId` = '" & resident_id & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                '-------------------update
                If rdomale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "UPDATE `residents` SET `LastName`='" & txtLastName.Text _
                & "', `FirstName`='" & txtFirstName.Text & "', `MiddleName`='" & txtMiddleName.Text _
                & "', `Suffix`='" & cmbSuffix.Text & "', `Sex`='" & rdo & "', " _
                & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") & "'" _
                & "', `Birthplace`='" & txtBirthplace.Text & "', `CivilStatus`='" & cmbCivilStatus.Text _
                & "', `Religion`='" & txtReligion.Text & "', `Nationality`='" & txtNationality.Text _
                & "', `ContactNo`='" & txtContactNum.Text & "', `Address`='" & txtAddress.Text _
                & "',  WHERE `ResidentId`='" & resident_id & "'"
                updates(query, txtLastName.Text)
            Else
                Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
                Dim resident_id = "RES" + datetime_now

                If rdomale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "insert into residents(ResidentId,LastName,FirstName,MiddleName,Suffix,Sex,Birthdate,Birthplace,CivilStatus,Religion, Nationality,ContactNo,Address) values ('" & resident_id & "','" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNum.Text & "', '" & txtAddress.Text & "')"
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
End Class