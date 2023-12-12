<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblChose = New System.Windows.Forms.Label()
        Me.lblYours = New System.Windows.Forms.Label()
        Me.lblWay = New System.Windows.Forms.Label()
        Me.picCars = New System.Windows.Forms.PictureBox()
        Me.picParts = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChose
        '
        Me.lblChose.AutoSize = True
        Me.lblChose.BackColor = System.Drawing.Color.MistyRose
        Me.lblChose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChose.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChose.Location = New System.Drawing.Point(351, 130)
        Me.lblChose.Name = "lblChose"
        Me.lblChose.Size = New System.Drawing.Size(21, 97)
        Me.lblChose.TabIndex = 8
        Me.lblChose.Text = "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "h" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e"
        '
        'lblYours
        '
        Me.lblYours.AutoSize = True
        Me.lblYours.BackColor = System.Drawing.Color.MistyRose
        Me.lblYours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYours.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYours.Location = New System.Drawing.Point(352, 243)
        Me.lblYours.Name = "lblYours"
        Me.lblYours.Size = New System.Drawing.Size(21, 78)
        Me.lblYours.TabIndex = 9
        Me.lblYours.Text = "y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r"
        '
        'lblWay
        '
        Me.lblWay.AutoSize = True
        Me.lblWay.BackColor = System.Drawing.Color.MistyRose
        Me.lblWay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWay.Location = New System.Drawing.Point(350, 336)
        Me.lblWay.Name = "lblWay"
        Me.lblWay.Size = New System.Drawing.Size(25, 59)
        Me.lblWay.TabIndex = 10
        Me.lblWay.Text = "w" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y"
        '
        'picCars
        '
        Me.picCars.BackgroundImage = Global.Cars.My.Resources.Resources.rightCarPics_Edit_
        Me.picCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCars.Dock = System.Windows.Forms.DockStyle.Right
        Me.picCars.Location = New System.Drawing.Point(362, 0)
        Me.picCars.Name = "picCars"
        Me.picCars.Size = New System.Drawing.Size(362, 541)
        Me.picCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCars.TabIndex = 4
        Me.picCars.TabStop = False
        '
        'picParts
        '
        Me.picParts.BackgroundImage = Global.Cars.My.Resources.Resources.leftPartsPic_Edit_
        Me.picParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picParts.Dock = System.Windows.Forms.DockStyle.Left
        Me.picParts.Location = New System.Drawing.Point(0, 0)
        Me.picParts.Name = "picParts"
        Me.picParts.Size = New System.Drawing.Size(362, 541)
        Me.picParts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picParts.TabIndex = 2
        Me.picParts.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.AutoSize = True
        Me.btnLogout.BackColor = System.Drawing.Color.Crimson
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(647, 1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 28)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWay)
        Me.Controls.Add(Me.lblYours)
        Me.Controls.Add(Me.lblChose)
        Me.Controls.Add(Me.picCars)
        Me.Controls.Add(Me.picParts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCars As System.Windows.Forms.PictureBox
    Friend WithEvents lblChose As System.Windows.Forms.Label
    Friend WithEvents lblYours As System.Windows.Forms.Label
    Friend WithEvents lblWay As System.Windows.Forms.Label
    Friend WithEvents picParts As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
