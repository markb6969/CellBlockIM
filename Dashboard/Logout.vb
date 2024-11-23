Public Class Logout

    Private Sub btnYes_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs)
        MainDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class