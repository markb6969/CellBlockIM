Public Class LoginAdmin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AdminMainDashboard.Show()
        Me.Hide()

    End Sub
    Private Sub LoginAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class