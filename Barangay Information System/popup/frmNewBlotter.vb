Public Class NewBlotter
    Dim ServiceId As String = "1"
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Const militaryTimeFormat As String = "HH:mm:ss"
        Dim dtpIncidentTime As String = DateTime.Now.ToString(militaryTimeFormat)

        Try
            query = "INSERT INTO service_details (`ServiceId`, `ComplaineeName`, `DefendantName`, `Incident`" _
                & ", `IncidentDate`, `IncidentTime`, `Statement`, `ResidentId`) VALUES ('" & ServiceId & "'" _
                & ", '" & txtComName.Text & "', '" & txtDefName.Text & "', '" & txtIncident.Text & "'" _
                & ", '" & dtpIncidentDate.Text & "', '" & dtpIncidentTime & "'" _
                & ", '" & txtStatement.Text & "', '" & txtResidentId.Text & "' )"
            fileblotter(query, txtComName.Text & " ")

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

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        With viewResident
            .ShowDialog()
        End With
    End Sub

    Private Sub NewBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbBlotter)
    End Sub
End Class