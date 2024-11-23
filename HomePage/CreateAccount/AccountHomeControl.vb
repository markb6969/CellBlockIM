Public Class AccountHomeControl
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim adminLogin As New LoginAdmin()
        adminLogin.Show()
        Me.ParentForm.Hide()

    End Sub

    Private Sub btnSuperAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        Dim superAdminLogin As New LogInSuperAdmin()
        superAdminLogin.Show()
        Me.ParentForm.Hide()
    End Sub


End Class
