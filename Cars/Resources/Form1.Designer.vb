<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.lblDown = New System.Windows.Forms.Label()
        Me.checkBoxShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUserName.Location = New System.Drawing.Point(16, 94)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 13)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "User Name :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPassword.Location = New System.Drawing.Point(20, 129)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password  :"
        '
        'txtUserName
        '
        Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserName.Location = New System.Drawing.Point(96, 91)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(356, 20)
        Me.txtUserName.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtUserName, "Enter like Admin or Employee")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(96, 126)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(221, 20)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(205, 185)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(149, 29)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInfo.BackColor = System.Drawing.Color.White
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.ForeColor = System.Drawing.Color.Firebrick
        Me.btnInfo.Location = New System.Drawing.Point(431, 9)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(21, 23)
        Me.btnInfo.TabIndex = 7
        Me.btnInfo.Text = "?"
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Info")
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.Tag = ""
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.DarkCyan
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(377, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblUp
        '
        Me.lblUp.AutoSize = True
        Me.lblUp.BackColor = System.Drawing.Color.Transparent
        Me.lblUp.Font = New System.Drawing.Font("Tahoma", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUp.Location = New System.Drawing.Point(115, 8)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(211, 58)
        Me.lblUp.TabIndex = 8
        Me.lblUp.Text = "ZR-cars"
        '
        'lblDown
        '
        Me.lblDown.AutoSize = True
        Me.lblDown.BackColor = System.Drawing.Color.Transparent
        Me.lblDown.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDown.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDown.Location = New System.Drawing.Point(163, 59)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(112, 13)
        Me.lblDown.TabIndex = 9
        Me.lblDown.Text = "Drive your dreams"
        '
        'checkBoxShowPassword
        '
        Me.checkBoxShowPassword.AutoSize = True
        Me.checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.checkBoxShowPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxShowPassword.ForeColor = System.Drawing.Color.DarkCyan
        Me.checkBoxShowPassword.Location = New System.Drawing.Point(323, 126)
        Me.checkBoxShowPassword.Name = "checkBoxShowPassword"
        Me.checkBoxShowPassword.Size = New System.Drawing.Size(129, 20)
        Me.checkBoxShowPassword.TabIndex = 10
        Me.checkBoxShowPassword.Text = "Show password"
        Me.checkBoxShowPassword.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cars.My.Resources.Resources.samuele_errico_piccarini_YSJSs78rw10_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.checkBoxShowPassword)
        Me.Controls.Add(Me.lblDown)
        Me.Controls.Add(Me.lblUp)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnExit)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblUp As System.Windows.Forms.Label
    Friend WithEvents lblDown As System.Windows.Forms.Label
    Friend WithEvents checkBoxShowPassword As System.Windows.Forms.CheckBox

End Class
