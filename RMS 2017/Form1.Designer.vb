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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswdLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswdTextBox = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.HaveAccountLabel = New System.Windows.Forms.Label()
        Me.RegisterLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AdminBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(35, 82)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(91, 20)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'PasswdLabel
        '
        Me.PasswdLabel.AutoSize = True
        Me.PasswdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswdLabel.Location = New System.Drawing.Point(35, 134)
        Me.PasswdLabel.Name = "PasswdLabel"
        Me.PasswdLabel.Size = New System.Drawing.Size(86, 20)
        Me.PasswdLabel.TabIndex = 1
        Me.PasswdLabel.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(187, 82)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(195, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswdTextBox
        '
        Me.PasswdTextBox.Location = New System.Drawing.Point(187, 134)
        Me.PasswdTextBox.Name = "PasswdTextBox"
        Me.PasswdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswdTextBox.Size = New System.Drawing.Size(195, 20)
        Me.PasswdTextBox.TabIndex = 3
        '
        'LoginBtn
        '
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginBtn.Location = New System.Drawing.Point(288, 226)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(135, 31)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'HaveAccountLabel
        '
        Me.HaveAccountLabel.AutoSize = True
        Me.HaveAccountLabel.Location = New System.Drawing.Point(41, 325)
        Me.HaveAccountLabel.Name = "HaveAccountLabel"
        Me.HaveAccountLabel.Size = New System.Drawing.Size(96, 13)
        Me.HaveAccountLabel.TabIndex = 5
        Me.HaveAccountLabel.Text = "Have an account?"
        '
        'RegisterLinkLabel
        '
        Me.RegisterLinkLabel.AutoSize = True
        Me.RegisterLinkLabel.Location = New System.Drawing.Point(143, 325)
        Me.RegisterLinkLabel.Name = "RegisterLinkLabel"
        Me.RegisterLinkLabel.Size = New System.Drawing.Size(46, 13)
        Me.RegisterLinkLabel.TabIndex = 6
        Me.RegisterLinkLabel.TabStop = True
        Me.RegisterLinkLabel.Text = "Register"
        '
        'AdminBtn
        '
        Me.AdminBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminBtn.Location = New System.Drawing.Point(125, 226)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(135, 31)
        Me.AdminBtn.TabIndex = 7
        Me.AdminBtn.Text = "Admin"
        Me.AdminBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 456)
        Me.Controls.Add(Me.AdminBtn)
        Me.Controls.Add(Me.RegisterLinkLabel)
        Me.Controls.Add(Me.HaveAccountLabel)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswdTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswdLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswdLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents HaveAccountLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AdminBtn As System.Windows.Forms.Button

End Class
