Public Class UpdateMedicalinfoControl
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToInmateHomeControl()
        End If
    End Sub
End Class
