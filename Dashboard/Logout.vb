Public Class Logout

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Application.Exit()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        MainDashboard.Show()
        Me.Hide()
    End Sub
End Class