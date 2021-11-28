<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbBr = New System.Windows.Forms.GroupBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBIS = New System.Windows.Forms.Label()
        Me.linkClose = New Guna.UI.WinForms.GunaLinkLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.gbBr.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gbBr
        '
        Me.gbBr.Controls.Add(Me.btnRestore)
        Me.gbBr.Controls.Add(Me.btnBackup)
        Me.gbBr.Location = New System.Drawing.Point(25, 97)
        Me.gbBr.Name = "gbBr"
        Me.gbBr.Size = New System.Drawing.Size(414, 215)
        Me.gbBr.TabIndex = 67
        Me.gbBr.TabStop = False
        '
        'btnRestore
        '
        Me.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Location = New System.Drawing.Point(113, 121)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(189, 47)
        Me.btnRestore.TabIndex = 106
        Me.btnRestore.Text = "RESTORE"
        Me.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Location = New System.Drawing.Point(113, 44)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(189, 47)
        Me.btnBackup.TabIndex = 105
        Me.btnBackup.Text = "BACKUP"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.gbBr)
        Me.Panel2.Controls.Add(Me.linkClose)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 364)
        Me.Panel2.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblBIS)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 77)
        Me.Panel1.TabIndex = 83
        '
        'lblBIS
        '
        Me.lblBIS.AutoSize = True
        Me.lblBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBIS.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblBIS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBIS.Location = New System.Drawing.Point(3, 17)
        Me.lblBIS.Name = "lblBIS"
        Me.lblBIS.Size = New System.Drawing.Size(311, 42)
        Me.lblBIS.TabIndex = 1
        Me.lblBIS.Text = "BACKUP && RESTORE"
        '
        'linkClose
        '
        Me.linkClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.linkClose.AutoSize = True
        Me.linkClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkClose.LinkColor = System.Drawing.Color.Silver
        Me.linkClose.Location = New System.Drawing.Point(208, 329)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(36, 15)
        Me.linkClose.TabIndex = 62
        Me.linkClose.TabStop = True
        Me.linkClose.Text = "Close"
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Backup"
        Me.gbBr.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbBr As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblBIS As System.Windows.Forms.Label
    Friend WithEvents linkClose As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
