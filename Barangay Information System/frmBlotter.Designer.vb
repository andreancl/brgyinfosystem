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
<<<<<<< Updated upstream
        Me.btnNewBlotter = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.dgvBlotterRecords = New System.Windows.Forms.DataGridView()
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
        Me.Panel5.Location = New System.Drawing.Point(22, 12)
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
=======
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblBIS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnBlotter = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnResident = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBlotterRecords = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.btnNewBlotter = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblBIS)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(256, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1107, 64)
        Me.Panel3.TabIndex = 7
        '
        'lblBIS
        '
        Me.lblBIS.AutoSize = True
        Me.lblBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBIS.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBIS.Location = New System.Drawing.Point(90, 1)
        Me.lblBIS.Name = "lblBIS"
        Me.lblBIS.Size = New System.Drawing.Size(724, 59)
        Me.lblBIS.TabIndex = 0
        Me.lblBIS.Text = "BARANGAY INFORMATION SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBackup)
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnBlotter)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnServices)
        Me.Panel1.Controls.Add(Me.btnResident)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 749)
        Me.Panel1.TabIndex = 6
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.Location = New System.Drawing.Point(0, 557)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Padding = New System.Windows.Forms.Padding(6, 0, 40, 0)
        Me.btnBackup.Size = New System.Drawing.Size(256, 50)
        Me.btnBackup.TabIndex = 16
        Me.btnBackup.Text = "   Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.Location = New System.Drawing.Point(0, 507)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.btnUser.Size = New System.Drawing.Size(256, 50)
        Me.btnUser.TabIndex = 15
        Me.btnUser.Text = "   User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnBlotter
        '
        Me.btnBlotter.BackColor = System.Drawing.Color.Transparent
        Me.btnBlotter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlotter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnBlotter.FlatAppearance.BorderSize = 0
        Me.btnBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlotter.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlotter.ForeColor = System.Drawing.Color.White
        Me.btnBlotter.Image = CType(resources.GetObject("btnBlotter.Image"), System.Drawing.Image)
        Me.btnBlotter.Location = New System.Drawing.Point(0, 457)
        Me.btnBlotter.Name = "btnBlotter"
        Me.btnBlotter.Padding = New System.Windows.Forms.Padding(6, 0, 40, 0)
        Me.btnBlotter.Size = New System.Drawing.Size(256, 50)
        Me.btnBlotter.TabIndex = 14
        Me.btnBlotter.Text = "   Blotter"
        Me.btnBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlotter.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.Location = New System.Drawing.Point(0, 699)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(256, 50)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "   Log Out"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.Transparent
        Me.btnServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServices.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.ForeColor = System.Drawing.Color.White
        Me.btnServices.Image = CType(resources.GetObject("btnServices.Image"), System.Drawing.Image)
        Me.btnServices.Location = New System.Drawing.Point(0, 407)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnServices.Size = New System.Drawing.Size(256, 50)
        Me.btnServices.TabIndex = 4
        Me.btnServices.Text = "   Services"
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnServices.UseVisualStyleBackColor = False
        '
        'btnResident
        '
        Me.btnResident.BackColor = System.Drawing.Color.Transparent
        Me.btnResident.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResident.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnResident.FlatAppearance.BorderSize = 0
        Me.btnResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResident.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResident.ForeColor = System.Drawing.Color.White
        Me.btnResident.Image = CType(resources.GetObject("btnResident.Image"), System.Drawing.Image)
        Me.btnResident.Location = New System.Drawing.Point(0, 357)
        Me.btnResident.Name = "btnResident"
        Me.btnResident.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnResident.Size = New System.Drawing.Size(256, 50)
        Me.btnResident.TabIndex = 3
        Me.btnResident.Text = "   Resident"
        Me.btnResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResident.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 307)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(256, 50)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 243)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ADMIN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 64)
        Me.Panel2.TabIndex = 0
>>>>>>> Stashed changes
        '
        'dgvBlotterRecords
        '
        Me.dgvBlotterRecords.AllowUserToAddRows = False
        Me.dgvBlotterRecords.AllowUserToDeleteRows = False
        Me.dgvBlotterRecords.AllowUserToResizeColumns = False
        Me.dgvBlotterRecords.AllowUserToResizeRows = False
<<<<<<< Updated upstream
        Me.dgvBlotterRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBlotterRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        Me.dgvBlotterRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBlotterRecords.Location = New System.Drawing.Point(22, 92)
        Me.dgvBlotterRecords.Name = "dgvBlotterRecords"
        Me.dgvBlotterRecords.RowHeadersVisible = False
        Me.dgvBlotterRecords.RowHeadersWidth = 60
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvBlotterRecords.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBlotterRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBlotterRecords.Size = New System.Drawing.Size(1060, 470)
        Me.dgvBlotterRecords.StandardTab = True
        Me.dgvBlotterRecords.TabIndex = 9
        '
=======
        Me.dgvBlotterRecords.Location = New System.Drawing.Point(296, 194)
        Me.dgvBlotterRecords.Name = "dgvBlotterRecords"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvBlotterRecords.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBlotterRecords.Size = New System.Drawing.Size(1025, 507)
        Me.dgvBlotterRecords.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtSearchBox)
        Me.Panel5.Controls.Add(Me.btnNewBlotter)
        Me.Panel5.Location = New System.Drawing.Point(295, 91)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1026, 48)
        Me.Panel5.TabIndex = 10
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(19, 10)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(281, 27)
        Me.txtSearchBox.TabIndex = 77
        Me.txtSearchBox.Text = "Search"
        '
        'btnNewBlotter
        '
        Me.btnNewBlotter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewBlotter.FlatAppearance.BorderSize = 0
        Me.btnNewBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewBlotter.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBlotter.ForeColor = System.Drawing.Color.White
        Me.btnNewBlotter.Image = CType(resources.GetObject("btnNewBlotter.Image"), System.Drawing.Image)
        Me.btnNewBlotter.Location = New System.Drawing.Point(830, 0)
        Me.btnNewBlotter.Name = "btnNewBlotter"
        Me.btnNewBlotter.Size = New System.Drawing.Size(196, 48)
        Me.btnNewBlotter.TabIndex = 0
        Me.btnNewBlotter.Text = "  File New Blotter"
        Me.btnNewBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewBlotter.UseVisualStyleBackColor = True
        '
>>>>>>> Stashed changes
        'Blotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(1106, 612)
        Me.ControlBox = False
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

    End Sub
    Friend WithEvents btnNewBlotter As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgvBlotterRecords As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
=======
        Me.ClientSize = New System.Drawing.Size(1363, 749)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgvBlotterRecords)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Blotter"
        Me.Text = "frmServices"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBlotterRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblBIS As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnServices As System.Windows.Forms.Button
    Friend WithEvents btnResident As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnBlotter As System.Windows.Forms.Button
    Friend WithEvents dgvBlotterRecords As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNewBlotter As System.Windows.Forms.Button
>>>>>>> Stashed changes
End Class
