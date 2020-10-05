Imports System.Net.Mail

Public Class UpdateOrder
    Private DB As New DBAccess
    Private Sub UpdateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dashboard.txtSaleID.Text = String.Empty Then
            MessageBox.Show("No sale selected.")
            Me.Close()
        Else
            DB.AddParam("@ID", Dashboard.txtSaleID.Text)
            DB.ExecuteQuery("SELECT * FROM sale WHERE id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If
        txtOrderID.Text = DB.DBDataTable(0)!id
        comboStatus.SelectedItem = DB.DBDataTable(0)!status

    End Sub
    Private Sub SaveUpdatedOrder()
        DB.AddParam("@status", comboStatus.SelectedItem)

        DB.AddParam("@saleid", txtOrderID.Text)

        DB.ExecuteQuery("UPDATE sale SET status = ?  WHERE id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Order " & txtOrderID.Text & " has been updated successfully.")
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    '   Private Sub SendEmailUpdate()
    '  Dim mail As New MailMessage()
    ' Dim smtp As New SmtpClient
    '
    'Try
    '        mail.To.Add("joemasters64@gmail.com")
    '       mail.From = New MailAddress("bis425email@gmail.com")
    '       mail.Subject = "Your oder is ready!"
    '       mail.Body = "Your order is ready for pickup!"
    '       smtp.Host = "smtp.gmail.com"
    '       smtp.Port = "465"
    '       smtp.EnableSsl = True
    '       smtp.Credentials = New System.Net.NetworkCredential("bis425email@gmail.com", "easystuff")
    '       smtp.Send(mail)
    '       MsgBox("sent")
    ' Catch ex As Exception
    '         MsgBox(ex.Message)
    ' End Try
    ' Me.Close()
    ' End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        SaveUpdatedOrder()
        ' SendEmailUpdate()
    End Sub


End Class