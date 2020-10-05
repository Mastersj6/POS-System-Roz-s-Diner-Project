<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

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
        Me.dataGridBreakfast = New System.Windows.Forms.DataGridView()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtBoxOrder = New System.Windows.Forms.TextBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnClearOrder = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dataGridLunch = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateMyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dataGridBreakfast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridLunch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridBreakfast
        '
        Me.dataGridBreakfast.AllowUserToDeleteRows = False
        Me.dataGridBreakfast.AllowUserToResizeRows = False
        Me.dataGridBreakfast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridBreakfast.Location = New System.Drawing.Point(6, 15)
        Me.dataGridBreakfast.MultiSelect = False
        Me.dataGridBreakfast.Name = "dataGridBreakfast"
        Me.dataGridBreakfast.ReadOnly = True
        Me.dataGridBreakfast.Size = New System.Drawing.Size(184, 309)
        Me.dataGridBreakfast.TabIndex = 0
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(422, 70)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(185, 28)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "Cost: $0"
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(422, 98)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(197, 28)
        Me.lblTax.TabIndex = 9
        Me.lblTax.Text = "Tax: $0"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(422, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(213, 28)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total: $0"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(260, 374)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add to order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(4, 371)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(219, 53)
        Me.lblDescription.TabIndex = 1
        '
        'txtBoxOrder
        '
        Me.txtBoxOrder.Location = New System.Drawing.Point(426, 188)
        Me.txtBoxOrder.Multiline = True
        Me.txtBoxOrder.Name = "txtBoxOrder"
        Me.txtBoxOrder.ReadOnly = True
        Me.txtBoxOrder.Size = New System.Drawing.Size(194, 207)
        Me.txtBoxOrder.TabIndex = 12
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(544, 400)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 13
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(260, 405)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(31, 20)
        Me.txtProductID.TabIndex = 14
        Me.txtProductID.Visible = False
        '
        'lblOrder
        '
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(422, 35)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(144, 28)
        Me.lblOrder.TabIndex = 15
        Me.lblOrder.Text = "Your Order"
        '
        'btnClearOrder
        '
        Me.btnClearOrder.Location = New System.Drawing.Point(342, 374)
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnClearOrder.TabIndex = 16
        Me.btnClearOrder.Text = "Clear Order"
        Me.btnClearOrder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataGridBreakfast)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 330)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Breakfast"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dataGridLunch)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 330)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lunch"
        '
        'dataGridLunch
        '
        Me.dataGridLunch.AllowUserToDeleteRows = False
        Me.dataGridLunch.AllowUserToResizeRows = False
        Me.dataGridLunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridLunch.Location = New System.Drawing.Point(6, 15)
        Me.dataGridLunch.MultiSelect = False
        Me.dataGridLunch.Name = "dataGridLunch"
        Me.dataGridLunch.ReadOnly = True
        Me.dataGridLunch.Size = New System.Drawing.Size(191, 309)
        Me.dataGridLunch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Using credit card:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(536, 162)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.ReadOnly = True
        Me.txtCardNumber.Size = New System.Drawing.Size(84, 20)
        Me.txtCardNumber.TabIndex = 21
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(298, 405)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(37, 20)
        Me.txtCustomerID.TabIndex = 22
        Me.txtCustomerID.Visible = False
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(402, 408)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(15, 14)
        Me.chkActive.TabIndex = 23
        Me.chkActive.UseVisualStyleBackColor = True
        Me.chkActive.Visible = False
        '
        'txtSaleID
        '
        Me.txtSaleID.Location = New System.Drawing.Point(342, 405)
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.ReadOnly = True
        Me.txtSaleID.Size = New System.Drawing.Size(37, 20)
        Me.txtSaleID.TabIndex = 24
        Me.txtSaleID.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateMyAccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateMyAccountToolStripMenuItem
        '
        Me.UpdateMyAccountToolStripMenuItem.Name = "UpdateMyAccountToolStripMenuItem"
        Me.UpdateMyAccountToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.UpdateMyAccountToolStripMenuItem.Text = "Update My Account"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 439)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClearOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.txtBoxOrder)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        CType(Me.dataGridBreakfast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGridLunch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dataGridBreakfast As DataGridView
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtBoxOrder As TextBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents btnClearOrder As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dataGridLunch As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtSaleID As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateMyAccountToolStripMenuItem As ToolStripMenuItem
End Class
