Public Class viewResident

    Private Sub viewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resident.load_ResidentInfo()

        dgvResidentList.RowTemplate.Height = 30
        dgvResidentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvResidentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResidentList.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `ResidentId` AS 'ResidentID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
        & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Birthplace` as 'Birthplace'" _
        & ", `CivilStatus` AS 'Civil Status', `Religion` as 'Religion', `Nationality` as 'Nationality'" _
        & ", `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents` WHERE `ResidentId`" _
        & ",  LIKE '%" & txtSearchBox.Text & "%'"" OR LastName LIKE '%" & txtSearchBox.Text & "%'" _
        & ", OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvResidentList)
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            NewBlotter.txtResidentId.Text = dgvResidentList.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvResidentList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvResidentList.DoubleClick
        Try
            NewBlotter.txtResidentId.Text = dgvResidentList.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class