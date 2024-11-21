Public Class ReleaseInmateControl
    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToInmateHomeControl()
        End If
    End Sub
End Class
