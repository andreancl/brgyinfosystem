<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Blotter))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNewBlotter = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.dgvBlotterRecords = New System.Windows.Forms.DataGridView()
        Me.lblBRec = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewBlotter
        '
        Me.btnNewBlotter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewBlotter.FlatAppearance.BorderSize = 0
        Me.btnNewBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewBlotter.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBlotter.ForeColor = System.Drawing.Color.White
        Me.btnNewBlotter.Image = CType(resources.GetObject("btnNewBlotter.Image"), System.Drawing.Image)
        Me.btnNewBlotter.Location = New System.Drawing.Point(878, 0)
        Me.btnNewBlotter.Name = "btnNewBlotter"
        Me.btnNewBlotter.Size = New System.Drawing.Size(182, 48)
        Me.btnNewBlotter.TabIndex = 0
        Me.btnNewBlotter.Text = "  File New Blotter"
        Me.btnNewBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewBlotter.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtSearchBox)
        Me.Panel5.Controls.Add(Me.btnNewBlotter)
        Me.Panel5.Location = New System.Drawing.Point(22, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1060, 48)
        Me.Panel5.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Search"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(72, 10)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtSearchBox.TabIndex = 79
        '
        'dgvBlotterRecords
        '
        Me.dgvBlotterRecords.AllowUserToAddRows = False
        Me.dgvBlotterRecords.AllowUserToDeleteRows = False
        Me.dgvBlotterRecords.AllowUserToResizeColumns = False
        Me.dgvBlotterRecords.AllowUserToResizeRows = False
        Me.dgvBlotterRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBlotterRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBlotterRecords.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dgvBlotterRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBlotterRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBlotterRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBlotterRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBlotterRecords.Location = New System.Drawing.Point(22, 165)
        Me.dgvBlotterRecords.Name = "dgvBlotterRecords"
        Me.dgvBlotterRecords.RowHeadersVisible = False
        Me.dgvBlotterRecords.RowHeadersWidth = 60
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvBlotterRecords.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBlotterRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBlotterRecords.Size = New System.Drawing.Size(1060, 435)
        Me.dgvBlotterRecords.StandardTab = True
        Me.dgvBlotterRecords.TabIndex = 9
        '
        'lblBRec
        '
        Me.lblBRec.AutoSize = True
        Me.lblBRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRec.Location = New System.Drawing.Point(14, 9)
        Me.lblBRec.Name = "lblBRec"
        Me.lblBRec.Size = New System.Drawing.Size(307, 45)
        Me.lblBRec.TabIndex = 11
        Me.lblBRec.Text = "BLOTTER RECORDS"
        '
        'Blotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBRec)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgvBlotterRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Blotter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewBlotter As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgvBlotterRecords As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents lblBRec As System.Windows.Forms.Label
End Class
