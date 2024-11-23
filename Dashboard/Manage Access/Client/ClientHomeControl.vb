Public Class ClientHomeControl
    Private Sub btnVisitor_Click(sender As Object, e As EventArgs) Handles btnVisitor.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToVisitationStatusControl()
    End Sub

    Private Sub btnReportConcerns_Click(sender As Object, e As EventArgs) Handles btnReportConcerns.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToConcernsControl()
    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToContactControl()
    End Sub
End Class
