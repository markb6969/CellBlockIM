﻿Public Class ClientHomeControl
    Private Sub btnVisitor_Click(sender As Object, e As EventArgs) Handles btnVisitor.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)
        mainForm.SwitchToVisitationStatusControl()
    End Sub
End Class
