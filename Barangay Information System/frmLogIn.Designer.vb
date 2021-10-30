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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.BunifuMaterialTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btnLogIn = New Guna.UI.WinForms.GunaButton()
        Me.btnx = New Guna.UI.WinForms.GunaLabel()
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuMaterialTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.cbxPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.txtUserName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.L4 = New Guna.UI.WinForms.GunaLabel()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.p3.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.anima1.DefaultAnimation = Animation1
        '
        'BunifuMaterialTextbox5
        '
        Me.BunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox5, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.HintText = "Re-Enter Password"
        Me.BunifuMaterialTextbox5.isPassword = False
        Me.BunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.LineThickness = 3
        Me.BunifuMaterialTextbox5.Location = New System.Drawing.Point(34, 201)
        Me.BunifuMaterialTextbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox5.Name = "BunifuMaterialTextbox5"
        Me.BunifuMaterialTextbox5.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox5.TabIndex = 5
        Me.BunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaCheckBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.anima1.SetDecoration(Me.GunaCheckBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox2.Location = New System.Drawing.Point(34, 252)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox2.TabIndex = 4
        Me.GunaCheckBox2.Text = "Show Password"
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(34, 396)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(252, 42)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Text = "Save"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox3, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.HintText = "Password"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(34, 143)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox3.TabIndex = 1
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'linkaccnt
        '
        Me.linkaccnt.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.linkaccnt.AutoSize = True
        Me.anima1.SetDecoration(Me.linkaccnt, Guna.UI.Animation.DecorationType.None)
        Me.linkaccnt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkaccnt.LinkColor = System.Drawing.Color.Silver
        Me.linkaccnt.Location = New System.Drawing.Point(118, 423)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(95, 15)
        Me.linkaccnt.TabIndex = 3
        Me.linkaccnt.TabStop = True
        Me.linkaccnt.Text = "Forgot Password"
        '
        'btnLogIn
        '
        Me.btnLogIn.Animated = True
        Me.btnLogIn.AnimationHoverSpeed = 0.07!
        Me.btnLogIn.AnimationSpeed = 0.03!
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnLogIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnLogIn.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btnLogIn, Guna.UI.Animation.DecorationType.None)
        Me.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogIn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Image = Nothing
        Me.btnLogIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogIn.Location = New System.Drawing.Point(41, 329)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogIn.OnHoverImage = Nothing
        Me.btnLogIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogIn.Size = New System.Drawing.Size(252, 42)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Sign in"
        Me.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnx
        '
        Me.btnx.AutoSize = True
        Me.anima1.SetDecoration(Me.btnx, Guna.UI.Animation.DecorationType.None)
        Me.btnx.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnx.ForeColor = System.Drawing.Color.Silver
        Me.btnx.Location = New System.Drawing.Point(307, 3)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(18, 20)
        Me.btnx.TabIndex = 6
        Me.btnx.Text = "X"
        '
        'p3
        '
        Me.p3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.p3.Controls.Add(Me.btnx)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox5)
        Me.p3.Controls.Add(Me.GunaCheckBox2)
        Me.p3.Controls.Add(Me.GunaButton2)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox4)
        Me.anima1.SetDecoration(Me.p3, Guna.UI.Animation.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(507, 130)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(327, 488)
        Me.p3.TabIndex = 5
        Me.p3.Visible = False
        '
        'BunifuMaterialTextbox4
        '
        Me.BunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox4, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.HintText = "Username"
        Me.BunifuMaterialTextbox4.isPassword = False
        Me.BunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.LineThickness = 3
        Me.BunifuMaterialTextbox4.Location = New System.Drawing.Point(34, 91)
        Me.BunifuMaterialTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox4.Name = "BunifuMaterialTextbox4"
        Me.BunifuMaterialTextbox4.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox4.TabIndex = 0
        Me.BunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtPassword, Guna.UI.Animation.DecorationType.None)
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.HintForeColor = System.Drawing.Color.Silver
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtPassword.LineThickness = 4
        Me.txtPassword.Location = New System.Drawing.Point(36, 132)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(220, 39)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.p2.Controls.Add(Me.cbxPassword)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.btnLogIn)
        Me.p2.Controls.Add(Me.txtPassword)
        Me.p2.Controls.Add(Me.txtUserName)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(508, 130)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(327, 488)
        Me.p2.TabIndex = 4
        Me.p2.Visible = False
        '
        'cbxPassword
        '
        Me.cbxPassword.BaseColor = System.Drawing.Color.White
        Me.cbxPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbxPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbxPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.anima1.SetDecoration(Me.cbxPassword, Guna.UI.Animation.DecorationType.None)
        Me.cbxPassword.FillColor = System.Drawing.Color.White
        Me.cbxPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPassword.ForeColor = System.Drawing.Color.Silver
        Me.cbxPassword.Location = New System.Drawing.Point(36, 181)
        Me.cbxPassword.Name = "cbxPassword"
        Me.cbxPassword.Size = New System.Drawing.Size(115, 20)
        Me.cbxPassword.TabIndex = 4
        Me.cbxPassword.Text = "Show Password"
        '
        'txtUserName
        '
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtUserName, Guna.UI.Animation.DecorationType.None)
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.White
        Me.txtUserName.HintForeColor = System.Drawing.Color.Silver
        Me.txtUserName.HintText = "Username"
        Me.txtUserName.isPassword = False
        Me.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtUserName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUserName.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtUserName.LineThickness = 4
        Me.txtUserName.Location = New System.Drawing.Point(36, 76)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(220, 39)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.anima1.SetDecoration(Me.l2, Guna.UI.Animation.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(149, 181)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(151, 36)
        Me.l2.TabIndex = 2
        Me.l2.Text = "BARANGAY"
        Me.l2.Visible = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.anima1.SetDecoration(Me.l1, Guna.UI.Animation.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Calibri", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(3, 179)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(154, 106)
        Me.l1.TabIndex = 0
        Me.l1.Text = "GROUP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12"
        Me.l1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l1.Visible = False
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.p1.Controls.Add(Me.L4)
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.l3)
        Me.p1.Controls.Add(Me.l1)
        Me.anima1.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(167, 130)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(338, 488)
        Me.p1.TabIndex = 3
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.anima1.SetDecoration(Me.L4, Guna.UI.Animation.DecorationType.None)
        Me.L4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.ForeColor = System.Drawing.Color.White
        Me.L4.Location = New System.Drawing.Point(149, 246)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(110, 36)
        Me.L4.TabIndex = 3
        Me.L4.Text = "SYSTEM"
        Me.L4.Visible = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.anima1.SetDecoration(Me.l3, Guna.UI.Animation.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(149, 213)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(193, 36)
        Me.l3.TabIndex = 1
        Me.l3.Text = "INFORMATION"
        Me.l3.Visible = False
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 749)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p3)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents BunifuMaterialTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents btnLogIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnx As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents BunifuMaterialTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtUserName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents L4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbxPassword As Guna.UI.WinForms.GunaCheckBox

End Class
