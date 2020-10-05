Imports System.Text.RegularExpressions

Public Class NewEmployeeForm
    Private DB As New DBAccess
    Private Sub NewEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensures users cannot create an employee in the future 
        CreateDateTimePicker.MaxDate = Today.Date
        ' Ensures users cannot create an employee prior than 7 days before today's date 
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
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailTextBox.Clear()
        comboRole.SelectedIndex = -1
        ActiveCheckBox.Checked = True
        CreateDateTimePicker.Value = Today.Date
        HireDateTimePicker.Value = Today.Date
    End Sub

    Private Function ValidateEmployee() As Boolean
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

        If String.IsNullOrWhiteSpace(comboRole.SelectedItem) Then
            MessageBox.Show("Role can't be empty.")
            comboRole.SelectAll()
            comboRole.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Phone Number can't be empty.")
            txtPhone.SelectAll()
            txtPhone.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password can't be empty.")
            txtPassword.SelectAll()
            txtPassword.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub AddEmployee()
        DB.AddParam("@firstname", FirstNameTextBox.Text)
        DB.AddParam("@lastname", LastNameTextBox.Text)
        DB.AddParam("@email", EmailTextBox.Text)
        DB.AddParam("@phonenumber", txtPhone.Text)
        DB.AddParam("@password", txtPassword.Text)
        DB.AddParam("@role", comboRole.SelectedItem)
        DB.AddParam("@active", ActiveCheckBox.Checked)
        DB.AddParam("@hiredate", HireDateTimePicker.Value)
        DB.AddParam("@createdate", CreateDateTimePicker.Value)

        DB.ExecuteQuery("INSERT INTO employee(firstname, lastname, email, phonenumber, password, role, active, dateofhire, createdate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?) ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A new employee was inserted successfully.")
    End Sub

    Private Sub NewEmployeeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClearForm()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateEmployee() = False Then
            Exit Sub
        Else
            AddEmployee()
        End If
        Me.Close()
    End Sub
End Class