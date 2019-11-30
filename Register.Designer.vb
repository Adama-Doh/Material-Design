<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.LoginBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PasswordTxtB = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UsernameTxtB = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Material_Desgin.My.Resources.Resources.user_profile_brown
        Me.PictureBox1.Location = New System.Drawing.Point(46, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(319, 297)
        Me.MaterialDivider1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(272, 1)
        Me.MaterialDivider1.TabIndex = 13
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'LoginBtn
        '
        Me.LoginBtn.Depth = 0
        Me.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LoginBtn.Location = New System.Drawing.Point(335, 242)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Primary = True
        Me.LoginBtn.Size = New System.Drawing.Size(239, 34)
        Me.LoginBtn.TabIndex = 11
        Me.LoginBtn.Text = "Register"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'PasswordTxtB
        '
        Me.PasswordTxtB.Depth = 0
        Me.PasswordTxtB.Hint = "Password"
        Me.PasswordTxtB.Location = New System.Drawing.Point(335, 154)
        Me.PasswordTxtB.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTxtB.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTxtB.Name = "PasswordTxtB"
        Me.PasswordTxtB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtB.SelectedText = ""
        Me.PasswordTxtB.SelectionLength = 0
        Me.PasswordTxtB.SelectionStart = 0
        Me.PasswordTxtB.Size = New System.Drawing.Size(239, 23)
        Me.PasswordTxtB.TabIndex = 10
        Me.PasswordTxtB.UseSystemPasswordChar = False
        '
        'UsernameTxtB
        '
        Me.UsernameTxtB.Depth = 0
        Me.UsernameTxtB.Hint = "Username"
        Me.UsernameTxtB.Location = New System.Drawing.Point(335, 106)
        Me.UsernameTxtB.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTxtB.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameTxtB.Name = "UsernameTxtB"
        Me.UsernameTxtB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxtB.SelectedText = ""
        Me.UsernameTxtB.SelectionLength = 0
        Me.UsernameTxtB.SelectionStart = 0
        Me.UsernameTxtB.Size = New System.Drawing.Size(239, 23)
        Me.UsernameTxtB.TabIndex = 9
        Me.UsernameTxtB.UseSystemPasswordChar = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 389)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTxtB)
        Me.Controls.Add(Me.UsernameTxtB)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents LoginBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PasswordTxtB As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UsernameTxtB As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
