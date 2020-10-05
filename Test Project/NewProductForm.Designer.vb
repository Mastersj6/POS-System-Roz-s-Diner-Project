<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProductForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.CreateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Active:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 320)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Create Date:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(104, 22)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(250, 20)
        Me.ProductNameTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(104, 63)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(250, 114)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(104, 201)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PriceTextBox.TabIndex = 3
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(104, 277)
        Me.ActiveCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 8
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'CreateDateTimePicker
        '
        Me.CreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CreateDateTimePicker.Location = New System.Drawing.Point(104, 316)
        Me.CreateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateDateTimePicker.Name = "CreateDateTimePicker"
        Me.CreateDateTimePicker.Size = New System.Drawing.Size(102, 20)
        Me.CreateDateTimePicker.TabIndex = 5
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(94, 352)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(82, 25)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(210, 352)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(82, 25)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Type:"
        '
        'comboType
        '
        Me.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Breakfast", "Lunch"})
        Me.comboType.Location = New System.Drawing.Point(104, 243)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(102, 21)
        Me.comboType.TabIndex = 4
        '
        'NewProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 397)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateDateTimePicker)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "NewProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents CreateDateTimePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents comboType As ComboBox
End Class
