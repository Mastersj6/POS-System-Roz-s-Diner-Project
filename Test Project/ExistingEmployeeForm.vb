Imports System.Text.RegularExpressions

Public Class ExistingEmployeeForm
    Private DB As New DBAccess
    Private Sub ExistingEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Dashboard.txtEmployeeID.Text = String.Empty Then
            MessageBox.Show("No Employee selected.")
            Me.Close()
        Else
            DB.AddParam("@ID", Dashboard.txtEmployeeID.Text)
            DB.ExecuteQuery("SELECT * FROM employee WHERE id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            txtEmployeeID.Text = DB.DBDataTable(0)!id
            FirstNameTextBox.Text = DB.DBDataTable(0)!firstname
            LastNameTextBox.Text = DB.DBDataTable(0)!lastname
            EmailTextBox.Text = DB.DBDataTable(0)!email
            txtPassword.Text = DB.DBDataTable(0)!password
            txtPhone.Text = DB.DBDataTable(0)!phonenumber
            comboRole.SelectedItem = DB.DBDataTable(0)!role
            ActiveCheckBox.Checked = DB.DBDataTable(0)!active
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub EnableFieldsForEdit(Switch As Boolean)
        FirstNameTextBox.ReadOnly = Not Switch
        LastNameTextBox.ReadOnly = Not Switch
        EmailTextBox.ReadOnly = Not Switch
        txtPassword.ReadOnly = Not Switch
        txtPhone.ReadOnly = Not Switch

        comboRole.Enabled = Switch
        ActiveCheckBox.Enabled = Switch
        leaveDate.Enabled = Switch

        txtEmployeeID.ReadOnly = True


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
            If ValidateExistingEmployee() = False Then
                Exit Sub
            End If

            SaveUpdatedEmployee()

            EnableFieldsForEdit(False)
            EditSaveButton.Text = "&Edit"

        End If
    End Sub

    Private Sub SaveUpdatedEmployee()
        DB.AddParam("@firstname", FirstNameTextBox.Text)
        DB.AddParam("@lastname", LastNameTextBox.Text)
        DB.AddParam("@email", EmailTextBox.Text)
        DB.AddParam("@password", txtPassword.Text)
        DB.AddParam("@phonenumber", txtPhone.Text)
        DB.AddParam("@role", comboRole.SelectedItem)
        DB.AddParam("active", ActiveCheckBox.Checked)
        DB.AddParam("leavedate", leaveDate.Value)
        DB.AddParam("@employeeid", txtEmployeeID.Text)

        DB.ExecuteQuery("UPDATE employee SET firstname = ?, lastname = ?, email = ?, password = ?, phonenumber = ?, role = ?, active = ?, leavedate = ? WHERE id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The employee has been updated successfully.")
        Me.Close()
    End Sub

    Private Function ValidateExistingEmployee() As Boolean
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            MessageBox.Show("First name can't be empty.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        Dim rxFirstName As New Regex("^[A-Z]+[a-z]+$")
        If Not rxFirstName.IsMatch(FirstNameTextBox.Text) Then
            MessageBox.Show("First name must be all alphabets and start with a capital letter.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            MessageBox.Show("Last name can't be empty.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        Dim rxLastName As New Regex("^[A-Z]+[a-z]+$")
        If Not rxLastName.IsMatch(LastNameTextBox.Text) Then
            MessageBox.Show("Last name must be all alphabets and start with a capital letter.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            MessageBox.Show("Email can't be empty.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False
        End If

        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")
        If Not rxEmail.IsMatch(EmailTextBox.Text) Then
            MessageBox.Show("Email must follow the right format such as abc@xyz.com.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password can't be empty.")
            txtPassword.SelectAll()
            txtPassword.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Phone Number can't be empty.")
            txtPhone.SelectAll()
            txtPhone.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(comboRole.SelectedItem) Then
            MessageBox.Show("Role can't be empty.")
            comboRole.SelectAll()
            comboRole.Focus()
            Return False
        End If
        Return True
    End Function
End Class