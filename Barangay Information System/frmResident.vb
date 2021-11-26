Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class Resident
    Dim pfont As Font = New Font("Arial", 14)
    Dim ppfont As Font = New Font("Arial", 14, FontStyle.Bold)
    Dim sfont As Font = New Font("Arial", 16, FontStyle.Bold)
    Dim tfont As Font = New Font("Arial", 18, FontStyle.Bold)
    Dim line = ""
    Dim index As Integer = 0

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
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            NewResident.lblResTitle.Text = "UPDATE RESIDENT INFORMATION"
            NewResident.lblResId.Text = dgvResidentRecords.CurrentRow.Cells(0).Value
            showForm(NewResident)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
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
    Private Sub dgvResidentRecords_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvResidentRecords.CellToolTipTextNeeded
        Dim dgv = DirectCast(sender, DataGridView)

        If e.RowIndex = -1 AndAlso e.ColumnIndex <> -1 Then
            e.ToolTipText = dgv.Columns(e.ColumnIndex).HeaderText & vbCrLf
        Else
            e.ToolTipText = "right click to see available options"
        End If
    End Sub
    Private Sub dgvResidentRecords_CellMouseUp(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvResidentRecords.CellMouseUp
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                dgvResidentRecords.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvResidentRecords.CurrentCell = dgvResidentRecords.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvResidentRecords, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BToolStripMenuItem.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With
            PrintDocument1.DefaultPageSettings = pagesetup
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
         Dim topmargin = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim leftmargin = PrintDocument1.DefaultPageSettings.Margins.Left
        e.Graphics.DrawImage(Dashboard.PictureBox1.Image, 60, 80, Dashboard.PictureBox1.Width - 15, Dashboard.PictureBox1.Height - 25)

        e.Graphics.DrawString(vbTab + vbTab + "Republic of the Philippines", pfont, Brushes.Black, leftmargin + 80, topmargin + 15 + 20)
        e.Graphics.DrawString("National Capital Region", pfont, Brushes.Black, leftmargin + 250, topmargin + 30 + 35)
        e.Graphics.DrawString("Barangay 642", sfont, Brushes.Black, leftmargin + 273, topmargin + 45 + 50)
        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", sfont, Brushes.Black, leftmargin + 170, topmargin + 75 + 80)
        e.Graphics.DrawString("CERTIFICATE OF RESIDENCY", tfont, Brushes.Black, leftmargin + 185, topmargin + 150 + 80)
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN,", ppfont, Brushes.Black, leftmargin + 20, topmargin + 250 + 80)

    End Sub
End Class