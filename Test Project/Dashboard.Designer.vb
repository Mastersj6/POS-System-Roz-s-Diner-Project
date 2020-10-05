<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.tabDashboard = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAVGProd = New System.Windows.Forms.TextBox()
        Me.txtAVGCost = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.productsOrderedChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mvcChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployeeFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dataGridEmployee = New System.Windows.Forms.DataGridView()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerLastName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dataGridCustomers = New System.Windows.Forms.DataGridView()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dataGridProduct = New System.Windows.Forms.DataGridView()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtOrderStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dataGridOrders = New System.Windows.Forms.DataGridView()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.tabDashboard.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.productsOrderedChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvcChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataGridCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dataGridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(6, 364)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(118, 30)
        Me.btnAddProduct.TabIndex = 0
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'tabDashboard
        '
        Me.tabDashboard.Controls.Add(Me.TabPage1)
        Me.tabDashboard.Controls.Add(Me.TabPage2)
        Me.tabDashboard.Controls.Add(Me.TabPage3)
        Me.tabDashboard.Controls.Add(Me.TabPage4)
        Me.tabDashboard.Controls.Add(Me.TabPage5)
        Me.tabDashboard.Location = New System.Drawing.Point(12, 12)
        Me.tabDashboard.Name = "tabDashboard"
        Me.tabDashboard.SelectedIndex = 0
        Me.tabDashboard.Size = New System.Drawing.Size(828, 426)
        Me.tabDashboard.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAVGProd)
        Me.TabPage1.Controls.Add(Me.txtAVGCost)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.productsOrderedChart)
        Me.TabPage1.Controls.Add(Me.mvcChart)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(820, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dashboard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtAVGProd
        '
        Me.txtAVGProd.Location = New System.Drawing.Point(212, 88)
        Me.txtAVGProd.Name = "txtAVGProd"
        Me.txtAVGProd.ReadOnly = True
        Me.txtAVGProd.Size = New System.Drawing.Size(80, 20)
        Me.txtAVGProd.TabIndex = 7
        '
        'txtAVGCost
        '
        Me.txtAVGCost.Location = New System.Drawing.Point(212, 43)
        Me.txtAVGCost.Name = "txtAVGCost"
        Me.txtAVGCost.ReadOnly = True
        Me.txtAVGCost.Size = New System.Drawing.Size(80, 20)
        Me.txtAVGCost.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(198, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Average Number of Products Per Order: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Average Cost Per Order:"
        '
        'productsOrderedChart
        '
        ChartArea1.AxisX.Title = "Product Names"
        ChartArea1.AxisY.Title = "Number of times ordered"
        ChartArea1.Name = "ChartArea1"
        Me.productsOrderedChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.productsOrderedChart.Legends.Add(Legend1)
        Me.productsOrderedChart.Location = New System.Drawing.Point(0, 148)
        Me.productsOrderedChart.Name = "productsOrderedChart"
        Series1.ChartArea = "ChartArea1"
        Series1.LabelAngle = 90
        Series1.Legend = "Legend1"
        Series1.Name = "Product Orders"
        Me.productsOrderedChart.Series.Add(Series1)
        Me.productsOrderedChart.Size = New System.Drawing.Size(406, 252)
        Me.productsOrderedChart.TabIndex = 1
        Me.productsOrderedChart.Text = "Chart1"
        '
        'mvcChart
        '
        ChartArea2.AxisX.Title = "Customer ID"
        ChartArea2.AxisY.Title = "Number of times ordered"
        ChartArea2.Name = "ChartArea1"
        Me.mvcChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.mvcChart.Legends.Add(Legend2)
        Me.mvcChart.Location = New System.Drawing.Point(412, 148)
        Me.mvcChart.Name = "mvcChart"
        Series2.ChartArea = "ChartArea1"
        Series2.LabelAngle = 90
        Series2.Legend = "Legend1"
        Series2.Name = "Customers Orders"
        Me.mvcChart.Series.Add(Series2)
        Me.mvcChart.Size = New System.Drawing.Size(408, 252)
        Me.mvcChart.TabIndex = 2
        Me.mvcChart.Text = "Chart1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Sales Information"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtEmployeeID)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.dataGridEmployee)
        Me.TabPage2.Controls.Add(Me.btnUpdateEmployee)
        Me.TabPage2.Controls.Add(Me.btnAddEmployee)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(820, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Employees"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(281, 370)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(59, 20)
        Me.txtEmployeeID.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEmployeeLastName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeFirstName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(808, 54)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Employee"
        '
        'txtEmployeeLastName
        '
        Me.txtEmployeeLastName.Location = New System.Drawing.Point(295, 23)
        Me.txtEmployeeLastName.Name = "txtEmployeeLastName"
        Me.txtEmployeeLastName.Size = New System.Drawing.Size(150, 20)
        Me.txtEmployeeLastName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last Name:"
        '
        'txtEmployeeFirstName
        '
        Me.txtEmployeeFirstName.Location = New System.Drawing.Point(72, 23)
        Me.txtEmployeeFirstName.Name = "txtEmployeeFirstName"
        Me.txtEmployeeFirstName.Size = New System.Drawing.Size(150, 20)
        Me.txtEmployeeFirstName.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "First Name:"
        '
        'dataGridEmployee
        '
        Me.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridEmployee.Location = New System.Drawing.Point(6, 66)
        Me.dataGridEmployee.Name = "dataGridEmployee"
        Me.dataGridEmployee.ReadOnly = True
        Me.dataGridEmployee.Size = New System.Drawing.Size(808, 292)
        Me.dataGridEmployee.TabIndex = 20
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(130, 364)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(118, 30)
        Me.btnUpdateEmployee.TabIndex = 19
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(6, 364)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(118, 30)
        Me.btnAddEmployee.TabIndex = 18
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtCustomerID)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.dataGridCustomers)
        Me.TabPage3.Controls.Add(Me.btnUpdateCustomer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(820, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(157, 370)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(59, 20)
        Me.txtCustomerID.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCustomerLastName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCustomerFirstName)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(808, 54)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Customers"
        '
        'txtCustomerLastName
        '
        Me.txtCustomerLastName.Location = New System.Drawing.Point(295, 23)
        Me.txtCustomerLastName.Name = "txtCustomerLastName"
        Me.txtCustomerLastName.Size = New System.Drawing.Size(150, 20)
        Me.txtCustomerLastName.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Last Name:"
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(72, 23)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(150, 20)
        Me.txtCustomerFirstName.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "First Name:"
        '
        'dataGridCustomers
        '
        Me.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridCustomers.Location = New System.Drawing.Point(6, 66)
        Me.dataGridCustomers.Name = "dataGridCustomers"
        Me.dataGridCustomers.ReadOnly = True
        Me.dataGridCustomers.Size = New System.Drawing.Size(808, 292)
        Me.dataGridCustomers.TabIndex = 25
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(6, 364)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(118, 30)
        Me.btnUpdateCustomer.TabIndex = 24
        Me.btnUpdateCustomer.Text = "Update Customer"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.txtProductID)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.dataGridProduct)
        Me.TabPage4.Controls.Add(Me.btnUpdateProduct)
        Me.TabPage4.Controls.Add(Me.btnAddProduct)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(820, 400)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Products"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID:"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(281, 370)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(59, 20)
        Me.txtProductID.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Product"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(246, 23)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(150, 20)
        Me.txtType.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Type:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(50, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 20)
        Me.txtName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Name:"
        '
        'dataGridProduct
        '
        Me.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridProduct.Location = New System.Drawing.Point(6, 77)
        Me.dataGridProduct.Name = "dataGridProduct"
        Me.dataGridProduct.ReadOnly = True
        Me.dataGridProduct.Size = New System.Drawing.Size(808, 281)
        Me.dataGridProduct.TabIndex = 2
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(130, 364)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(118, 30)
        Me.btnUpdateProduct.TabIndex = 1
        Me.btnUpdateProduct.Text = "Update Product"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.txtSaleID)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.dataGridOrders)
        Me.TabPage5.Controls.Add(Me.btnUpdateOrder)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(820, 400)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Orders"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID:"
        '
        'txtSaleID
        '
        Me.txtSaleID.Location = New System.Drawing.Point(160, 373)
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.ReadOnly = True
        Me.txtSaleID.Size = New System.Drawing.Size(59, 20)
        Me.txtSaleID.TabIndex = 22
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtOrderStatus)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtOrderID)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(808, 54)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Order"
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Location = New System.Drawing.Point(264, 23)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.Size = New System.Drawing.Size(150, 20)
        Me.txtOrderStatus.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(218, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Status:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(62, 23)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(150, 20)
        Me.txtOrderID.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Order ID:"
        '
        'dataGridOrders
        '
        Me.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridOrders.Location = New System.Drawing.Point(6, 77)
        Me.dataGridOrders.Name = "dataGridOrders"
        Me.dataGridOrders.ReadOnly = True
        Me.dataGridOrders.Size = New System.Drawing.Size(808, 281)
        Me.dataGridOrders.TabIndex = 19
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Location = New System.Drawing.Point(6, 367)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(118, 30)
        Me.btnUpdateOrder.TabIndex = 18
        Me.btnUpdateOrder.Text = "Update Order"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 450)
        Me.Controls.Add(Me.tabDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.tabDashboard.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.productsOrderedChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvcChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataGridCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dataGridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents tabDashboard As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents dataGridProduct As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEmployeeLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployeeFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dataGridEmployee As DataGridView
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCustomerLastName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustomerFirstName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dataGridCustomers As DataGridView
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSaleID As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtOrderStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dataGridOrders As DataGridView
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents productsOrderedChart As DataVisualization.Charting.Chart
    Friend WithEvents Label13 As Label
    Friend WithEvents mvcChart As DataVisualization.Charting.Chart
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAVGProd As TextBox
    Friend WithEvents txtAVGCost As TextBox
End Class
