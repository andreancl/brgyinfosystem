Public Class NewResident
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
            Dim resident_id = "RES" + datetime_now
            Dim rdo As String = ""

                If rdomale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

            query = "INSERT INTO residents (`ResidentId`, `LastName`, `FirstName`, `MiddleName`" _
                & ", `Suffix`, `Sex`, `Birthdate`, `Birthplace`, `CivilStatus`, `Religion`" _
                & ", `Nationality`, `ContactNo`, `Address`) VALUES ('" & resident_id & "','" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbSuffix.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "', '" & txtBirthplace.Text & "','" & cmbCivilStatus.Text & "', '" & txtReligion.Text & "', '" & txtNationality.Text & "', '" & txtContactNo.Text & "', '" & txtAddress.Text & "')"
                create(query, txtFirstName.Text & " " & txtLastName.Text)
           
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

    Private Sub gbResident_Enter(sender As Object, e As EventArgs) Handles gbResident.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCivilStatus.SelectedIndexChanged

    End Sub

    Private Sub cmbSuffix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSuffix.SelectedIndexChanged

    End Sub
End Class