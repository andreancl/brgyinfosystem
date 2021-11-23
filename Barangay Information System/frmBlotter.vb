Imports MySql.Data.MySqlClient

Public Class Blotter
    Private Sub Blotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_BlotterRecords()

        dgvBlotterRecords.RowTemplate.Height = 30
        dgvBlotterRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvBlotterRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBlotterRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_BlotterRecords()
        query = "SELECT `ComplaineeName` AS 'Complainee Name',`DefendantName` as 'Defendant Name'" _
        & ", `Incident` as 'Incident', `IncidentDate` AS 'Incident Date',`IncidentTime` as 'Incident Time'" _
        & ", `Statement` AS 'Statement' FROM service_details"
        reloadDgv(query, dgvBlotterRecords)
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `ComplaineeName` AS 'ComplaineeName',`DefendantName` as 'DefendantName'" _
        & ", `Incident` as 'Incident', `IncidentDate` AS 'IncidentDate',`IncidentTime` as 'IncidentTime'" _
        & ", `Statement` AS 'Statement' FROM `service_details` WHERE `ComplaineeName` LIKE " _
        & ", '%" & txtSearchBox.Text & "%' OR DefendantName LIKE '%" & txtSearchBox.Text & "%' " _
        & ", OR Incident LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvBlotterRecords)
    End Sub

    Private Sub btnNewBlotter_Click(sender As Object, e As EventArgs) Handles btnNewBlotter.Click
        NewBlotter.Show()
    End Sub
End Class