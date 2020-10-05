<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOrder
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Status:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(68, 28)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(75, 20)
        Me.txtOrderID.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Order ID:"
        '
        'comboStatus
        '
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Cooking", "Done"})
        Me.comboStatus.Location = New System.Drawing.Point(68, 61)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(156, 21)
        Me.comboStatus.TabIndex = 20
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(68, 92)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(149, 92)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'UpdateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 127)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label12)
        Me.MaximizeBox = False
        Me.Name = "UpdateOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
