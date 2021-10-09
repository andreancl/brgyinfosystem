<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnShowPass = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(592, 64)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(174, 180)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(530, 311)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(298, 39)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(530, 377)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(298, 39)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(605, 461)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(161, 41)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnShowPass
        '
        Me.btnShowPass.BackgroundImage = CType(resources.GetObject("btnShowPass.BackgroundImage"), System.Drawing.Image)
        Me.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowPass.Location = New System.Drawing.Point(791, 385)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(28, 23)
        Me.btnShowPass.TabIndex = 6
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 592)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogIn"
        Me.Text = "Log In"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents btnShowPass As System.Windows.Forms.Button

End Class
