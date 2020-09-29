Imports System.Text.RegularExpressions
Public Class EmployeeLogin
    Private DB As New DBAccess

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DV As Integer

        If ValidateLogin() = True Then
            DB.AddParam("@email", txtEmail.Text)
            DB.AddParam("@password", txtPassword.Text)
            DB.ExecuteQuery("SELECT * FROM employee WHERE email = ? and password = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            'DV is to make sure your login account exists and wont return a Null record
            DV = DB.RecordCount
            If DV = 0 Then
                MessageBox.Show("Not a valid account")
                Exit Sub
            End If
            MessageBox.Show("Login Successful.")
            txtEmail.Clear()
            txtPassword.Clear()
            Me.Hide()
            Dashboard.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub
    Private Function ValidateLogin() As Boolean
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter a correct email.")
            Return False
        End If

        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")
        If Not rxEmail.IsMatch(txtEmail.Text) Then
            MessageBox.Show("Email must follow the correct format, such as abc@123.com")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter a correct password.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class