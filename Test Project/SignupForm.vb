Imports System.Text.RegularExpressions
Public Class SignupForm
    Private DB As New DBAccess

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createDate.MaxDate = Today.Date
        ' Ensures users cannot create a customer prior than 7 days before today's date 
        createDate.MinDate = Today.Date.AddDays(-7)
        ' Automatically have active checkbox checked 
        chkActive.Checked = True
        ' Doesn't allow the user to change it 
        chkActive.Enabled = False
    End Sub

    Private Sub ClearForm()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtCardNumber.Clear()
        txtState.Clear()
        txtCity.Clear()
        txtAddress.Clear()
        txtZip.Clear()
        createDate.Value = Today.Date
        chkActive.Checked = True

    End Sub

    Private Function ValidateSignUp() As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First name can't be empty.")
            txtFirstName.SelectAll()
            txtFirstName.Focus()
            Return False
        End If

        Dim rxFirstName As New Regex("^[A-Z]+[a-z]+$")
        If Not rxFirstName.IsMatch(txtFirstName.Text) Then
            MessageBox.Show("First name must be all alphabets and start with a capital letter.")
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

        Dim rxLastName As New Regex("^[A-Z]+[a-z]+$")
        If Not rxLastName.IsMatch(txtLastName.Text) Then
            MessageBox.Show("Last name must be all alphabets and start with a capital letter.")
            txtLastName.SelectAll()
            txtLastName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Phone number can't be empty.")
            txtPhone.SelectAll()
            txtPhone.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email can't be empty.")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return False
        End If

        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")
        If Not rxEmail.IsMatch(txtEmail.Text) Then
            MessageBox.Show("Email must follow the right format such as abc@xyz.com.")
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
            MessageBox.Show("Card number can't be empty.")
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

        Dim rxState As New Regex("^[A-Z]+$")
        If Not rxState.IsMatch(txtState.Text) Then
            MessageBox.Show("State must be all alphabets and consist of two capital letters.")
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

        Dim rxCity As New Regex("^[A-Z]+[a-z]+$")
        If Not rxCity.IsMatch(txtCity.Text) Then
            MessageBox.Show("City must be all alphabets and start with a capital letter.")
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
            MessageBox.Show("Zip code can't be empty.")
            txtZip.SelectAll()
            txtZip.Focus()
            Return False
        End If

        Dim ZipInteger As Integer
        If Integer.TryParse(txtZip.Text, ZipInteger) = False Then
            MessageBox.Show("Zip must be an integer.")
            txtZip.SelectAll()
            txtZip.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub AddCustomer()
        DB.AddParam("@firstname", txtFirstName.Text)
        DB.AddParam("@lastname", txtLastName.Text)
        DB.AddParam("@cardnumber", txtCardNumber.Text)
        DB.AddParam("@phonenumber", txtPhone.Text)
        DB.AddParam("@email", txtEmail.Text)
        DB.AddParam("@password", txtPassword.Text)
        DB.AddParam("@address", txtAddress.Text)
        DB.AddParam("@city", txtCity.Text)
        DB.AddParam("@state", txtState.Text)
        DB.AddParam("@zip", txtZip.Text)
        DB.AddParam("@active", chkActive.Checked)
        DB.AddParam("@createdate", createDate.Value)


        DB.ExecuteQuery("INSERT INTO customer (firstname, lastname, cardnumber, phonenumber, email, password, address, city, state, zip, active, createdate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("Sign-up successful.")
    End Sub

    Private Sub SignupForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClearForm()
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        If ValidateSignUp() = False Then
            Exit Sub
        Else
            AddCustomer()
        End If
        Me.Close()
    End Sub
End Class