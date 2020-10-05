Public Class NewProductForm
    Private DB As New DBAccess
    Private Sub NewProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensures users cannot create a customer in the future 
        CreateDateTimePicker.MaxDate = Today.Date
        ' Ensures users cannot create a customer prior than 7 days before today's date 
        CreateDateTimePicker.MinDate = Today.Date.AddDays(-7)
        ' Automatically have active checkbox checked 
        ActiveCheckBox.Checked = True
        ' Doesn't allow the user to change it 
        ActiveCheckBox.Enabled = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ClearForm()
        ProductNameTextBox.Clear()
        DescriptionTextBox.Clear()
        PriceTextBox.Clear()
        ActiveCheckBox.Checked = True
        CreateDateTimePicker.Value = Today.Date
    End Sub

    Private Function ValidateProduct() As Boolean
        If String.IsNullOrWhiteSpace(ProductNameTextBox.Text) Then
            MessageBox.Show("Product name can't be empty.")
            ProductNameTextBox.SelectAll()
            ProductNameTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(DescriptionTextBox.Text) Then
            MessageBox.Show("Description can't be empty.")
            DescriptionTextBox.SelectAll()
            DescriptionTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(PriceTextBox.Text) Then
            MessageBox.Show("Price can't be empty.")
            PriceTextBox.SelectAll()
            PriceTextBox.Focus()
            Return False
        End If

        Dim PriceDecimal As Decimal
        If Decimal.TryParse(PriceTextBox.Text, PriceDecimal) = False Then
            MessageBox.Show("Price must be a decimal.")
            PriceTextBox.SelectAll()
            PriceTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(comboType.SelectedItem) Then
            MessageBox.Show("You must select a type.")
            comboType.SelectAll()
            comboType.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub AddProduct()
        DB.AddParam("@name", ProductNameTextBox.Text)
        DB.AddParam("@description", DescriptionTextBox.Text)
        DB.AddParam("@price", PriceTextBox.Text)
        DB.AddParam("@type", comboType.SelectedItem)
        DB.AddParam("@active", ActiveCheckBox.Checked)
        DB.AddParam("@createdate", CreateDateTimePicker.Value)

        DB.ExecuteQuery("INSERT INTO product(name, description, price, type, active, createdate) VALUES (?, ?, ?, ?, ?, ?) ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A new product was inserted successfully.")
    End Sub

    Private Sub NewProductForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClearForm()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateProduct() = False Then
            Exit Sub
        Else
            AddProduct()
        End If
        Me.Close()
    End Sub
End Class