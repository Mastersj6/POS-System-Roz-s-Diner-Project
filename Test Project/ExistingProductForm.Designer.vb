<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingProductForm
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(212, 382)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(82, 25)
        Me.CancelButton.TabIndex = 23
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(106, 382)
        Me.EditSaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(82, 25)
        Me.EditSaveButton.TabIndex = 22
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Enabled = False
        Me.ActiveCheckBox.Location = New System.Drawing.Point(106, 350)
        Me.ActiveCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 20
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(106, 248)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PriceTextBox.TabIndex = 19
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(106, 110)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(250, 114)
        Me.DescriptionTextBox.TabIndex = 18
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(106, 69)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.Size = New System.Drawing.Size(250, 20)
        Me.ProductNameTextBox.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 303)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Active:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 248)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Product Name:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ProductIDTextBox.Location = New System.Drawing.Point(106, 30)
        Me.ProductIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.ReadOnly = True
        Me.ProductIDTextBox.Size = New System.Drawing.Size(52, 20)
        Me.ProductIDTextBox.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Product ID:"
        '
        'comboType
        '
        Me.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboType.Enabled = False
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Breakfast item", "Lunch item"})
        Me.comboType.Location = New System.Drawing.Point(106, 300)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(102, 21)
        Me.comboType.TabIndex = 26
        '
        'ExistingProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 416)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
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
        Me.Name = "ExistingProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents comboType As ComboBox
End Class
