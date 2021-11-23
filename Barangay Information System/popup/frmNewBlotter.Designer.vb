<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBlotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBlotter))
        Me.lblBIS = New System.Windows.Forms.Label()
        Me.linkClose = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtStatement = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIncident = New System.Windows.Forms.TextBox()
        Me.txtComName = New System.Windows.Forms.TextBox()
        Me.txtDefName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbBlotter = New System.Windows.Forms.GroupBox()
        Me.dtpIncidentTime = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbBlotter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBIS
        '
        resources.ApplyResources(Me.lblBIS, "lblBIS")
        Me.lblBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBIS.Name = "lblBIS"
        '
        'linkClose
        '
        Me.linkClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.linkClose, "linkClose")
        Me.linkClose.LinkColor = System.Drawing.Color.Silver
        Me.linkClose.Name = "linkClose"
        Me.linkClose.TabStop = True
        '
        'btnCreate
        '
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnCreate, "btnCreate")
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtStatement
        '
        resources.ApplyResources(Me.txtStatement, "txtStatement")
        Me.txtStatement.Name = "txtStatement"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBIS)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Name = "Label9"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'txtIncident
        '
        resources.ApplyResources(Me.txtIncident, "txtIncident")
        Me.txtIncident.Name = "txtIncident"
        '
        'txtComName
        '
        resources.ApplyResources(Me.txtComName, "txtComName")
        Me.txtComName.Name = "txtComName"
        '
        'txtDefName
        '
        resources.ApplyResources(Me.txtDefName, "txtDefName")
        Me.txtDefName.Name = "txtDefName"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'dtpIncidentDate
        '
        resources.ApplyResources(Me.dtpIncidentDate, "dtpIncidentDate")
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Value = New Date(2021, 10, 16, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Name = "Label14"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.gbBlotter)
        Me.Panel2.Controls.Add(Me.linkClose)
        Me.Panel2.Controls.Add(Me.btnCreate)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'gbBlotter
        '
        Me.gbBlotter.Controls.Add(Me.dtpIncidentTime)
        Me.gbBlotter.Controls.Add(Me.txtStatement)
        Me.gbBlotter.Controls.Add(Me.Label10)
        Me.gbBlotter.Controls.Add(Me.Label3)
        Me.gbBlotter.Controls.Add(Me.txtIncident)
        Me.gbBlotter.Controls.Add(Me.txtComName)
        Me.gbBlotter.Controls.Add(Me.txtDefName)
        Me.gbBlotter.Controls.Add(Me.Label4)
        Me.gbBlotter.Controls.Add(Me.Label5)
        Me.gbBlotter.Controls.Add(Me.dtpIncidentDate)
        Me.gbBlotter.Controls.Add(Me.Label7)
        Me.gbBlotter.Controls.Add(Me.Label14)
        resources.ApplyResources(Me.gbBlotter, "gbBlotter")
        Me.gbBlotter.Name = "gbBlotter"
        Me.gbBlotter.TabStop = False
        '
        'dtpIncidentTime
        '
        Me.dtpIncidentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        resources.ApplyResources(Me.dtpIncidentTime, "dtpIncidentTime")
        Me.dtpIncidentTime.Name = "dtpIncidentTime"
        '
        'NewBlotter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewBlotter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbBlotter.ResumeLayout(False)
        Me.gbBlotter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBIS As System.Windows.Forms.Label
    Friend WithEvents linkClose As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtStatement As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIncident As System.Windows.Forms.TextBox
    Friend WithEvents txtComName As System.Windows.Forms.TextBox
    Friend WithEvents txtDefName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpIncidentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpIncidentTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbBlotter As System.Windows.Forms.GroupBox
End Class
