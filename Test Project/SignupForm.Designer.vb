<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.createDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(93, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(296, 123)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(93, 44)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(93, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 4
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(93, 171)
        Me.txtCardNumber.MaxLength = 16
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCardNumber.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(296, 57)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(296, 91)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Card Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(242, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Zip Code:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Create Date:"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(296, 186)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 11
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'createDate
        '
        Me.createDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.createDate.Location = New System.Drawing.Point(296, 154)
        Me.createDate.Name = "createDate"
        Me.createDate.Size = New System.Drawing.Size(100, 20)
        Me.createDate.TabIndex = 10
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(122, 217)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(76, 25)
        Me.btnSign.TabIndex = 12
        Me.btnSign.Text = "Sign Up"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 25)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(296, 21)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(25, 20)
        Me.txtState.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(93, 74)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 255)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.createDate)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtZip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SignupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents createDate As DateTimePicker
    Friend WithEvents btnSign As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtPhone As MaskedTextBox
End Class
