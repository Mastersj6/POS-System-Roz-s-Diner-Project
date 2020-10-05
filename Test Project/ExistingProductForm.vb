Imports System.Text.RegularExpressions
Public Class ExistingProductForm
    Private DB As New DBAccess
    Private Sub ExistingProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Dashboard.txtProductID.Text = String.Empty Then
            MessageBox.Show("No Product selected.")
            Me.Close()
        Else
            DB.AddParam("@ID", Dashboard.txtProductID.Text)
            DB.ExecuteQuery("SELECT * FROM product WHERE id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            ProductIDTextBox.Text = DB.DBDataTable(0)!id
            ProductNameTextBox.Text = DB.DBDataTable(0)!name
            DescriptionTextBox.Text = DB.DBDataTable(0)!description
            comboType.SelectedItem = DB.DBDataTable(0)!type
            PriceTextBox.Text = DB.DBDataTable(0)!price
            ActiveCheckBox.Checked = DB.DBDataTable(0)!active
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub EnableFieldsForEdit(Switch As Boolean)
        ProductNameTextBox.ReadOnly = Not Switch
        DescriptionTextBox.ReadOnly = Not Switch
        comboType.Enabled = Switch
        PriceTextBox.ReadOnly = Not Switch
        ActiveCheckBox.Enabled = Switch

        ProductIDTextBox.ReadOnly = True


        If Switch = True Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If

    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            'edit mode
            EnableFieldsForEdit(True)
            EditSaveButton.Text = "&Save"
        Else
            'save mode
            'save the updated record
            If ValidateExistingProduct() = False Then
                Exit Sub
            End If

            EnableFieldsForEdit(False)
            EditSaveButton.Text = "&Edit"
            SaveUpdatedProduct()

        End If
    End Sub

    Private Sub SaveUpdatedProduct()
        DB.AddParam("@productname", ProductNameTextBox.Text)
        DB.AddParam("@description", DescriptionTextBox.Text)
        DB.AddParam("@price", PriceTextBox.Text)
        DB.AddParam("@type", comboType.SelectedItem)
        DB.AddParam("active", ActiveCheckBox.Checked)
        DB.AddParam("@productid", ProductIDTextBox.Text)

        DB.ExecuteQuery("UPDATE product SET name = ?, description = ?, price = ?, type = ?, active = ?  WHERE id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The product has been updated successfully.")
        Me.Close()
    End Sub

    Private Function ValidateExistingProduct() As Boolean
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

        If String.IsNullOrWhiteSpace(comboType.SelectedItem) Then
            MessageBox.Show("Type can't be empty.")
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
        Return True
    End Function
End Class