Imports MySql.Data.MySqlClient
Public Class frmUser
    Dim index As Integer = 0

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_UserRecords()

        dgvUserRecords.RowTemplate.Height = 30
        dgvUserRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvUserRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_UserRecords()
        query = "SELECT `UserId` AS 'UserID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
       & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
       & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Address` AS 'Address'" _
       & ", `ContactNumber` AS 'Contact Number', `Position` AS 'Position' FROM `users`"
        reloadDgv(query, dgvUserRecords)
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `UserId` AS 'UserID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
      & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
      & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Address` AS 'Address'" _
      & ", `ContactNumber` AS 'Contact Number', `Position` AS 'Position' FROM `users` WHERE UserID LIKE '%" & txtSearchBox.Text & "%' OR LastName LIKE '%" & txtSearchBox.Text & "%' OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvUserRecords)
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        NewUser.Show()
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            NewUser.lblBIS.Text = "UPDATE USER INFORMATION"
            NewUser.lblUserId.Text = dgvUserRecords.CurrentRow.Cells(0).Value
            showForm(NewUser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        query = "DELETE FROM users WHERE UserId = '" & dgvUserRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvUserRecords.CurrentRow.Cells(1).Value)

        query = "SELECT `UserId` AS 'UserID',`LastName` as 'Last Name', `FirstName` as 'First Name'" _
         & ", `MiddleName` AS 'Middle Name',`Suffix` as 'Suffix', `Sex` AS 'Sex'" _
         & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `Address` AS 'Address'" _
         & ", `ContactNumber` AS 'Contact Number', `Position` AS 'Position' FROM `users` WHERE UserID LIKE '%" & txtSearchBox.Text & "%' OR LastName LIKE '%" & txtSearchBox.Text & "%' OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvUserRecords)
    End Sub
    Private Sub dgvUserRecords_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvUserRecords.CellToolTipTextNeeded
        Dim dgv = DirectCast(sender, DataGridView)

        If e.RowIndex = -1 AndAlso e.ColumnIndex <> -1 Then
            e.ToolTipText = dgv.Columns(e.ColumnIndex).HeaderText & vbCrLf
        Else
            e.ToolTipText = "right click to see available options"
        End If
    End Sub
    Private Sub dgvUserRecords_CellMouseUp(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvUserRecords.CellMouseUp
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                dgvUserRecords.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvUserRecords.CurrentCell = dgvUserRecords.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvUserRecords, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class