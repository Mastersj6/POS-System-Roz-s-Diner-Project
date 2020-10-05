Public Class Dashboard
    Private DB As New DBAccess
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        'call function to load product table
        GetProducts()
        GetEmployee()
        GetCustomers()
        GetOrders()
        'load charts
        LoadProductsOrdered()
        LoadMVC()
        GetAVGCost()
        GetAVGProduct()
    End Sub
    'START OF PRODUCT TAB
    '
    '
    '
    '
    Private Sub GetProducts()
        DB.ExecuteQuery("Select * FROM product")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridProduct.DataSource = DB.DBDataTable
        dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    'Search Functions
    'product search
    Private Sub SearchProduct(Name As String, Type As String)
        DB.AddParam("@Name", Name & "%")
        DB.AddParam("@Type", Type & "%")

        DB.ExecuteQuery("SELECT * from product WHERE Name LIKE ? AND Type LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        dataGridProduct.DataSource = DB.DBDataTable
    End Sub

    Private Sub txtProductSearchKeyUp(sender As Object, e As KeyEventArgs) Handles txtName.KeyUp, txtType.KeyUp
        SearchProduct(txtName.Text, txtType.Text)
    End Sub
    'data grid view selections
    Private Sub dataGridProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridProduct.CellClick
        If e.RowIndex < 0 Or e.RowIndex = dataGridProduct.RowCount - 1 Then
            txtProductID.Clear()
            Exit Sub
        Else
            txtProductID.Text = dataGridProduct.Item(0, e.RowIndex).Value

        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        NewProductForm.ShowDialog()
    End Sub

    Private Sub btnChangeProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        ExistingProductForm.ShowDialog()
    End Sub
    'END OF PRODUCT SECTION
    '
    '
    '
    '
    'START OF EMPLOYEE TAB
    '
    '
    '
    '
    Private Sub GetEmployee()
        DB.ExecuteQuery("Select * FROM Employee")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridEmployee.DataSource = DB.DBDataTable
        dataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    'Search Functions
    'employee search
    Private Sub SearchEmployee(FirstName As String, LastName As String)
        DB.AddParam("@FirstName", FirstName & "%")
        DB.AddParam("@LastName", LastName & "%")

        DB.ExecuteQuery("SELECT * from employee WHERE FirstName LIKE ? AND LastName LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        dataGridEmployee.DataSource = DB.DBDataTable
    End Sub

    Private Sub txtEmployeeSearchKeyUp(sender As Object, e As KeyEventArgs) Handles txtEmployeeFirstName.KeyUp, txtEmployeeLastName.KeyUp
        SearchEmployee(txtEmployeeFirstName.Text, txtEmployeeLastName.Text)
    End Sub
    'data grid view selections
    Private Sub dataGridEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridEmployee.CellClick
        If e.RowIndex < 0 Or e.RowIndex = dataGridEmployee.RowCount - 1 Then
            txtEmployeeID.Clear()
            Exit Sub
        Else
            txtEmployeeID.Text = dataGridEmployee.Item(0, e.RowIndex).Value

        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        NewEmployeeForm.ShowDialog()
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        ExistingEmployeeForm.ShowDialog()
    End Sub
    'END OF Employee SECTION
    '
    '
    '
    '
    'START OF Customer TAB
    '
    '
    '
    '
    Private Sub GetCustomers()
        DB.ExecuteQuery("Select ID, firstname, lastname, phonenumber, email, address, city, state, zip, active, createdate, lastupdate FROM Customer")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridCustomers.DataSource = DB.DBDataTable
        dataGridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    'Search Functions
    'employee search
    Private Sub SearchCustomer(FirstName As String, LastName As String)
        DB.AddParam("@FirstName", FirstName & "%")
        DB.AddParam("@LastName", LastName & "%")

        DB.ExecuteQuery("SELECT * from customer WHERE FirstName LIKE ? AND LastName LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        dataGridCustomers.DataSource = DB.DBDataTable
    End Sub

    Private Sub txtCustomerSearchKeyUp(sender As Object, e As KeyEventArgs) Handles txtCustomerFirstName.KeyUp, txtCustomerLastName.KeyUp
        SearchCustomer(txtCustomerFirstName.Text, txtCustomerLastName.Text)
    End Sub
    'data grid view selections
    Private Sub dataGridCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCustomers.CellClick
        If e.RowIndex < 0 Or e.RowIndex = dataGridCustomers.RowCount - 1 Then
            txtCustomerID.Clear()
            Exit Sub
        Else
            txtCustomerID.Text = dataGridCustomers.Item(0, e.RowIndex).Value

        End If
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        ExistingCustomerForm.ShowDialog()
    End Sub
    'START OF Order TAB
    '
    '
    '
    '
    Private Sub GetOrders()
        DB.ExecuteQuery("Select * FROM Sale")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridOrders.DataSource = DB.DBDataTable
        dataGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    'Search Functions
    'product search
    Private Sub SearchOrder(ID As String, Status As String)
        DB.AddParam("@id", ID & "%")
        DB.AddParam("@status", Status & "%")

        DB.ExecuteQuery("SELECT * from sale WHERE id LIKE ? AND status LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        dataGridOrders.DataSource = DB.DBDataTable
    End Sub

    Private Sub txtOrderSearchKeyUp(sender As Object, e As KeyEventArgs) Handles txtOrderID.KeyUp, txtOrderStatus.KeyUp
        SearchOrder(txtOrderID.Text, txtOrderStatus.Text)
    End Sub
    'data grid view selections
    Private Sub dataGridOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridOrders.CellClick
        If e.RowIndex < 0 Or e.RowIndex = dataGridOrders.RowCount - 1 Then
            txtOrderID.Clear()
            Exit Sub
        Else
            txtSaleID.Text = dataGridOrders.Item(0, e.RowIndex).Value

        End If
    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        UpdateOrder.ShowDialog()
    End Sub
    'END OF Order SECTION
    '
    '
    '
    '
    'Start OF Dashboard graph stuff
    '
    '
    '
    '
    Private Sub GetAVGProduct()
        DB.ExecuteQuery("select avg(Quantity) as avg FROM sp2020bis425fc1g4.productSale;")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If
        txtAVGProd.Text = DB.DBDataTable(0)!avg
    End Sub
    Private Sub GetAVGCost()
        DB.ExecuteQuery("select avg(Price) as avg FROM sp2020bis425fc1g4.productSale")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If
        txtAVGCost.Text = DB.DBDataTable(0)!avg
    End Sub
    Private Sub LoadProductsOrdered()
        DB.ExecuteQuery("select count(ProductID), Name  from sp2020bis425fc1g4.ProductSale, sp2020bis425fc1g4.product where productID = ID group by ProductID;")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        productsOrderedChart.DataSource = DB.DBDataTable
        productsOrderedChart.Series("Product Orders").YValueMembers = "count(ProductID)"
        productsOrderedChart.Series("Product Orders").XValueMember = "Name"
        productsOrderedChart.Legends.Clear()
    End Sub
    Private Sub LoadMVC()
        DB.ExecuteQuery("select customerID,count(customerID) from sp2020bis425fc1g4.Sale group by customerID;")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        mvcChart.DataSource = DB.DBDataTable
        mvcChart.Series("Customers Orders").YValueMembers = "count(customerID)"
        mvcChart.Series("Customers Orders").XValueMember = "customerID"
        mvcChart.Legends.Clear()
    End Sub

End Class