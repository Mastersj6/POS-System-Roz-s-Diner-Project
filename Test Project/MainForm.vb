Public Class MainForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginForm.ShowDialog()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignupForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeLogin.ShowDialog()
    End Sub
End Class
