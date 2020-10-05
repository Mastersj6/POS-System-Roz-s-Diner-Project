<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingCustomerForm
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
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(99, 88)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 47
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(301, 32)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(25, 20)
        Me.txtState.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(99, 32)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 25)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(123, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 25)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "&Edit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(302, 163)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 33
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Zip Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Card Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(261, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(269, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Last Name:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(302, 105)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 29
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(302, 71)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 28
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(99, 185)
        Me.txtCardNumber.MaxLength = 16
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.ReadOnly = True
        Me.txtCardNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCardNumber.TabIndex = 27
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(99, 154)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 26
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(99, 120)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 25
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(99, 58)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 24
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(302, 137)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 30
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(99, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "ID:"
        '
        'ExistingCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 274)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkActive)
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
        Me.MaximizeBox = False
        Me.Name = "ExistingCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label11 As Label
End Class
