Public Class Form1
    Dim cookies As Integer = 0
    Private Sub btnClick_Click(sender As System.Object, e As System.EventArgs) Handles btnClick.Click
        cookies = cookies + 1
        lblCookies.Text = cookies
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCookies.Text = cookies
    End Sub
End Class
