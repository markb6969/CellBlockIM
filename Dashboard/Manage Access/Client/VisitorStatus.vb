Public Class VisitorStatus
    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToVisitationControl()
    End Sub
End Class
