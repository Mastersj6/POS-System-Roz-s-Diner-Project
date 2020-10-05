Public Class MenuForm
    Private DB As New DBAccess
    Public Order As New List(Of String)
    Public OrderCost As New List(Of Double)
    Dim runningCost As Double
    Dim tax As Double
    Dim total As Double

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetBreakfast()
        GetLunch()
        GetCustomerInfo()
        txtCustomerID.Text = LoginForm.txtUserID.Text



        'make headers invisible
        dataGridBreakfast.ColumnHeadersVisible = True
        dataGridBreakfast.RowHeadersVisible = False
        dataGridLunch.ColumnHeadersVisible = True
        dataGridLunch.RowHeadersVisible = False
        'hide other columns in breakfast
        dataGridBreakfast.Columns("ID").Visible = False
        dataGridBreakfast.Columns("Type").Visible = False
        dataGridBreakfast.Columns("Description").Visible = False
        dataGridBreakfast.Columns("price").Visible = True
        dataGridBreakfast.Columns("active").Visible = False
        dataGridBreakfast.Columns("createdate").Visible = False
        dataGridBreakfast.Columns("lastupdate").Visible = False
        'hide other columns in lunch
        dataGridLunch.Columns("ID").Visible = False
        dataGridLunch.Columns("Type").Visible = False
        dataGridLunch.Columns("Description").Visible = False
        dataGridLunch.Columns("price").Visible = True
        dataGridLunch.Columns("active").Visible = False
        dataGridLunch.Columns("createdate").Visible = False
        dataGridLunch.Columns("lastupdate").Visible = False

        'just to always have checked for insert sale
        chkActive.Checked = True
    End Sub
    Private Sub GetBreakfast()
        DB.ExecuteQuery("SELECT * FROM product where type = 'breakfast item'")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridBreakfast.DataSource = DB.DBDataTable
        dataGridBreakfast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub GetLunch()
        DB.ExecuteQuery("SELECT * FROM product where type = 'Lunch item'")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        dataGridLunch.DataSource = DB.DBDataTable
        dataGridLunch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub GetCustomerInfo()
        Dim cardnumber As String

        If LoginForm.txtUserID.Text = String.Empty Then
            MessageBox.Show("No Customer selected.")
            Me.Close()
        Else
            DB.AddParam("@ID", LoginForm.txtUserID.Text)
            DB.ExecuteQuery("SELECT * FROM customer WHERE id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If
        cardnumber = DB.DBDataTable(0)!cardnumber
        txtCardNumber.Text = cardnumber
    End Sub
    'grid selection ability 
    Private Sub dataGridBreakfast_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridBreakfast.CellClick

        If e.RowIndex < 0 Or e.RowIndex = dataGridBreakfast.RowCount - 1 Then
            lblDescription.Text = " "
            lblDescription.Text = " "
            Exit Sub
        Else
            txtProductID.Text = dataGridBreakfast.Item(0, e.RowIndex).Value
            lblDescription.Text = dataGridBreakfast.Item(2, e.RowIndex).Value
        End If
    End Sub

    'grid selection ability 
    Private Sub dataGridLunch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridLunch.CellClick

        If e.RowIndex < 0 Or e.RowIndex = dataGridLunch.RowCount - 1 Then
            lblDescription.Text = " "
            lblDescription.Text = " "
            Exit Sub
        Else
            txtProductID.Text = dataGridLunch.Item(0, e.RowIndex).Value
            lblDescription.Text = dataGridLunch.Item(2, e.RowIndex).Value
        End If
    End Sub

    'changes decription of food
    Private Sub dataGridLunch_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridLunch.SelectionChanged
        DB.ExecuteQuery("SELECT * FROM product where type = 'lunch item'")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        lblDescription.Text = " "
        lblDescription.Text = (DB.DBDataTable(0)!description)
        dataGridBreakfast.ClearSelection()
    End Sub

    Private Sub dataGridBreakfast_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridBreakfast.SelectionChanged

        DB.ExecuteQuery("SELECT * FROM product where type = 'breakfast item'")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If
        lblDescription.Text = " "
        lblDescription.Text = (DB.DBDataTable(0)!description)
        dataGridLunch.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        DB.AddParam("@ID", txtProductID.Text)
        DB.ExecuteQuery("SELECT * FROM product where ID = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If


        'adds items to list
        Order.Add(DB.DBDataTable(0)!name)
        OrderCost.Add(DB.DBDataTable(0)!price)

        'sums the cost of selected foods
        runningCost = OrderCost.Sum(Function(item) item.ToString())
        'determines tax cost
        tax = runningCost * 0.06
        'adds tax to total
        total = runningCost + tax


        lblCost.Text = "Cost: $" & runningCost
        lblTax.Text = "Tax: $" & tax
        lblTotal.Text = "Total: $" & total

        'displays list of items selected to textbox
        Dim items As String = String.Join(Environment.NewLine, Order)
        For i As Integer = 0 To Order.Count - 1
            txtBoxOrder.Text = (items)
        Next i

    End Sub

    Private Sub btnClearOrder_Click(sender As Object, e As EventArgs) Handles btnClearOrder.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()
        Order.Clear()
        OrderCost.Clear()
        txtBoxOrder.Text = " "
        lblCost.Text = "Cost: $0"
        lblTax.Text = "Tax: $0"
        lblTotal.Text = "Total: $0"
    End Sub

    Private Sub btnPlaceOrder_click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If Order.Count() = 0 Then
            MessageBox.Show("No items selected")
            Exit Sub

        End If
        Dim msg = MessageBox.Show("Are you sure you want to place your order?",
    "Order Placement",
    MessageBoxButtons.YesNo)
        If msg = DialogResult.No Then

        Else
            AddSale()
            AddProductSale()
            MessageBox.Show("Your order was created!")
            Me.Close()
            ClearForm()
            txtCardNumber.Text = " "
        End If
    End Sub

    Private Sub AddSale()
        DB.AddParam("@taxamount", tax)
        DB.AddParam("@active", chkActive.Checked)
        DB.AddParam("@createdate", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        DB.AddParam("@customerid", txtCustomerID.Text)
        DB.AddParam("@status", "Cooking")

        DB.ExecuteQuery("INSERT INTO sale(taxamount, active, createdate, customerid, status) VALUES (?, ?, ?, ?, ?) ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If


    End Sub

    Private Sub AddProductSale()
        GetsaleID()

        DB.AddParam("@productid", txtProductID.Text)
        DB.AddParam("@saleid", txtSaleID.Text)
        DB.AddParam("@price", total)
        DB.AddParam("@quantity", Order.Count())

        DB.ExecuteQuery("INSERT INTO ProductSale(productid, saleid, price, quantity) VALUES (?, ?, ?, ?) ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

    End Sub
    Private Sub GetsaleID()
        DB.ExecuteQuery("select * from sale ORDER BY id DESC LIMIT 1;")
        txtSaleID.Text = DB.DBDataTable(0)!id

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateMyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMyAccountToolStripMenuItem.Click
        UpdateMyAccountForm.ShowDialog()
    End Sub


End Class