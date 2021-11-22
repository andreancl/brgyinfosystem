Imports MySql.Data.MySqlClient

Public Class Resident

    Public Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()

        dgvResidentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResidentRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Public Sub load_ResidentInfo()
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
      & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
      & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
       & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
       & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents` WHERE `ResidentId` LIKE '%" & txtSearchBox.Text & "%'" _
       & " OR LastName LIKE '%" & txtSearchBox.Text & "%' OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        query = "DELETE FROM residents WHERE ResidentId = '" & dgvResidentRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvResidentRecords.CurrentRow.Cells(1).Value)

        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
     & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
     & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Blotter.Show()
        Me.Close()
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        NewResident.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub
End Class