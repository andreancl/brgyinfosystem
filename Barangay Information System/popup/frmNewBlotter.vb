Public Class NewBlotter
    Dim ServiceId As String = "1"
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            query = "INSERT INTO service_details (`ServiceId`, `ComplaineeName`, `DefendantName`, `Incident`" _
                & ", `IncidentDate`, `IncidentTime`, `Statement`, `ResidentId`) VALUES ('" & ServiceId & "'" _
                & ", '" & txtComName.Text & "', '" & txtDefName.Text & "', '" & txtIncident.Text & "'" _
                & ", '" & dtpIncidentDate.Text & "', '" & dtpIncidentTime.Text & "'" _
                & ", '" & txtStatement.Text & "')"
            create(query, txtDefName.Text & " " & txtComName.Text)

            Resident.load_ResidentInfo()
            cleartext(gbBlotter)
            setup(gbBlotter)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class