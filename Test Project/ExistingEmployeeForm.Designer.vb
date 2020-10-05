<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingEmployeeForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.comboRole = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.leaveDate = New System.Windows.Forms.DateTimePicker()
        Me.HireDateLabel = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(147, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(109, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(278, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(278, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "*"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(150, 269)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 97
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(64, 269)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 96
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Checked = True
        Me.ActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckBox.Enabled = False
        Me.ActiveCheckBox.Location = New System.Drawing.Point(91, 212)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 93
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = True
        Me.ActiveLabel.Location = New System.Drawing.Point(46, 213)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(40, 13)
        Me.ActiveLabel.TabIndex = 91
        Me.ActiveLabel.Text = "Active:"
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Location = New System.Drawing.Point(50, 188)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(35, 13)
        Me.RoleLabel.TabIndex = 90
        Me.RoleLabel.Text = "Role :"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(51, 110)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 89
        Me.EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(92, 107)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(180, 20)
        Me.EmailTextBox.TabIndex = 88
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(92, 80)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.LastNameTextBox.TabIndex = 87
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(92, 54)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.FirstNameTextBox.TabIndex = 86
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(92, 28)
        Me.txtEmployeeID.MaxLength = 3
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(30, 20)
        Me.txtEmployeeID.TabIndex = 85
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(28, 83)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.LastNameLabel.TabIndex = 84
        Me.LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(28, 57)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.FirstNameLabel.TabIndex = 83
        Me.FirstNameLabel.Text = "First Name:"
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(19, 31)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        Me.EmployeeIDLabel.TabIndex = 82
        Me.EmployeeIDLabel.Text = "Employee ID:"
        '
        'comboRole
        '
        Me.comboRole.Enabled = False
        Me.comboRole.FormattingEnabled = True
        Me.comboRole.Items.AddRange(New Object() {"E", "M"})
        Me.comboRole.Location = New System.Drawing.Point(91, 185)
        Me.comboRole.Name = "comboRole"
        Me.comboRole.Size = New System.Drawing.Size(48, 21)
        Me.comboRole.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(278, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "*"
        '
        'leaveDate
        '
        Me.leaveDate.Enabled = False
        Me.leaveDate.Location = New System.Drawing.Point(89, 232)
        Me.leaveDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.leaveDate.Name = "leaveDate"
        Me.leaveDate.Size = New System.Drawing.Size(200, 20)
        Me.leaveDate.TabIndex = 110
        Me.leaveDate.Value = New Date(2020, 3, 1, 20, 31, 9, 0)
        '
        'HireDateLabel
        '
        Me.HireDateLabel.AutoSize = True
        Me.HireDateLabel.Location = New System.Drawing.Point(19, 234)
        Me.HireDateLabel.Name = "HireDateLabel"
        Me.HireDateLabel.Size = New System.Drawing.Size(66, 13)
        Me.HireDateLabel.TabIndex = 109
        Me.HireDateLabel.Text = "Leave Date:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(92, 159)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtPassword.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Phone Number:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(92, 134)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(96, 20)
        Me.txtPhone.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(278, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(277, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "*"
        '
        'ExistingEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 301)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.leaveDate)
        Me.Controls.Add(Me.HireDateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.ActiveLabel)
        Me.Controls.Add(Me.RoleLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.EmployeeIDLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "ExistingEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents ActiveLabel As Label
    Friend WithEvents RoleLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents comboRole As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents leaveDate As DateTimePicker
    Friend WithEvents HireDateLabel As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
