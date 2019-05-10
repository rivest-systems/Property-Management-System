<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.UnameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameTextBox2 = New System.Windows.Forms.TextBox()
        Me.IDNoTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ReligionBtn = New System.Windows.Forms.Button()
        Me.ChristianRadioButton = New System.Windows.Forms.RadioButton()
        Me.MuslimRadioButton = New System.Windows.Forms.RadioButton()
        Me.BuddhistRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton()
        Me.SpecifyOtherTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UnameLabel
        '
        Me.UnameLabel.AutoSize = True
        Me.UnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameLabel.Location = New System.Drawing.Point(21, 46)
        Me.UnameLabel.Name = "UnameLabel"
        Me.UnameLabel.Size = New System.Drawing.Size(49, 16)
        Me.UnameLabel.TabIndex = 0
        Me.UnameLabel.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'UsernameTextBox2
        '
        Me.UsernameTextBox2.Location = New System.Drawing.Point(126, 45)
        Me.UsernameTextBox2.Name = "UsernameTextBox2"
        Me.UsernameTextBox2.Size = New System.Drawing.Size(225, 20)
        Me.UsernameTextBox2.TabIndex = 4
        '
        'IDNoTextBox
        '
        Me.IDNoTextBox.Location = New System.Drawing.Point(127, 139)
        Me.IDNoTextBox.MaxLength = 8
        Me.IDNoTextBox.Name = "IDNoTextBox"
        Me.IDNoTextBox.Size = New System.Drawing.Size(225, 20)
        Me.IDNoTextBox.TabIndex = 5
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(127, 185)
        Me.PhoneNoTextBox.MaxLength = 10
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(225, 20)
        Me.PhoneNoTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(127, 225)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(225, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubmitBtn.Location = New System.Drawing.Point(278, 406)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(98, 27)
        Me.SubmitBtn.TabIndex = 8
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelBtn.Location = New System.Drawing.Point(97, 406)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(98, 27)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLabel.Location = New System.Drawing.Point(21, 267)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(59, 16)
        Me.GenderLabel.TabIndex = 10
        Me.GenderLabel.Text = "Gender"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(127, 259)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(139, 24)
        Me.GenderComboBox.TabIndex = 11
        Me.GenderComboBox.Text = "Select"
        '
        'ReligionBtn
        '
        Me.ReligionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReligionBtn.Location = New System.Drawing.Point(16, 300)
        Me.ReligionBtn.Name = "ReligionBtn"
        Me.ReligionBtn.Size = New System.Drawing.Size(81, 24)
        Me.ReligionBtn.TabIndex = 12
        Me.ReligionBtn.Text = "Religion"
        Me.ReligionBtn.UseVisualStyleBackColor = True
        '
        'ChristianRadioButton
        '
        Me.ChristianRadioButton.AutoSize = True
        Me.ChristianRadioButton.Location = New System.Drawing.Point(127, 304)
        Me.ChristianRadioButton.Name = "ChristianRadioButton"
        Me.ChristianRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.ChristianRadioButton.TabIndex = 13
        Me.ChristianRadioButton.TabStop = True
        Me.ChristianRadioButton.Text = "Christian"
        Me.ChristianRadioButton.UseVisualStyleBackColor = True
        '
        'MuslimRadioButton
        '
        Me.MuslimRadioButton.AutoSize = True
        Me.MuslimRadioButton.Location = New System.Drawing.Point(209, 304)
        Me.MuslimRadioButton.Name = "MuslimRadioButton"
        Me.MuslimRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.MuslimRadioButton.TabIndex = 14
        Me.MuslimRadioButton.TabStop = True
        Me.MuslimRadioButton.Text = "Muslim"
        Me.MuslimRadioButton.UseVisualStyleBackColor = True
        '
        'BuddhistRadioButton
        '
        Me.BuddhistRadioButton.AutoSize = True
        Me.BuddhistRadioButton.Location = New System.Drawing.Point(286, 304)
        Me.BuddhistRadioButton.Name = "BuddhistRadioButton"
        Me.BuddhistRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.BuddhistRadioButton.TabIndex = 15
        Me.BuddhistRadioButton.TabStop = True
        Me.BuddhistRadioButton.Text = "Buddhist"
        Me.BuddhistRadioButton.UseVisualStyleBackColor = True
        '
        'NoneRadioButton
        '
        Me.NoneRadioButton.AutoSize = True
        Me.NoneRadioButton.Location = New System.Drawing.Point(374, 304)
        Me.NoneRadioButton.Name = "NoneRadioButton"
        Me.NoneRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.NoneRadioButton.TabIndex = 16
        Me.NoneRadioButton.TabStop = True
        Me.NoneRadioButton.Text = "None"
        Me.NoneRadioButton.UseVisualStyleBackColor = True
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.AutoSize = True
        Me.OtherRadioButton.Location = New System.Drawing.Point(127, 346)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(93, 17)
        Me.OtherRadioButton.TabIndex = 17
        Me.OtherRadioButton.TabStop = True
        Me.OtherRadioButton.Text = "Other (specify)"
        Me.OtherRadioButton.UseVisualStyleBackColor = True
        '
        'SpecifyOtherTextBox
        '
        Me.SpecifyOtherTextBox.Location = New System.Drawing.Point(243, 343)
        Me.SpecifyOtherTextBox.Name = "SpecifyOtherTextBox"
        Me.SpecifyOtherTextBox.Size = New System.Drawing.Size(133, 20)
        Me.SpecifyOtherTextBox.TabIndex = 18
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(21, 98)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(76, 16)
        Me.PasswordLabel.TabIndex = 19
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.Location = New System.Drawing.Point(127, 94)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox1.Size = New System.Drawing.Size(224, 20)
        Me.PasswordTextBox1.TabIndex = 20
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(505, 445)
        Me.Controls.Add(Me.PasswordTextBox1)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.SpecifyOtherTextBox)
        Me.Controls.Add(Me.OtherRadioButton)
        Me.Controls.Add(Me.NoneRadioButton)
        Me.Controls.Add(Me.BuddhistRadioButton)
        Me.Controls.Add(Me.MuslimRadioButton)
        Me.Controls.Add(Me.ChristianRadioButton)
        Me.Controls.Add(Me.ReligionBtn)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PhoneNoTextBox)
        Me.Controls.Add(Me.IDNoTextBox)
        Me.Controls.Add(Me.UsernameTextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UnameLabel)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UnameLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents IDNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents GenderLabel As System.Windows.Forms.Label
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReligionBtn As System.Windows.Forms.Button
    Friend WithEvents ChristianRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MuslimRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BuddhistRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoneRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OtherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SpecifyOtherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
End Class
