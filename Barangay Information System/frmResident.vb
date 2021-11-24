Imports MySql.Data.MySqlClient

Public Class Resident

    Public Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()

        dgvResidentRecords.RowTemplate.Height = 30
        dgvResidentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvResidentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResidentRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_ResidentInfo()
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
        & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace'" _
        & ", `CivilStatus` AS 'Civil Status', `Religion` as 'Religion', `Nationality` as 'Nationality'" _
        & ", `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
        & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace'" _
        & ", `CivilStatus` AS 'Civil Status', `Religion` as 'Religion', `Nationality` as 'Nationality'" _
        & ", `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents` WHERE `ResidentId`" _
        & ",  LIKE '%" & txtSearchBox.Text & "%'"" OR LastName LIKE '%" & txtSearchBox.Text & "%'" _
        & ", OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        query = "DELETE FROM residents WHERE ResidentId = '" & dgvResidentRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvResidentRecords.CurrentRow.Cells(1).Value)

        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
        & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace'" _
        & ", `CivilStatus` AS 'Civil Status', `Religion` as 'Religion', `Nationality` as 'Nationality'" _
        & ", `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        NewResident.Show()
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Try
            NewResident.lblResTitle.Text = "UPDATE RESIDENT INFORMATION"
            NewResident.lblResId.Text = dgvResidentRecords.CurrentRow.Cells(0).Value
            showForm(NewResident)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class