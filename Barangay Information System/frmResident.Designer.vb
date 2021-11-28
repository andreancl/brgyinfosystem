<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resident
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resident))
        Me.dgvResidentRecords = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.btnNewResident = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsCertRes = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsBrgyClearance = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCertIndig = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.lblResRec = New System.Windows.Forms.Label()
        CType(Me.dgvResidentRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResidentRecords
        '
        Me.dgvResidentRecords.AllowUserToAddRows = False
        Me.dgvResidentRecords.AllowUserToDeleteRows = False
        Me.dgvResidentRecords.AllowUserToResizeColumns = False
        Me.dgvResidentRecords.AllowUserToResizeRows = False
        Me.dgvResidentRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResidentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResidentRecords.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResidentRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResidentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResidentRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResidentRecords.Location = New System.Drawing.Point(22, 165)
        Me.dgvResidentRecords.Name = "dgvResidentRecords"
        Me.dgvResidentRecords.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvResidentRecords.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResidentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResidentRecords.Size = New System.Drawing.Size(1060, 435)
        Me.dgvResidentRecords.StandardTab = True
        Me.dgvResidentRecords.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtSearchBox)
        Me.Panel5.Controls.Add(Me.btnNewResident)
        Me.Panel5.Location = New System.Drawing.Point(22, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1060, 48)
        Me.Panel5.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Search"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(72, 10)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtSearchBox.TabIndex = 77
        '
        'btnNewResident
        '
        Me.btnNewResident.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewResident.FlatAppearance.BorderSize = 0
        Me.btnNewResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewResident.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewResident.ForeColor = System.Drawing.Color.White
        Me.btnNewResident.Image = CType(resources.GetObject("btnNewResident.Image"), System.Drawing.Image)
        Me.btnNewResident.Location = New System.Drawing.Point(878, 0)
        Me.btnNewResident.Name = "btnNewResident"
        Me.btnNewResident.Size = New System.Drawing.Size(182, 48)
        Me.btnNewResident.TabIndex = 0
        Me.btnNewResident.Text = "   New Resident"
        Me.btnNewResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewResident.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.cmsCertRes, Me.cmsBrgyClearance, Me.cmsCertIndig})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(199, 120)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'cmsCertRes
        '
        Me.cmsCertRes.Name = "cmsCertRes"
        Me.cmsCertRes.Size = New System.Drawing.Size(198, 22)
        Me.cmsCertRes.Text = "Certificate of Residency"
        '
        'cmsBrgyClearance
        '
        Me.cmsBrgyClearance.Name = "cmsBrgyClearance"
        Me.cmsBrgyClearance.Size = New System.Drawing.Size(198, 22)
        Me.cmsBrgyClearance.Text = "Barangay Clearance"
        '
        'cmsCertIndig
        '
        Me.cmsCertIndig.Name = "cmsCertIndig"
        Me.cmsCertIndig.Size = New System.Drawing.Size(198, 22)
        Me.cmsCertIndig.Text = "Certificate of Indigency"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument2
        '
        '
        'PrintDocument3
        '
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(14, 9)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(321, 45)
        Me.lblResRec.TabIndex = 10
        Me.lblResRec.Text = "RESIDENT RECORDS"
        '
        'Resident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1106, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblResRec)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgvResidentRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Resident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvResidentRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResidentRecords As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNewResident As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsCertRes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmsBrgyClearance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCertIndig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblResRec As System.Windows.Forms.Label
End Class
