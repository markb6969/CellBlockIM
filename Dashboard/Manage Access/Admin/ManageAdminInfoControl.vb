Public Class ManageAdminInfoControl
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToAdminHomeControl()

    End Sub
End Class
