Public Class LogInSuperAdmin


    Private Sub LogInSuperAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        MainDashboard.Show()
        Me.Hide()
    End Sub
End Class