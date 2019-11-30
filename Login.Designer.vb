<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UsernameTxtB = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PasswordTxtB = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LoginBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameTxtB
        '
        Me.UsernameTxtB.Depth = 0
        Me.UsernameTxtB.Hint = "Username"
        Me.UsernameTxtB.Location = New System.Drawing.Point(341, 107)
        Me.UsernameTxtB.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTxtB.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameTxtB.Name = "UsernameTxtB"
        Me.UsernameTxtB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxtB.SelectedText = ""
        Me.UsernameTxtB.SelectionLength = 0
        Me.UsernameTxtB.SelectionStart = 0
        Me.UsernameTxtB.Size = New System.Drawing.Size(239, 23)
        Me.UsernameTxtB.TabIndex = 0
        Me.UsernameTxtB.UseSystemPasswordChar = False
        '
        'PasswordTxtB
        '
        Me.PasswordTxtB.Depth = 0
        Me.PasswordTxtB.Hint = "Password"
        Me.PasswordTxtB.Location = New System.Drawing.Point(341, 155)
        Me.PasswordTxtB.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTxtB.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTxtB.Name = "PasswordTxtB"
        Me.PasswordTxtB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtB.SelectedText = ""
        Me.PasswordTxtB.SelectionLength = 0
        Me.PasswordTxtB.SelectionStart = 0
        Me.PasswordTxtB.Size = New System.Drawing.Size(239, 23)
        Me.PasswordTxtB.TabIndex = 1
        Me.PasswordTxtB.UseSystemPasswordChar = False
        '
        'LoginBtn
        '
        Me.LoginBtn.Depth = 0
        Me.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LoginBtn.Location = New System.Drawing.Point(341, 243)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Primary = True
        Me.LoginBtn.Size = New System.Drawing.Size(239, 34)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(341, 196)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(142, 30)
        Me.MaterialCheckBox1.TabIndex = 4
        Me.MaterialCheckBox1.Text = "Remember details"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(325, 298)
        Me.MaterialDivider1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(272, 1)
        Me.MaterialDivider1.TabIndex = 5
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(338, 319)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(151, 18)
        Me.MaterialLabel1.TabIndex = 6
        Me.MaterialLabel1.Text = "Forgotten Password?"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(517, 319)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(63, 18)
        Me.MaterialLabel2.TabIndex = 7
        Me.MaterialLabel2.Text = "Register"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Material_Desgin.My.Resources.Resources.user_profile_brown
        Me.PictureBox1.Location = New System.Drawing.Point(52, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(625, 389)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTxtB)
        Me.Controls.Add(Me.UsernameTxtB)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "W E L C O M E"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTxtB As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LoginBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PasswordTxtB As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
