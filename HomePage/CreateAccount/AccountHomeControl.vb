Public Class AccountHomeControl
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        LoginAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub btnSuperAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        LogInSuperAdmin.Show()
        Me.Hide()

    End Sub


End Class
