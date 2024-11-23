Public Class LogInSuperAdmin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        MainDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub LogInSuperAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub
End Class