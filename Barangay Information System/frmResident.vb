Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class Resident
    Dim pfont As Font = New Font("Arial", 14)
    Dim psfont As Font = New Font("Arial", 14, FontStyle.Bold)
    Dim sfont As Font = New Font("Arial", 16, FontStyle.Bold)
    Dim tfont As Font = New Font("Arial", 18, FontStyle.Bold)
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
        & ", `ContactNo` AS 'Contact Number', `Address` AS 'Address'  FROM `residents` WHERE ResidentID LIKE '%" & txtSearchBox.Text & "%' OR LastName LIKE '%" & txtSearchBox.Text & "%' OR FirstName LIKE '%" & txtSearchBox.Text & "%'"
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
#Region "Certificate of Residency"
    Private Sub cmsCertRes_Click(sender As Object, e As EventArgs) Handles cmsCertRes.Click
        printset(cmsCertRes)
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim topmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top()
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left()

        Dim dateString As String = Date.Today.ToString(" d'th' 'day of' MMMMMMMM,  yyyy  ")
        e.Graphics.DrawImage(Dashboard.PictureBox1.Image, 100, 90, Dashboard.PictureBox1.Width - 30, Dashboard.PictureBox1.Height - 50)
        e.Graphics.DrawImage(Dashboard.PictureBox2.Image, 560, 90, Dashboard.PictureBox2.Width - 10, Dashboard.PictureBox1.Height - 40)
        e.Graphics.DrawString(vbTab + vbTab + "Republic of the Philippines", pfont, Brushes.Black, leftmargin + 80, topmargin + 15 + 20)
        e.Graphics.DrawString("National Capital Region", pfont, Brushes.Black, leftmargin + 250, topmargin + 30 + 35)
        e.Graphics.DrawString("City of Manila", sfont, Brushes.Black, leftmargin + 273, topmargin + 45 + 50)
        e.Graphics.DrawString("Barangay 403", sfont, Brushes.Black, leftmargin + 275, topmargin + 60 + 65)

        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", sfont, Brushes.Black, leftmargin + 160, topmargin + 90 + 95)
        e.Graphics.DrawString("CERTIFICATE OF RESIDENCY", tfont, Brushes.Black, leftmargin + 180, topmargin + 150 + 80)
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN,", psfont, Brushes.Black, leftmargin + 20, topmargin + 220 + 80)

        For row As Integer = 0 To dgvResidentRecords.RowCount - 1
            e.Graphics.DrawString("This is to certify that " + dgvResidentRecords.CurrentRow.Cells(2).Value.ToString _
            + " " + dgvResidentRecords.CurrentRow.Cells(3).Value.ToString + " " + dgvResidentRecords.CurrentRow _
            .Cells(1).Value.ToString + " " + dgvResidentRecords.CurrentRow.Cells(4).Value.ToString + ", " + _
            dgvResidentRecords.CurrentRow.Cells(6).Value.ToString + " years old, ", pfont, Brushes.Black, leftmargin + 100, topmargin + 270 + 80)
            e.Graphics.DrawString(dgvResidentRecords.CurrentRow.Cells(8).Value.ToString + ", " + dgvResidentRecords.CurrentRow.Cells(10).Value.ToString + " citizen, whose specimen  signature  appears  below  is  a", pfont, Brushes.Black, leftmargin + 20, topmargin + 310 + 80)
            e.Graphics.DrawString("PERMANENT RESIDENT of this Barangay 403, City of Manila.", pfont, Brushes.Black, leftmargin + 20, topmargin + 350 + 80)

            e.Graphics.DrawString("Based on  the  records  of  this  office, they  have  been  residing at", pfont, Brushes.Black, leftmargin + 100, topmargin + 400 + 80)
            e.Graphics.DrawString("Barangay 403, City of Manila.", pfont, Brushes.Black, leftmargin + 20, topmargin + 440 + 80)

            e.Graphics.DrawString("This  CERTIFICATION  is  being  issued  upon  the  request  of  the  ", pfont, Brushes.Black, leftmargin + 100, topmargin + 500 + 80)
            e.Graphics.DrawString("above-named person for whatever legal purpose it may serve.", pfont, Brushes.Black, leftmargin + 20, topmargin + 540 + 80)

            e.Graphics.DrawString("Issued  this " + dateString + "at  Barangay  403,  City", pfont, Brushes.Black, leftmargin + 100, topmargin + 600 + 80)
            e.Graphics.DrawString("of Manila, NCR, Philippines.", pfont, Brushes.Black, leftmargin + 20, topmargin + 640 + 80)

            e.Graphics.DrawString("Specimen Signature", pfont, Brushes.Black, leftmargin + 20, topmargin + 710 + 80)
            e.Graphics.DrawString("__________________", pfont, Brushes.Black, leftmargin + 20, topmargin + 750 + 80)

            e.Graphics.DrawString("Bernard Gresola", sfont, Brushes.Black, leftmargin + 535, topmargin + 790 + 80)
            e.Graphics.DrawString("_______________", pfont, Brushes.Black, leftmargin + 540, topmargin + 800 + 80)
            e.Graphics.DrawString("Barangay Captain", pfont, Brushes.Black, leftmargin + 540, topmargin + 830 + 80)
        Next
    End Sub
#End Region
#Region "Barangay Clearance"
    Private Sub cmsBrgyClearance_Click(sender As Object, e As EventArgs) Handles cmsBrgyClearance.Click
        printset2(cmsBrgyClearance)
    End Sub
    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim topmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top()
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left()

        Dim dateString As String = Date.Today.ToString(" d'th' 'day of' MMMMMMMM,  yyyy  ")
        e.Graphics.DrawImage(Dashboard.PictureBox1.Image, 100, 90, Dashboard.PictureBox1.Width - 30, Dashboard.PictureBox1.Height - 50)
        e.Graphics.DrawImage(Dashboard.PictureBox2.Image, 560, 90, Dashboard.PictureBox2.Width - 10, Dashboard.PictureBox1.Height - 40)
        e.Graphics.DrawString(vbTab + vbTab + "Republic of the Philippines", pfont, Brushes.Black, leftmargin + 80, topmargin + 15 + 20)
        e.Graphics.DrawString("National Capital Region", pfont, Brushes.Black, leftmargin + 250, topmargin + 30 + 35)
        e.Graphics.DrawString("City of Manila", sfont, Brushes.Black, leftmargin + 273, topmargin + 45 + 50)
        e.Graphics.DrawString("Barangay 403", sfont, Brushes.Black, leftmargin + 275, topmargin + 60 + 65)

        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", sfont, Brushes.Black, leftmargin + 160, topmargin + 90 + 95)
        e.Graphics.DrawString("BARANGAY CLEARANCE", tfont, Brushes.Black, leftmargin + 210, topmargin + 150 + 80)
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN,", psfont, Brushes.Black, leftmargin + 20, topmargin + 220 + 80)

        For row As Integer = 0 To dgvResidentRecords.RowCount - 1
            e.Graphics.DrawString("This is to certify that " + dgvResidentRecords.CurrentRow.Cells(2).Value.ToString _
            + " " + dgvResidentRecords.CurrentRow.Cells(3).Value.ToString + " " + dgvResidentRecords.CurrentRow _
            .Cells(1).Value.ToString + " " + dgvResidentRecords.CurrentRow.Cells(4).Value.ToString + ", " + _
            dgvResidentRecords.CurrentRow.Cells(6).Value.ToString + " years old, ", pfont, Brushes.Black, leftmargin + 100, topmargin + 270 + 80)
            e.Graphics.DrawString("resident of Barangay 403, City of Manila,  is  known  to  be  of  good-moral", pfont, Brushes.Black, leftmargin + 20, topmargin + 310 + 80)
            e.Graphics.DrawString("character and law-abiding citizen in the community", pfont, Brushes.Black, leftmargin + 20, topmargin + 350 + 80)

            e.Graphics.DrawString("To certify further, they have no derogatory and/or criminal records", pfont, Brushes.Black, leftmargin + 100, topmargin + 400 + 80)
            e.Graphics.DrawString("filed in this barangay.", pfont, Brushes.Black, leftmargin + 20, topmargin + 440 + 80)

            e.Graphics.DrawString("This  CERTIFICATION is being issued  upon  the  request  of  the  ", pfont, Brushes.Black, leftmargin + 100, topmargin + 500 + 80)
            e.Graphics.DrawString("above-named person for whatever legal purpose it may serve and is valid ", pfont, Brushes.Black, leftmargin + 20, topmargin + 540 + 80)
            e.Graphics.DrawString("for 6 months from date issued. ", pfont, Brushes.Black, leftmargin + 20, topmargin + 580 + 80)

            e.Graphics.DrawString("Issued  this " + dateString + "at  Barangay 403, City", pfont, Brushes.Black, leftmargin + 100, topmargin + 640 + 80)
            e.Graphics.DrawString("of Manila, NCR, Philippines.", pfont, Brushes.Black, leftmargin + 20, topmargin + 680 + 80)

            e.Graphics.DrawString("Bernard Gresola", sfont, Brushes.Black, leftmargin + 515, topmargin + 780 + 80)
            e.Graphics.DrawString("_______________", pfont, Brushes.Black, leftmargin + 515, topmargin + 790 + 80)
            e.Graphics.DrawString(" Barangay Captain", pfont, Brushes.Black, leftmargin + 515, topmargin + 815 + 80)
        Next
    End Sub
#End Region
#Region "Certificate of Indigency"
    Private Sub cmsCertIndig_Click(sender As Object, e As EventArgs) Handles cmsCertIndig.Click
        printset3(cmsCertIndig)
    End Sub
    Private Sub PrintDocument3_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim topmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top()
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left()

        Dim dateString As String = Date.Today.ToString(" d'th' 'day of' MMMMMMMM,  yyyy  ")
        e.Graphics.DrawImage(Dashboard.PictureBox1.Image, 100, 90, Dashboard.PictureBox1.Width - 30, Dashboard.PictureBox1.Height - 50)
        e.Graphics.DrawImage(Dashboard.PictureBox2.Image, 560, 90, Dashboard.PictureBox2.Width - 10, Dashboard.PictureBox1.Height - 40)
        e.Graphics.DrawString(vbTab + vbTab + "Republic of the Philippines", pfont, Brushes.Black, leftmargin + 80, topmargin + 15 + 20)
        e.Graphics.DrawString("National Capital Region", pfont, Brushes.Black, leftmargin + 250, topmargin + 30 + 35)
        e.Graphics.DrawString("City of Manila", sfont, Brushes.Black, leftmargin + 273, topmargin + 45 + 50)
        e.Graphics.DrawString("Barangay 403", sfont, Brushes.Black, leftmargin + 275, topmargin + 60 + 65)

        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", sfont, Brushes.Black, leftmargin + 160, topmargin + 90 + 95)
        e.Graphics.DrawString("CERTIFICATE OF INDIGENCY", tfont, Brushes.Black, leftmargin + 180, topmargin + 150 + 80)
        e.Graphics.DrawString("TO WHOM IT MAY CONCERN,", psfont, Brushes.Black, leftmargin + 20, topmargin + 220 + 80)

        For row As Integer = 0 To dgvResidentRecords.RowCount - 1
            e.Graphics.DrawString("This is to certify that " + dgvResidentRecords.CurrentRow.Cells(2).Value.ToString _
            + " " + dgvResidentRecords.CurrentRow.Cells(3).Value.ToString + " " + dgvResidentRecords.CurrentRow _
            .Cells(1).Value.ToString + " " + dgvResidentRecords.CurrentRow.Cells(4).Value.ToString + ", " + _
            dgvResidentRecords.CurrentRow.Cells(6).Value.ToString + " years old, ", pfont, Brushes.Black, leftmargin + 100, topmargin + 270 + 80)
            e.Graphics.DrawString(dgvResidentRecords.CurrentRow.Cells(8).Value.ToString + ", " + dgvResidentRecords.CurrentRow.Cells(10).Value.ToString + " citizen, is a resident of Barangay 403, City of Manila", pfont, Brushes.Black, leftmargin + 20, topmargin + 310 + 80)
            e.Graphics.DrawString("and is one of the Indigents in this barangay.", pfont, Brushes.Black, leftmargin + 20, topmargin + 350 + 80)

            e.Graphics.DrawString("This  CERTIFICATION  is  being  issued  upon  the  request  of  the", pfont, Brushes.Black, leftmargin + 100, topmargin + 400 + 80)
            e.Graphics.DrawString("above-named person for whatever legal purpose it may serve.", pfont, Brushes.Black, leftmargin + 20, topmargin + 440 + 80)

            e.Graphics.DrawString("Issued  this " + dateString + "at  Barangay  403,  City", pfont, Brushes.Black, leftmargin + 100, topmargin + 500 + 80)
            e.Graphics.DrawString("of Manila, NCR, Philippines.", pfont, Brushes.Black, leftmargin + 20, topmargin + 540 + 80)

            e.Graphics.DrawString("Bernard Gresola", sfont, Brushes.Black, leftmargin + 515, topmargin + 610 + 80)
            e.Graphics.DrawString("_______________", pfont, Brushes.Black, leftmargin + 515, topmargin + 620 + 80)
            e.Graphics.DrawString(" Barangay Captain", pfont, Brushes.Black, leftmargin + 515, topmargin + 650 + 80)
        Next
    End Sub
#End Region
End Class