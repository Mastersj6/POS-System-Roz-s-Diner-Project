Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numbers = New Integer() {23, 12, 13, 17, 22, 19}
        Dim m As Integer
        m = 0
        For i = 0 To 5
            If (Numbers(i) > Numbers(m)) Then
                m = i
            End If
        Next i
        MessageBox.Show(m)
    End Sub
End Class