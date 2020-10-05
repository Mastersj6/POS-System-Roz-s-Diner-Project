Imports System.Text.RegularExpressions
Public Class ExistingCustomerForm
    Private DB As New DBAccess
    Private Sub ExistingCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dashboard.txtCustomerID.Text = String.Empty Then
            MessageBox.Show("No Customer selected.")
            Me.Close()
        Else
            DB.AddParam("@ID", Dashboard.txtCustomerID.Text)
            DB.ExecuteQuery("SELECT * FROM customer WHERE id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            txtID.Text = DB.DBDataTable(0)!id
            txtFirstName.Text = DB.DBDataTable(0)!firstname
            txtLastName.Text = DB.DBDataTable(0)!lastname
            txtPhone.Text = DB.DBDataTable(0)!phonenumber
            txtEmail.Text = DB.DBDataTable(0)!email
            txtPassword.Text = DB.DBDataTable(0)!password
            txtCardNumber.Text = DB.DBDataTable(0)!cardnumber
            txtState.Text = DB.DBDataTable(0)!state
            txtCity.Text = DB.DBDataTable(0)!city
            txtAddress.Text = DB.DBDataTable(0)!address
            txtZip.Text = DB.DBDataTable(0)!zip
            chkActive.Checked = DB.DBDataTable(0)!active
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EnableFieldsForEdit(Switch As Boolean)

        txtID.ReadOnly = Not Switch
        txtFirstName.ReadOnly = Not Switch
        txtLastName.ReadOnly = Not Switch
        txtPhone.ReadOnly = Not Switch
        txtEmail.ReadOnly = Not Switch
        txtPassword.ReadOnly = Not Switch
        txtCardNumber.ReadOnly = Not Switch
        txtState.ReadOnly = Not Switch
        txtCity.ReadOnly = Not Switch
        txtAddress.ReadOnly = Not Switch
        txtZip.ReadOnly = Not Switch

        chkActive.Enabled = Switch

        txtID.ReadOnly = True

        If Switch = True Then
            btnSave.Text = "&Save"
        Else
            btnSave.Text = "&Edit"
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "&Edit" Then
            'edit mode
            EnableFieldsForEdit(True)
            btnSave.Text = "&Save"
        Else
            'save mode
            'save the updated record
            If ValidateExistingProduct() = False Then
                Exit Sub
            End If

            EnableFieldsForEdit(False)
            btnSave.Text = "&Edit"
            SaveUpdatedCustomer()

        End If
    End Sub

    Private Sub SaveUpdatedCustomer()
        DB.AddParam("@firstname", txtFirstName.Text)
        DB.AddParam("@lastname", txtLastName.Text)
        DB.AddParam("@phonenumber", txtPhone.Text)
        DB.AddParam("@email", txtEmail.Text)
        DB.AddParam("password", txtPassword.Text)
        DB.AddParam("cardnumber", txtCardNumber.Text)
        DB.AddParam("state", txtState.Text)
        DB.AddParam("city", txtCity.Text)
        DB.AddParam("address", txtAddress.Text)
        DB.AddParam("zip", txtZip.Text)
        DB.AddParam("active", chkActive.Checked)

        DB.AddParam("@id", txtID.Text)

        DB.ExecuteQuery("UPDATE customer SET firstname = ?, lastname = ?, phonenumber = ?, email = ?, password = ?, cardnumber = ?, state = ?, city = ?, address = ?, zip = ?, active = ? WHERE id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The customer has been updated successfully.")
        Me.Close()
    End Sub

    Private Function ValidateExistingProduct() As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First name can't be empty.")
            txtFirstName.SelectAll()
            txtFirstName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Last name can't be empty.")
            txtLastName.SelectAll()
            txtLastName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email can't be empty.")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password can't be empty.")
            txtPassword.SelectAll()
            txtPassword.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCardNumber.Text) Then
            MessageBox.Show("Card Number can't be empty.")
            txtCardNumber.SelectAll()
            txtCardNumber.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtState.Text) Then
            MessageBox.Show("State can't be empty.")
            txtState.SelectAll()
            txtState.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCity.Text) Then
            MessageBox.Show("City can't be empty.")
            txtCity.SelectAll()
            txtCity.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address can't be empty.")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtZip.Text) Then
            MessageBox.Show("Zip Code can't be empty.")
            txtZip.SelectAll()
            txtZip.Focus()
            Return False
        End If
        Return True
    End Function

End Class