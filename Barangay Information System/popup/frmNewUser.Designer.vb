<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdouser = New System.Windows.Forms.RadioButton()
        Me.rdoadmin = New System.Windows.Forms.RadioButton()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSuffix = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.linkClose = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBIS = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.gbUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.gbUser)
        Me.Panel2.Controls.Add(Me.linkClose)
        Me.Panel2.Controls.Add(Me.btnCreate)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 561)
        Me.Panel2.TabIndex = 80
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.rdoFemale)
        Me.gbUser.Controls.Add(Me.rdoMale)
        Me.gbUser.Controls.Add(Me.rdouser)
        Me.gbUser.Controls.Add(Me.rdoadmin)
        Me.gbUser.Controls.Add(Me.cmbPosition)
        Me.gbUser.Controls.Add(Me.txtPassword)
        Me.gbUser.Controls.Add(Me.txtUsername)
        Me.gbUser.Controls.Add(Me.txtAddress)
        Me.gbUser.Controls.Add(Me.txtContactNum)
        Me.gbUser.Controls.Add(Me.dtpBirthdate)
        Me.gbUser.Controls.Add(Me.Label12)
        Me.gbUser.Controls.Add(Me.Label1)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Controls.Add(Me.Label8)
        Me.gbUser.Controls.Add(Me.Label10)
        Me.gbUser.Controls.Add(Me.Label3)
        Me.gbUser.Controls.Add(Me.Label11)
        Me.gbUser.Controls.Add(Me.txtMiddleName)
        Me.gbUser.Controls.Add(Me.txtLastName)
        Me.gbUser.Controls.Add(Me.txtFirstName)
        Me.gbUser.Controls.Add(Me.Label4)
        Me.gbUser.Controls.Add(Me.Label5)
        Me.gbUser.Controls.Add(Me.Label6)
        Me.gbUser.Controls.Add(Me.Label7)
        Me.gbUser.Controls.Add(Me.cmbSuffix)
        Me.gbUser.Controls.Add(Me.Label14)
        Me.gbUser.Location = New System.Drawing.Point(48, 83)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(377, 401)
        Me.gbUser.TabIndex = 66
        Me.gbUser.TabStop = False
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.ForeColor = System.Drawing.Color.White
        Me.rdoFemale.Location = New System.Drawing.Point(208, 145)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(74, 23)
        Me.rdoFemale.TabIndex = 111
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.ForeColor = System.Drawing.Color.White
        Me.rdoMale.Location = New System.Drawing.Point(142, 145)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(60, 23)
        Me.rdoMale.TabIndex = 110
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdouser
        '
        Me.rdouser.AutoSize = True
        Me.rdouser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdouser.ForeColor = System.Drawing.Color.White
        Me.rdouser.Location = New System.Drawing.Point(216, 364)
        Me.rdouser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdouser.Name = "rdouser"
        Me.rdouser.Size = New System.Drawing.Size(57, 23)
        Me.rdouser.TabIndex = 108
        Me.rdouser.TabStop = True
        Me.rdouser.Text = "User"
        Me.rdouser.UseVisualStyleBackColor = True
        '
        'rdoadmin
        '
        Me.rdoadmin.AutoSize = True
        Me.rdoadmin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoadmin.ForeColor = System.Drawing.Color.White
        Me.rdoadmin.Location = New System.Drawing.Point(141, 364)
        Me.rdoadmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoadmin.Name = "rdoadmin"
        Me.rdoadmin.Size = New System.Drawing.Size(68, 23)
        Me.rdoadmin.TabIndex = 109
        Me.rdoadmin.TabStop = True
        Me.rdoadmin.Text = "Admin"
        Me.rdoadmin.UseVisualStyleBackColor = True
        '
        'cmbPosition
        '
        Me.cmbPosition.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Chairman", "Secretary", "Kagawad"})
        Me.cmbPosition.Location = New System.Drawing.Point(139, 330)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(221, 27)
        Me.cmbPosition.TabIndex = 107
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(139, 299)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(221, 27)
        Me.txtPassword.TabIndex = 106
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(139, 268)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(221, 27)
        Me.txtUsername.TabIndex = 105
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(139, 237)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(221, 27)
        Me.txtAddress.TabIndex = 104
        '
        'txtContactNum
        '
        Me.txtContactNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.Location = New System.Drawing.Point(139, 206)
        Me.txtContactNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(221, 27)
        Me.txtContactNum.TabIndex = 103
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CustomFormat = "yyyy-MM-dd"
        Me.dtpBirthdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(139, 175)
        Me.dtpBirthdate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(221, 27)
        Me.dtpBirthdate.TabIndex = 102
        Me.dtpBirthdate.Value = New Date(2021, 10, 16, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(13, 362)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 25)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "User Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 269)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 331)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 25)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Position"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 207)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Contact No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 238)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 25)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(139, 82)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(221, 27)
        Me.txtMiddleName.TabIndex = 33
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(139, 20)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(221, 27)
        Me.txtLastName.TabIndex = 31
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(139, 51)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(221, 27)
        Me.txtFirstName.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "First Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Middle Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Birthdate"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 25)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Sex"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSuffix
        '
        Me.cmbSuffix.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuffix.FormattingEnabled = True
        Me.cmbSuffix.Items.AddRange(New Object() {"N/A", "Jr.", "Sr.", "I", "II", "III", "IV", "V", "Others"})
        Me.cmbSuffix.Location = New System.Drawing.Point(139, 113)
        Me.cmbSuffix.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(221, 27)
        Me.cmbSuffix.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(13, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 25)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Suffix"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkClose
        '
        Me.linkClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.linkClose.AutoSize = True
        Me.linkClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkClose.LinkColor = System.Drawing.Color.Silver
        Me.linkClose.Location = New System.Drawing.Point(209, 532)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(36, 15)
        Me.linkClose.TabIndex = 62
        Me.linkClose.TabStop = True
        Me.linkClose.Text = "Close"
        '
        'btnCreate
        '
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(135, 490)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(186, 39)
        Me.btnCreate.TabIndex = 55
        Me.btnCreate.Text = "  Create Account"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUserId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBIS)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 77)
        Me.Panel1.TabIndex = 81
        '
        'lblUserId
        '
        Me.lblUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(349, 51)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(136, 26)
        Me.lblUserId.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Please fill in this form to create an account."
        '
        'lblBIS
        '
        Me.lblBIS.AutoSize = True
        Me.lblBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBIS.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBIS.Location = New System.Drawing.Point(0, 8)
        Me.lblBIS.Name = "lblBIS"
        Me.lblBIS.Size = New System.Drawing.Size(379, 42)
        Me.lblBIS.TabIndex = 1
        Me.lblBIS.Text = "CREATE ACCOUNT FORM"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(512, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents linkClose As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbSuffix As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBIS As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContactNum As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents rdouser As System.Windows.Forms.RadioButton
    Friend WithEvents rdoadmin As System.Windows.Forms.RadioButton
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
End Class
