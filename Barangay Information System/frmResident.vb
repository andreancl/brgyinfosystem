Imports MySql.Data.MySqlClient

Public Class Resident

    Public Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        dgvResidentRecords.RowTemplate.Height = 30
        dgvResidentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        dgvResidentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResidentRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_ResidentInfo()
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'Last Name', `FirstName` as 'First Name', `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
      & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'Civil Status'" _
      & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
       & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
       & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents` WHERE `ResidentId` LIKE '%" & txtSearchBox.Text & "%'" _
       & " OR LastName LIKE '%" & txtSearchBox.Text & "%' OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvResidentRecords)
=======
=======
>>>>>>> Stashed changes
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Blotter.Show()
        Me.Close()
<<<<<<< Updated upstream
>>>>>>> Stashed changes
    End Sub

    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        query = "DELETE FROM residents WHERE ResidentId = '" & dgvResidentRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvResidentRecords.CurrentRow.Cells(1).Value)

<<<<<<< Updated upstream
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
     & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
     & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
=======
>>>>>>> Stashed changes
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        NewResident.Show()
=======
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub

<<<<<<< Updated upstream
    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Try
            NewResident.lblResTitle.Text = "EDIT/UPDATE RESIDENT"
            NewResident.lblResId.Text = dgvResidentRecords.CurrentRow.Cells(0).Value()
            NewResident.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

=======
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Try
            NewResident.lblResTitle.Text = "EDIT/UPDATE RESIDENT"
            NewResident.lblResId.Text = dgvResidentRecords.CurrentRow.Cells(0).Value()
            NewResident.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

>>>>>>> Stashed changes
    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        query = "DELETE FROM residents WHERE ResidentId = '" & dgvResidentRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvResidentRecords.CurrentRow.Cells(1).Value)

        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'LastName', `FirstName` as 'FirstName', `MiddleName` AS 'MiddleName',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
     & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace', `CivilStatus` AS 'CivilStatus'" _
     & ",`Religion` as 'Religion', `Nationality` as 'Nationality', `ContactNo` AS 'ContactNumber', `Address` AS 'Address'  FROM `residents`"
        reloadDgv(query, dgvResidentRecords)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    End Sub
End Class