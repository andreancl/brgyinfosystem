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

            Blotter.load_BlotterRecords()
            cleartext(gbBlotter)
            setup(gbBlotter)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub
End Class